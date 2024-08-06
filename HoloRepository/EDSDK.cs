using System;
using System.Runtime.InteropServices;

public static class EDSDK
{
    public const uint EDS_ERR_OK = 0x00000000;
    public const uint EDS_ERR_OBJECT_NOTREADY = 0x00000003;

    public const uint kEdsPropID_Evf_OutputDevice = 0x00000500;
    public const uint kEdsCameraCommand_TakePicture = 0x00000000;
    public const uint kEdsCameraCommand_StartLiveView = 0x00000101;
    public const uint kEdsCameraCommand_EndLiveView = 0x00000102;
    public const uint kEdsEvfOutputDevice_TFT = 1;
    public const uint kEdsEvfOutputDevice_PC = 2;
    public const uint kEdsObjectEvent_DirItemRequestTransfer = 0x00000208;

    public const uint EdsFileCreateDisposition_CreateAlways = 0x00000000;
    public const uint EdsAccess_ReadWrite = 0x00000000;
    public const uint PropID_Evf_Mode = 0x00000501;

    [DllImport("EDSDK.dll")]
    public static extern uint EdsInitializeSDK();

    [DllImport("EDSDK.dll")]
    public static extern uint EdsTerminateSDK();

    [DllImport("EDSDK.dll")]
    public static extern uint EdsGetCameraList(out IntPtr cameraListRef);

    [DllImport("EDSDK.dll")]
    public static extern uint EdsGetChildCount(IntPtr inRef, out int outCount);

    [DllImport("EDSDK.dll")]
    public static extern uint EdsGetChildAtIndex(IntPtr inRef, int inIndex, out IntPtr outRef);

    [DllImport("EDSDK.dll")]
    public static extern uint EdsOpenSession(IntPtr inCameraRef);

    [DllImport("EDSDK.dll")]
    public static extern uint EdsCloseSession(IntPtr inCameraRef);

    [DllImport("EDSDK.dll")]
    public static extern uint EdsRelease(IntPtr inRef);

    [DllImport("EDSDK.dll")]
    public static extern uint EdsSendCommand(IntPtr inCameraRef, uint inCommand, int inParam);

    [DllImport("EDSDK.dll")]
    public static extern uint EdsCreateMemoryStream(uint inBufferSize, out IntPtr outStream);

    [DllImport("EDSDK.dll")]
    public static extern uint EdsCreateFileStream(string inFileName, uint inCreateDisposition, uint inDesiredAccess, out IntPtr outStream);

    [DllImport("EDSDK.dll")]
    public static extern uint EdsGetPointer(IntPtr inStream, out IntPtr outPointer);

    [DllImport("EDSDK.dll")]
    public static extern uint EdsGetLength(IntPtr inStream, out uint outLength);

    [DllImport("EDSDK.dll")]
    public static extern uint EdsDownload(IntPtr inDirItemRef, uint inReadSize, IntPtr outStream);

    [DllImport("EDSDK.dll")]
    public static extern uint EdsDownloadComplete(IntPtr inDirItemRef);

    [DllImport("EDSDK.dll")]
    public static extern uint EdsCreateEvfImageRef(IntPtr inStream, out IntPtr outEvfImageRef);

    [DllImport("EDSDK.dll")]
    public static extern uint EdsDownloadEvfImage(IntPtr inCameraRef, IntPtr outEvfImageRef);

    [DllImport("EDSDK.dll")]
    public static extern uint EdsSetObjectEventHandler(IntPtr inCameraRef, uint inEvent, EdsObjectEventHandler inObjectEventHandler, IntPtr inContext);

    [DllImport("EDSDK.dll")]
    public static extern uint EdsSetPropertyData(IntPtr inRef, uint inPropertyID, int inParam, uint inSize, IntPtr inData);
    
    
    public delegate uint EdsObjectEventHandler(uint inEvent, IntPtr inRef, IntPtr inContext);

    [StructLayout(LayoutKind.Sequential)]
    public struct EdsDirectoryItemInfo
    {
        public uint Size;
        public uint IsFolder;
        public uint GroupID;
        public uint Option;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 260)]
        public string szFileName;
        public uint Format;
        public uint DateTime;
    }

    [DllImport("EDSDK.dll")]
    public static extern uint EdsGetDirectoryItemInfo(IntPtr inDirItemRef, out EdsDirectoryItemInfo outDirItemInfo);
}
