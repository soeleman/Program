namespace Dede.App.CueText
{
    using System;
    using System.Runtime.InteropServices;
    using System.Windows.Forms;

    public static class Extensions
    {
        public static void CueText(
            this Control control,
            String text)
        {
            NativeMethods.SendMessageW(
                control is ComboBox
                     ? control.GetComboBoxInfo().hwndItem
                     : control.Handle,
                NativeMethods.EmSetCueBanner,
                (IntPtr)0,
                text);
        }

        internal static NativeMethods.ComboboxInfo GetComboBoxInfo(
            this IWin32Window control)
        {
            var info = new NativeMethods.ComboboxInfo();
            info.cbSize = Marshal.SizeOf(info);
            NativeMethods.GetComboBoxInfo(control.Handle, ref info);
            return info;
        }
    }
}