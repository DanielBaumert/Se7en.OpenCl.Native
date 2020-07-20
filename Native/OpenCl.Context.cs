using Se7en.OpenCl;
using System;
using System.Runtime.InteropServices;

namespace Se7en.OpenCl.Native
{
    public unsafe static partial class NativeCl
    {
        [DllImport(InternalLibLoader.OpenCL, EntryPoint = nameof(clCreateContext))]
        public static extern IntPtr CreateContext([In][MarshalAs(UnmanagedType.LPArray)] void* properties, uint numDevices, [In][MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] IntPtr[] devices, ContextNotify pfnNotify, IntPtr userData, out int errcodeRet);

        [DllImport(InternalLibLoader.OpenCL, EntryPoint = nameof(clCreateContextFromType))]
        public static extern IntPtr CreateContextFromType([In][MarshalAs(UnmanagedType.LPArray)] void* properties, ulong deviceType, ContextNotify pfnNotify, IntPtr userData, [Out][MarshalAs(UnmanagedType.I4)] out int errcodeRet);

        [DllImport(InternalLibLoader.OpenCL, EntryPoint = nameof(clGetContextInfo))]
        public static extern int GetContextInfo(IntPtr context, uint paramName, IntPtr paramValueSize, void* paramValue, out IntPtr paramValueSizeRet);


        [DllImport(InternalLibLoader.OpenCL, EntryPoint = nameof(clRetainContext))]
        public static extern int RetainContext(IntPtr context);

        [DllImport(InternalLibLoader.OpenCL, EntryPoint = nameof(clReleaseContext))]
        public static extern int ReleaseContext(IntPtr context);

    }
}