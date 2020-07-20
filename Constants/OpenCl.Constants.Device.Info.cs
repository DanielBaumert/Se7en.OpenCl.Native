namespace Se7en.OpenCl.Native
{

    public partial class NativeCl
    {
        public const int CL_DEVICE_TYPE = 0x1000;
        public const int CL_DEVICE_VENDOR_ID = 0x1001;
        public const int CL_DEVICE_MAX_COMPUTE_UNITS = 0x1002;
        public const int CL_DEVICE_MAX_WORK_ITEM_DIMENSIONS = 0x1003;
        public const int CL_DEVICE_MAX_WORK_GROUP_SIZE = 0x1004;
        public const int CL_DEVICE_MAX_WORK_ITEM_SIZES = 0x1005;
        public const int CL_DEVICE_PREFERRED_VECTOR_WIDTH_CHAR = 0x1006;
        public const int CL_DEVICE_PREFERRED_VECTOR_WIDTH_SHORT = 0x1007;
        public const int CL_DEVICE_PREFERRED_VECTOR_WIDTH_INT = 0x1008;
        public const int CL_DEVICE_PREFERRED_VECTOR_WIDTH_LONG = 0x1009;
        public const int CL_DEVICE_PREFERRED_VECTOR_WIDTH_FLOAT = 0x100A;
        public const int CL_DEVICE_PREFERRED_VECTOR_WIDTH_DOUBLE = 0x100B;
        public const int CL_DEVICE_MAX_CLOCK_FREQUENCY = 0x100C;
        public const int CL_DEVICE_ADDRESS_BITS = 0x100D;
        public const int CL_DEVICE_MAX_READ_IMAGE_ARGS = 0x100E;
        public const int CL_DEVICE_MAX_WRITE_IMAGE_ARGS = 0x100F;
        public const int CL_DEVICE_MAX_MEM_ALLOC_SIZE = 0x1010;
        public const int CL_DEVICE_IMAGE2D_MAX_WIDTH = 0x1011;
        public const int CL_DEVICE_IMAGE2D_MAX_HEIGHT = 0x1012;
        public const int CL_DEVICE_IMAGE3D_MAX_WIDTH = 0x1013;
        public const int CL_DEVICE_IMAGE3D_MAX_HEIGHT = 0x1014;
        public const int CL_DEVICE_IMAGE3D_MAX_DEPTH = 0x1015;
        public const int CL_DEVICE_IMAGE_SUPPORT = 0x1016;
        public const int CL_DEVICE_MAX_PARAMETER_SIZE = 0x1017;
        public const int CL_DEVICE_MAX_SAMPLERS = 0x1018;
        public const int CL_DEVICE_MEM_BASE_ADDR_ALIGN = 0x1019;
        public const int CL_DEVICE_MIN_DATA_TYPE_ALIGN_SIZE = 0x101A;
        public const int CL_DEVICE_SINGLE_FP_CONFIG = 0x101B;
        public const int CL_DEVICE_GLOBAL_MEM_CACHE_TYPE = 0x101C;
        public const int CL_DEVICE_GLOBAL_MEM_CACHELINE_SIZE = 0x101D;
        public const int CL_DEVICE_GLOBAL_MEM_CACHE_SIZE = 0x101E;
        public const int CL_DEVICE_GLOBAL_MEM_SIZE = 0x101F;
        public const int CL_DEVICE_MAX_CONSTANT_BUFFER_SIZE = 0x1020;
        public const int CL_DEVICE_MAX_CONSTANT_ARGS = 0x1021;
        public const int CL_DEVICE_LOCAL_MEM_TYPE = 0x1022;
        public const int CL_DEVICE_LOCAL_MEM_SIZE = 0x1023;
        public const int CL_DEVICE_ERROR_CORRECTION_SUPPORT = 0x1024;
        public const int CL_DEVICE_PROFILING_TIMER_RESOLUTION = 0x1025;
        public const int CL_DEVICE_ENDIAN_LITTLE = 0x1026;
        public const int CL_DEVICE_AVAILABLE = 0x1027;
        public const int CL_DEVICE_COMPILER_AVAILABLE = 0x1028;
        public const int CL_DEVICE_EXECUTION_CAPABILITIES = 0x1029;
        public const int CL_DEVICE_QUEUE_PROPERTIES = 0x102A;    /* deprecated */

        public const int CL_DEVICE_QUEUE_ON_HOST_PROPERTIES = 0x102A;

        public const int CL_DEVICE_NAME = 0x102B;
        public const int CL_DEVICE_VENDOR = 0x102C;
        public const int CL_DRIVER_VERSION = 0x102D;
        public const int CL_DEVICE_PROFILE = 0x102E;
        public const int CL_DEVICE_VERSION = 0x102F;
        public const int CL_DEVICE_EXTENSIONS = 0x1030;
        public const int CL_DEVICE_PLATFORM = 0x1031;

        public const int CL_DEVICE_DOUBLE_FP_CONFIG = 0x1032;

        /* 0x1033 reserved for CL_DEVICE_HALF_FP_CONFIG which is already defined in nameof(cl_ext.h) */

        public const int CL_DEVICE_PREFERRED_VECTOR_WIDTH_HALF = 0x1034;
        public const int CL_DEVICE_HOST_UNIFIED_MEMORY = 0x1035;   /* deprecated */
        public const int CL_DEVICE_NATIVE_VECTOR_WIDTH_CHAR = 0x1036;
        public const int CL_DEVICE_NATIVE_VECTOR_WIDTH_SHORT = 0x1037;
        public const int CL_DEVICE_NATIVE_VECTOR_WIDTH_INT = 0x1038;
        public const int CL_DEVICE_NATIVE_VECTOR_WIDTH_LONG = 0x1039;
        public const int CL_DEVICE_NATIVE_VECTOR_WIDTH_FLOAT = 0x103A;
        public const int CL_DEVICE_NATIVE_VECTOR_WIDTH_DOUBLE = 0x103B;
        public const int CL_DEVICE_NATIVE_VECTOR_WIDTH_HALF = 0x103C;
        public const int CL_DEVICE_OPENCL_C_VERSION = 0x103D;


        public const int CL_DEVICE_LINKER_AVAILABLE = 0x103E;
        public const int CL_DEVICE_BUILT_IN_KERNELS = 0x103F;
        public const int CL_DEVICE_IMAGE_MAX_BUFFER_SIZE = 0x1040;
        public const int CL_DEVICE_IMAGE_MAX_ARRAY_SIZE = 0x1041;
        public const int CL_DEVICE_PARENT_DEVICE = 0x1042;
        public const int CL_DEVICE_PARTITION_MAX_SUB_DEVICES = 0x1043;
        public const int CL_DEVICE_PARTITION_PROPERTIES = 0x1044;
        public const int CL_DEVICE_PARTITION_AFFINITY_DOMAIN = 0x1045;
        public const int CL_DEVICE_PARTITION_TYPE = 0x1046;
        public const int CL_DEVICE_REFERENCE_COUNT = 0x1047;
        public const int CL_DEVICE_PREFERRED_INTEROP_USER_SYNC = 0x1048;
        public const int CL_DEVICE_PRINTF_BUFFER_SIZE = 0x1049;


        public const int CL_DEVICE_IMAGE_PITCH_ALIGNMENT = 0x104A;
        public const int CL_DEVICE_IMAGE_BASE_ADDRESS_ALIGNMENT = 0x104B;
        public const int CL_DEVICE_MAX_READ_WRITE_IMAGE_ARGS = 0x104C;
        public const int CL_DEVICE_MAX_GLOBAL_VARIABLE_SIZE = 0x104D;
        public const int CL_DEVICE_QUEUE_ON_DEVICE_PROPERTIES = 0x104E;
        public const int CL_DEVICE_QUEUE_ON_DEVICE_PREFERRED_SIZE = 0x104F;
        public const int CL_DEVICE_QUEUE_ON_DEVICE_MAX_SIZE = 0x1050;
        public const int CL_DEVICE_MAX_ON_DEVICE_QUEUES = 0x1051;
        public const int CL_DEVICE_MAX_ON_DEVICE_EVENTS = 0x1052;
        public const int CL_DEVICE_SVM_CAPABILITIES = 0x1053;
        public const int CL_DEVICE_GLOBAL_VARIABLE_PREFERRED_TOTAL_SIZE = 0x1054;
        public const int CL_DEVICE_MAX_PIPE_ARGS = 0x1055;
        public const int CL_DEVICE_PIPE_MAX_ACTIVE_RESERVATIONS = 0x1056;
        public const int CL_DEVICE_PIPE_MAX_PACKET_SIZE = 0x1057;
        public const int CL_DEVICE_PREFERRED_PLATFORM_ATOMIC_ALIGNMENT = 0x1058;
        public const int CL_DEVICE_PREFERRED_GLOBAL_ATOMIC_ALIGNMENT = 0x1059;
        public const int CL_DEVICE_PREFERRED_LOCAL_ATOMIC_ALIGNMENT = 0x105A;


        public const int CL_DEVICE_IL_VERSION = 0x105B;
        public const int CL_DEVICE_MAX_NUM_SUB_GROUPS = 0x105C;
        public const int CL_DEVICE_SUB_GROUP_INDEPENDENT_FORWARD_PROGRESS = 0x105D;


        public const int CL_DEVICE_NUMERIC_VERSION = 0x105E;
        public const int CL_DEVICE_EXTENSIONS_WITH_VERSION = 0x1060;
        public const int CL_DEVICE_ILS_WITH_VERSION = 0x1061;
        public const int CL_DEVICE_BUILT_IN_KERNELS_WITH_VERSION = 0x1062;
        public const int CL_DEVICE_ATOMIC_MEMORY_CAPABILITIES = 0x1063;
        public const int CL_DEVICE_ATOMIC_FENCE_CAPABILITIES = 0x1064;
        public const int CL_DEVICE_NON_UNIFORM_WORK_GROUP_SUPPORT = 0x1065;
        public const int CL_DEVICE_OPENCL_C_ALL_VERSIONS = 0x1066;
        public const int CL_DEVICE_PREFERRED_WORK_GROUP_SIZE_MULTIPLE = 0x1067;
        public const int CL_DEVICE_WORK_GROUP_COLLECTIVE_FUNCTIONS_SUPPORT = 0x1068;
        public const int CL_DEVICE_GENERIC_ADDRESS_SPACE_SUPPORT = 0x1069;
        /* 0x106A to 0x106E - Reserved for upcoming KHR extension */
        public const int CL_DEVICE_OPENCL_C_FEATURES = 0x106F;
        public const int CL_DEVICE_DEVICE_ENQUEUE_SUPPORT = 0x1070;
        public const int CL_DEVICE_PIPE_SUPPORT = 0x1071;
    }
}