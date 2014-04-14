Imports System.Runtime.InteropServices

Namespace Modules

    Friend Module NativeMethods

        Friend Const EmSetCueBanner As UInt32 = EcmFirst + 1

        Friend Const EcmFirst As UInt32 = &H1500

        <DllImport("user32.dll", EntryPoint:="SendMessageW")> _
        Public Function SendMessageW(hWnd As IntPtr, msg As UInt32, wParam As IntPtr, <MarshalAs(UnmanagedType.LPWStr)> lParam As [String]) As IntPtr
        End Function

        <DllImport("user32.dll")> _
        Public Function GetComboBoxInfo(hwnd As IntPtr, ByRef pcbi As ComboboxInfo) As [Boolean]
        End Function

        <StructLayout(LayoutKind.Sequential)> _
        Public Structure ComboboxInfo
            Public cbSize As Int32
            Public rcItem As Rect
            Public rcButton As Rect
            Public stateButton As Int32
            Public hwndCombo As IntPtr
            Public hwndItem As IntPtr
            Public hwndList As IntPtr
        End Structure

        <StructLayout(LayoutKind.Sequential)> _
        Public Structure Rect
            Public left As Int32
            Public top As Int32
            Public right As Int32
            Public bottom As Int32
        End Structure

    End Module
End Namespace