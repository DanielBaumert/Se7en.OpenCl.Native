namespace Se7en.OpenCl.Native
{

    public partial class NativeCl
    {
        public const int CL_MEM_READ_WRITE = (1 << 0);
        public const int CL_MEM_WRITE_ONLY = (1 << 1);
        public const int CL_MEM_READ_ONLY = (1 << 2);
        public const int CL_MEM_USE_HOST_PTR = (1 << 3);
        public const int CL_MEM_ALLOC_HOST_PTR = (1 << 4);
        public const int CL_MEM_COPY_HOST_PTR = (1 << 5);
        /* reserved                                         (1 << 6)    */

        public const int CL_MEM_HOST_WRITE_ONLY = (1 << 7);
        public const int CL_MEM_HOST_READ_ONLY = (1 << 8);
        public const int CL_MEM_HOST_NO_ACCESS = (1 << 9);


        public const int CL_MEM_SVM_FINE_GRAIN_BUFFER = (1 << 10);  /* used by cl_svm_mem_flags only */
        public const int CL_MEM_SVM_ATOMICS = (1 << 11);   /* used by cl_svm_mem_flags only */
        public const int CL_MEM_KERNEL_READ_AND_WRITE = (1 << 12);
    }
}