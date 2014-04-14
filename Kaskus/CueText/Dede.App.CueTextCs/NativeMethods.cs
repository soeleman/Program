namespace Dede.App.CueText
{
    using System;
    using System.Runtime.InteropServices;

    internal sealed class NativeMethods
    {
        internal const UInt32 EmSetCueBanner = EcmFirst + 1;

        internal const UInt32 EcmFirst = 0x1500;

        [DllImport("user32.dll", EntryPoint = "SendMessageW")]
        public static extern IntPtr SendMessageW(
            IntPtr hWnd,
            UInt32 msg,
            IntPtr wParam,
            [MarshalAs(UnmanagedType.LPWStr)] String lParam);

        [DllImport("user32.dll")]
        public static extern Boolean GetComboBoxInfo(
            IntPtr hwnd,
            ref ComboboxInfo pcbi);

        [StructLayout(LayoutKind.Sequential)]
        public struct ComboboxInfo
        {
            public Int32 cbSize;
            public Rect rcItem;
            public Rect rcButton;
            public Int32 stateButton;
            public IntPtr hwndCombo;
            public IntPtr hwndItem;
            public IntPtr hwndList;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct Rect
        {
            public Int32 left;
            public Int32 top;
            public Int32 right;
            public Int32 bottom;
        }
    }
}