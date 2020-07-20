using System;
using System.Runtime.InteropServices;

namespace Se7en.OpenCl.Native
{
    public static partial class NativeCl
    {
        [DllImport(InternalLibLoader.OpenCL, EntryPoint = nameof(clCreateProgramWithSource))]
        public static extern IntPtr CreateProgramWithSource(IntPtr context, uint count, [In][MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.LPStr, SizeParamIndex = 1)] string[] strings, [In][MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.SysUInt, SizeParamIndex = 1)] IntPtr[] lengths, out int errcodeRet);

        [DllImport(InternalLibLoader.OpenCL, EntryPoint = nameof(clBuildProgram))]
        public static extern int BuildProgram(IntPtr program, uint numDevices, [In][MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.SysUInt, SizeParamIndex = 1)] IntPtr[] deviceList, [In][MarshalAs(UnmanagedType.LPStr)] string options, ProgramNotify pfnNotify, IntPtr userData);

        [DllImport(InternalLibLoader.OpenCL, EntryPoint = nameof(clRetainProgram))]
        public static extern int RetainProgram(IntPtr program);

        [DllImport(InternalLibLoader.OpenCL, EntryPoint = nameof(clReleaseProgram))]
        public static extern int ReleaseProgram(IntPtr program);

        [DllImport(InternalLibLoader.OpenCL, EntryPoint = nameof(clGetProgramInfo))]
        public unsafe static extern int GetProgramInfo(IntPtr program, uint paramName, IntPtr paramValueSize, void* paramValue, out IntPtr paramValueSizeRet);
    }
}