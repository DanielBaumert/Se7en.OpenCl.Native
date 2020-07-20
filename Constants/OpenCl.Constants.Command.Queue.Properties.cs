namespace Se7en.OpenCl.Native
{

    public partial class NativeCl
    {
        public const int CL_QUEUE_OUT_OF_ORDER_EXEC_MODE_ENABLE = (1 << 0);
        public const int CL_QUEUE_PROFILING_ENABLE = (1 << 1);

        public const int CL_QUEUE_ON_DEVICE = (1 << 2);
        public const int CL_QUEUE_ON_DEVICE_DEFAULT = (1 << 3);
    }
}