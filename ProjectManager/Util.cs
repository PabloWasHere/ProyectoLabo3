using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace ProjectManager
{
    public static class Util
    {
        public enum Effect { Roll, Slide, Center, Blend }

        public static void Animate(Control ctl, Effect effect, int msec, int angle)
        {
            int flags = effmap[(int)effect];
            if (ctl.Visible) { flags |= 0x10000; angle += 180; }
            else
            {
                if (ctl.TopLevelControl == ctl) flags |= 0x20000;
                else if (effect == Effect.Blend) throw new ArgumentException();
            }
            flags |= dirmap[(angle % 360) / 45];
            bool ok = AnimateWindow(ctl.Handle, msec, flags);
            if (!ok) throw new Exception("Animation failed");
            ctl.Visible = !ctl.Visible;
        }

        private static int[] dirmap = { 1, 5, 4, 6, 2, 10, 8, 9 };
        private static int[] effmap = { 0, 0x40000, 0x10, 0x80000 };

        [DllImport("user32.dll")]
        private static extern bool AnimateWindow(IntPtr handle, int msec, int flags);

        public static void slideToDestination(Form form, Control destination, Control control, int delay, Action onFinish)
        {
            new Task(() =>
            {
                int directionX = destination.Left > control.Left ? 1 : -1;
                int directionY = destination.Top > control.Top ? 1 : -1;

                while (control.Left != destination.Left || control.Top != destination.Top)
                {
                    try
                    {
                        if (control.Left != destination.Left)
                        {
                            form.Invoke((Action)delegate()
                            {
                                control.Left += directionX;
                            });
                        }
                        if (control.Top != destination.Top)
                        {
                            form.Invoke((Action)delegate()
                            {
                                control.Top += directionY;
                            });
                        }
                        Thread.Sleep(delay);
                    }
                    catch
                    {
                        // form could be disposed
                        break;
                    }
                }

                if (onFinish != null) onFinish();

            }).Start();
        }
    }
}
