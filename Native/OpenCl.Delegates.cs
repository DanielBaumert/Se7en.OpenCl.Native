using System;

namespace Se7en.OpenCl.Native
{
    public delegate void ContextNotify(string errInfo, byte[] data, IntPtr cb, IntPtr userData);
    public delegate void ProgramNotify(IntPtr program, IntPtr userData);
}