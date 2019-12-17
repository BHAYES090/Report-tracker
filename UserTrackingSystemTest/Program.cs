using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Diagnostics;
using System.Windows.Forms;
using System.IO;

    namespace UserTrackingSystemTest
    {
        class Program
        {
            private static int WH_KEYBOARD_LL = 13;
            private static int WM_KEYDOWN = 0x0100;
            private static IntPtr hook = IntPtr.Zero;
            private static LowLevekKeyboardProc 11kProcedure = HookCallback;
            static void Main(string[] args)
            {
                hook = SetHook(11kProcedure);
                Application.Run();
                UnhookWindowsHookEx(hook);

            }


        }
    }
