using Se7en.OpenCl;
using System;
using System.Runtime.InteropServices;

namespace Se7en.OpenCl.Native
{
    public unsafe static partial class NativeCl
    {
        [DllImport(InternalLibLoader.OpenCL, EntryPoint = nameof(clGetPlatformIDs))]
        public static extern int GetPlatformIDs(uint numEntries, [Out] void* platforms, out uint numPlatforms);
        
        [DllImport(InternalLibLoader.OpenCL, EntryPoint = nameof(clGetPlatformInfo))]
        public static extern int GetPlatformInfo(IntPtr platform, uint paramName, IntPtr paramValueSize, void* paramValue, out IntPtr paramValueSizeRet);
    }
}