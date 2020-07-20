using System;
using System.Runtime.InteropServices;

namespace Se7en.OpenCl.Native
{
    public unsafe static partial class NativeCl
    {

        [DllImport(InternalLibLoader.OpenCL, EntryPoint = nameof(clGetDeviceIDs))]
        public static extern int GetDeviceIDs(IntPtr platform, ulong deviceType, IntPtr numEntries, [Out] void* devices, out IntPtr numDevices);

        [DllImport(InternalLibLoader.OpenCL, EntryPoint = nameof(clGetDeviceInfo))]
        public static extern int GetDeviceInfo(IntPtr device, uint paramName, IntPtr paramValueSize, [Out] void* paramValue, out IntPtr paramValueSizeRet);

        [DllImport(InternalLibLoader.OpenCL, EntryPoint = nameof(clReleaseDevice))]
        public static extern int ReleaseDevice(IntPtr device);

        [DllImport(InternalLibLoader.OpenCL, EntryPoint = nameof(clRetainDevice))]
        public static extern int RetainDevice(IntPtr device);

    }
}
