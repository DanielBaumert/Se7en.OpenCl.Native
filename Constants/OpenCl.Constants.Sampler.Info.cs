namespace Se7en.OpenCl.Native
{

    public partial class NativeCl
    {
        public const int CL_SAMPLER_REFERENCE_COUNT = 0x1150;
        public const int CL_SAMPLER_CONTEXT = 0x1151;
        public const int CL_SAMPLER_NORMALIZED_COORDS = 0x1152;
        public const int CL_SAMPLER_ADDRESSING_MODE = 0x1153;
        public const int CL_SAMPLER_FILTER_MODE = 0x1154;

        /* These enumerants are for the cl_khr_mipmap_image extension.
           They have since been added to cl_ext.h with an appropriate
           KHR suffix, but are left here for backwards compatibility. */
        public const int CL_SAMPLER_MIP_FILTER_MODE = 0x1155;
        public const int CL_SAMPLER_LOD_MIN = 0x1156;
        public const int CL_SAMPLER_LOD_MAX = 0x1157;


        public const int CL_SAMPLER_PROPERTIES = 0x1158;
    }
}