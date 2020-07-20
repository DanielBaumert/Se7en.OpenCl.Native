namespace Se7en.OpenCl.Native
{

    public partial class NativeCl
    {
        public const int CL_FP_DENORM = (1 << 0);
        public const int CL_FP_INF_NAN = (1 << 1);
        public const int CL_FP_ROUND_TO_NEAREST = (1 << 2);
        public const int CL_FP_ROUND_TO_ZERO = (1 << 3);
        public const int CL_FP_ROUND_TO_INF = (1 << 4);
        public const int CL_FP_FMA = (1 << 5);

        public const int CL_FP_SOFT_FLOAT = (1 << 6);


        public const int CL_FP_CORRECTLY_ROUNDED_DIVIDE_SQRT = (1 << 7);
    }
}