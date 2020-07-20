namespace Se7en.OpenCl.Native
{

    public partial class NativeCl
    {
        public const int CL_DEVICE_ATOMIC_ORDER_RELAXED = (1 << 0);
        public const int CL_DEVICE_ATOMIC_ORDER_ACQ_REL = (1 << 1);
        public const int CL_DEVICE_ATOMIC_ORDER_SEQ_CST = (1 << 2);
        public const int CL_DEVICE_ATOMIC_SCOPE_WORK_ITEM = (1 << 3);
        public const int CL_DEVICE_ATOMIC_SCOPE_WORK_GROUP = (1 << 4);
        public const int CL_DEVICE_ATOMIC_SCOPE_DEVICE = (1 << 5);
        public const int CL_DEVICE_ATOMIC_SCOPE_ALL_DEVICES = (1 << 6);
    }
}