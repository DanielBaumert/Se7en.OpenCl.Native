namespace Se7en.OpenCl.Native
{

    public partial class NativeCl
    {
        public const int CL_DEVICE_TYPE_DEFAULT = (1 << 0);
        public const int CL_DEVICE_TYPE_CPU = (1 << 1);
        public const int CL_DEVICE_TYPE_GPU = (1 << 2);
        public const int CL_DEVICE_TYPE_ACCELERATOR = (1 << 3);

        public const int CL_DEVICE_TYPE_CUSTOM = (1 << 4);

        public const uint CL_DEVICE_TYPE_ALL = 0xFFFFFFFF;
    }
}