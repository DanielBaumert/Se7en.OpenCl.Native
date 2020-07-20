namespace Se7en.OpenCl.Native
{

    public partial class NativeCl
    {
        public const int CL_DEVICE_AFFINITY_DOMAIN_NUMA = (1 << 0);
        public const int CL_DEVICE_AFFINITY_DOMAIN_L4_CACHE = (1 << 1);
        public const int CL_DEVICE_AFFINITY_DOMAIN_L3_CACHE = (1 << 2);
        public const int CL_DEVICE_AFFINITY_DOMAIN_L2_CACHE = (1 << 3);
        public const int CL_DEVICE_AFFINITY_DOMAIN_L1_CACHE = (1 << 4);
        public const int CL_DEVICE_AFFINITY_DOMAIN_NEXT_PARTITIONABLE = (1 << 5);
    }
}