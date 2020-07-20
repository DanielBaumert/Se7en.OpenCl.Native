using System;
using System.Runtime.InteropServices;

namespace Se7en.OpenCl.Native
{
    public unsafe static partial class NativeCl
    {

        [DllImport(InternalLibLoader.OpenCL, EntryPoint = nameof(clWaitForEvents))]
        public static extern int WaitForEvents(uint numEvents, [In][MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.SysUInt, SizeParamIndex = 0)] IntPtr[] eventWaitList);

        [DllImport(InternalLibLoader.OpenCL, EntryPoint = nameof(clGetEventInfo))]
        public static extern int GetEventInfo(IntPtr e, uint paramName, IntPtr paramValueSize, void* paramValue, out IntPtr paramValueSizeRet);

        [DllImport(InternalLibLoader.OpenCL, EntryPoint = nameof(clRetainEvent))]
        public static extern int RetainEvent(IntPtr e);

        [DllImport(InternalLibLoader.OpenCL, EntryPoint = nameof(clReleaseEvent))]
        public static extern int ReleaseEvent(IntPtr e);

    }
}