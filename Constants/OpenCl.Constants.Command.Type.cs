namespace Se7en.OpenCl.Native
{

    public partial class NativeCl
    {
        public const int CL_COMMAND_NDRANGE_KERNEL = 0x11F0;
        public const int CL_COMMAND_TASK = 0x11F1;
        public const int CL_COMMAND_NATIVE_KERNEL = 0x11F2;
        public const int CL_COMMAND_READ_BUFFER = 0x11F3;
        public const int CL_COMMAND_WRITE_BUFFER = 0x11F4;
        public const int CL_COMMAND_COPY_BUFFER = 0x11F5;
        public const int CL_COMMAND_READ_IMAGE = 0x11F6;
        public const int CL_COMMAND_WRITE_IMAGE = 0x11F7;
        public const int CL_COMMAND_COPY_IMAGE = 0x11F8;
        public const int CL_COMMAND_COPY_IMAGE_TO_BUFFER = 0x11F9;
        public const int CL_COMMAND_COPY_BUFFER_TO_IMAGE = 0x11FA;
        public const int CL_COMMAND_MAP_BUFFER = 0x11FB;
        public const int CL_COMMAND_MAP_IMAGE = 0x11FC;
        public const int CL_COMMAND_UNMAP_MEM_OBJECT = 0x11FD;
        public const int CL_COMMAND_MARKER = 0x11FE;
        public const int CL_COMMAND_ACQUIRE_GL_OBJECTS = 0x11FF;
        public const int CL_COMMAND_RELEASE_GL_OBJECTS = 0x1200;

        public const int CL_COMMAND_READ_BUFFER_RECT = 0x1201;
        public const int CL_COMMAND_WRITE_BUFFER_RECT = 0x1202;
        public const int CL_COMMAND_COPY_BUFFER_RECT = 0x1203;
        public const int CL_COMMAND_USER = 0x1204;


        public const int CL_COMMAND_BARRIER = 0x1205;
        public const int CL_COMMAND_MIGRATE_MEM_OBJECTS = 0x1206;
        public const int CL_COMMAND_FILL_BUFFER = 0x1207;
        public const int CL_COMMAND_FILL_IMAGE = 0x1208;


        public const int CL_COMMAND_SVM_FREE = 0x1209;
        public const int CL_COMMAND_SVM_MEMCPY = 0x120A;
        public const int CL_COMMAND_SVM_MEMFILL = 0x120B;
        public const int CL_COMMAND_SVM_MAP = 0x120C;
        public const int CL_COMMAND_SVM_UNMAP = 0x120D;


        public const int CL_COMMAND_SVM_MIGRATE_MEM = 0x120E;


        /* command execution status */
        public const int CL_COMPLETE = 0x0;
        public const int CL_RUNNING = 0x1;
        public const int CL_SUBMITTED = 0x2;
        public const int CL_QUEUED = 0x3;
    }
}