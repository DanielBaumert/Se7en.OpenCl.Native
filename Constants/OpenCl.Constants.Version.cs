namespace Se7en.OpenCl.Native
{

    public partial class NativeCl
    {
        public const int CL_VERSION_MAJOR_BITS = (10);
        public const int CL_VERSION_MINOR_BITS = (10);
        public const int CL_VERSION_PATCH_BITS = (12);

        public const int CL_VERSION_MAJOR_MASK = ((1 << CL_VERSION_MAJOR_BITS) - 1);
        public const int CL_VERSION_MINOR_MASK = ((1 << CL_VERSION_MINOR_BITS) - 1);
        public const int CL_VERSION_PATCH_MASK = ((1 << CL_VERSION_PATCH_BITS) - 1);
    }
}