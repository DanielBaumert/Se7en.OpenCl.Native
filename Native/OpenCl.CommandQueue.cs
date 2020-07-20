using System;
using System.Runtime.InteropServices;

namespace Se7en.OpenCl.Native
{
    public unsafe static partial class NativeCl
    {
        [DllImport(InternalLibLoader.OpenCL, EntryPoint = nameof(clCreateCommandQueue))]
        public static extern IntPtr CreateCommandQueue(IntPtr context, IntPtr device, [MarshalAs(UnmanagedType.U8)] ulong properties, [Out][MarshalAs(UnmanagedType.I4)] out int error);

        [DllImport(InternalLibLoader.OpenCL, EntryPoint = nameof(clCreateCommandQueueWithProperties))]
        public static extern IntPtr CreateCommandQueueWithProperties(IntPtr context, IntPtr device, [MarshalAs(UnmanagedType.LPArray)] void* properties, [Out][MarshalAs(UnmanagedType.I4)] out int error);

        [DllImport(InternalLibLoader.OpenCL, EntryPoint = nameof(clGetCommandQueueInfo))]
        public static extern int GetCommandQueueInfo(IntPtr commandQueue, [MarshalAs(UnmanagedType.U4)] uint paramName, IntPtr paramValueSize, void* paramValue, out IntPtr paramValueSizeRet);

        [DllImport(InternalLibLoader.OpenCL, EntryPoint = nameof(clRetainCommandQueue))]
        public static extern int RetainCommandQueue(IntPtr commandQueue);

        [DllImport(InternalLibLoader.OpenCL, EntryPoint = nameof(clReleaseCommandQueue))]
        public static extern int ReleaseCommandQueue(IntPtr commandQueue);

        [DllImport(InternalLibLoader.OpenCL, EntryPoint = nameof(clFinish))]
        public static extern int Finish(IntPtr commandQueue);
    }
}