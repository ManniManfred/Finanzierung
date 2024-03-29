﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace FinzanzierungsApp
{
    public static class FormExtensions
    {
        public static void FromXml(this Form form, XElement parentElement)
        {
            var xMainForm = parentElement.Element(form.Name);
            if (xMainForm != null)
            {
                form.Width = xMainForm.GetAttributeValue("Width", form.Width);
                form.Height = xMainForm.GetAttributeValue("Height", form.Height);
                form.WindowState = xMainForm.GetAttributeValue("WindowState", form.WindowState);
            }
        }

        public static void ToXml(this Form form, XElement parentElement)
        {
            var xMainForm = new XElement(form.Name);
            parentElement.Add(xMainForm);
            
            xMainForm.SetAttributeValue("Width", form.Width);
            xMainForm.SetAttributeValue("Height", form.Height);
            xMainForm.SetAttributeValue("WindowState", form.WindowState);
        }

        [DllImport("user32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool GetWindowPlacement(IntPtr hWnd, ref WINDOWPLACEMENT lpwndpl);


        private struct WINDOWPLACEMENT
        {
            public int length;
            public int flags;
            public int showCmd;
            public System.Drawing.Point ptMinPosition;
            public System.Drawing.Point ptMaxPosition;
            public System.Drawing.Rectangle rcNormalPosition;
        }

        public static void RestoreFromMinimzied(this Form form)
        {
            const int WPF_RESTORETOMAXIMIZED = 0x2;
            WINDOWPLACEMENT placement = new WINDOWPLACEMENT();
            placement.length = Marshal.SizeOf(placement);
            GetWindowPlacement(form.Handle, ref placement);

            if ((placement.flags & WPF_RESTORETOMAXIMIZED) == WPF_RESTORETOMAXIMIZED)
                form.WindowState = FormWindowState.Maximized;
            else
                form.WindowState = FormWindowState.Normal;
        }
    }
}
