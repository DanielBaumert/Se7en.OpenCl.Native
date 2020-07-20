namespace Se7en.OpenCl.Native
{

    public partial class NativeCl
    {
        public const int CL_KERNEL_ARG_TYPE_NONE = 0;
        public const int CL_KERNEL_ARG_TYPE_CONST = (1 << 0);
        public const int CL_KERNEL_ARG_TYPE_RESTRICT = (1 << 1);
        public const int CL_KERNEL_ARG_TYPE_VOLATILE = (1 << 2);

        public const int CL_KERNEL_ARG_TYPE_PIPE = (1 << 3);
    }
}