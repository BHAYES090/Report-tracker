using Caliburn.Micro;
using RTDesktopUI.Library.API;
using RTDesktopUI.Library.EventModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Management.Automation;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using WPFTRACKERUI.Helpers;


namespace WPFTRACKERUI.ViewModels
{
    public class LoginViewModel : Screen
    {
        private string _userName = "Bobbyhayes090@gmail.com";
        private string _password = "P@55w.rd";
        private IAPIHelper _apiHelper;
        private IEventAggregator _events;

        public LoginViewModel(IAPIHelper apihelper, IEventAggregator events)
        {
            _apiHelper = apihelper;
            _events = events;
        }
        public string UserName
        {
            get { return _userName; }
            set
            {
                _userName = value;
                NotifyOfPropertyChange(() => UserName);
                NotifyOfPropertyChange(() => CanLogIn);
            }
        }
        public string Password
        {
            get { return _password; }
            set
            {
                _password = value;
                NotifyOfPropertyChange(() => Password);
                NotifyOfPropertyChange(() => CanLogIn);
            }
        }
        public bool IsErrorVisable
        {
            get
            {
                bool output = false;
                if (ErrorMessage?.Length > 0)
                {
                    output = true;
                }
                return output;
            }
        }

        private string _errorMessage;
        public string ErrorMessage
        {
            get { return _errorMessage; }
            set
            {
                _errorMessage = value;
                NotifyOfPropertyChange(() => IsErrorVisable);
                NotifyOfPropertyChange(() => ErrorMessage);
            }
        }


        public bool CanLogIn
        {
            get
            {
                bool output = false;

                if (UserName?.Length > 0 && Password?.Length > 0)
                {
                    output = true;
                }

                return output;
            }
        }
        /// <summary>
        /// PowerShell starts and uses the script to start psr.exe adn saves it to a zipfile 
        /// </summary>
        public async Task LogIn()
        {
            try
            {
                using (PowerShell PowerShellInstance = PowerShell.Create())
                {
                    PowerShellInstance.AddScript("psr.exe /start /output C:/Users/bobby/Documents/Steps.zip");

                    IAsyncResult result1 = PowerShellInstance.BeginInvoke();

                    while (result1.IsCompleted == false)
                    {
                        Console.WriteLine();
                        Thread.Sleep(1000);
                    }
                }

                var result = await _apiHelper.Authenticate(UserName, Password);

                await _apiHelper.GetLoggedInUserInfo(result.Access_Token);

                _events.PublishOnUIThread(new LogOnEvent());

            }
            catch (Exception ex)
            {
                ErrorMessage = ex.Message;
            }
        }
    }
}
