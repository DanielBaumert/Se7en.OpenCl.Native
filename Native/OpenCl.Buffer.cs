using Se7en.OpenCl;
using System;
using System.Runtime.InteropServices;

namespace Se7en.OpenCl.Native
{
    public unsafe static partial class NativeCl
    {
        [DllImport(InternalLibLoader.OpenCL, EntryPoint = nameof(clCreateBuffer))]
        public static extern IntPtr CreateBuffer(IntPtr context, ulong flags, IntPtr size, IntPtr hostPtr, [Out][MarshalAs(UnmanagedType.I4)] out int errcodeRet);

        [DllImport(InternalLibLoader.OpenCL, EntryPoint = nameof(clRetainMemObject))]
        public static extern int RetainMemObject(IntPtr memObj);

        [DllImport(InternalLibLoader.OpenCL, EntryPoint = nameof(clReleaseMemObject))]
        public static extern int ReleaseMemObject(IntPtr memObj);

        [DllImport(InternalLibLoader.OpenCL, EntryPoint = nameof(clEnqueueWriteBuffer))]
        public static extern int EnqueueWriteBuffer(IntPtr commandQueue, IntPtr buffer, int blockingWrite, IntPtr offsetInBytes, long lengthInBytes, IntPtr ptr, uint numEventsInWaitList, [In][MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.SysUInt, SizeParamIndex = 6)] IntPtr[] eventWaitList, [Out][MarshalAs(UnmanagedType.Struct)] out IntPtr e);

        [DllImport(InternalLibLoader.OpenCL, EntryPoint = nameof(clEnqueueReadBuffer))]
        public static extern int EnqueueReadBuffer(IntPtr commandQueue, IntPtr buffer, int blockingRead, int offsetInBytes, int lengthInBytes, IntPtr ptr, uint numEventsInWaitList, [In][MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.SysUInt, SizeParamIndex = 6)] IntPtr[] eventWaitList, [Out][MarshalAs(UnmanagedType.Struct)] out IntPtr e);


        [DllImport(InternalLibLoader.OpenCL, EntryPoint = nameof(clGetMemObjectInfo))]
        public static extern int GetMemObjectInfo(IntPtr memObj, uint paramName, IntPtr paramValueSize, void* paramValue, out IntPtr paramValueSizeRet);


    }
}
