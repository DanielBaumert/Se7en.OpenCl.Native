using Se7en.OpenCl;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace Se7en.OpenCl.Native
{
    public unsafe static partial class NativeCl
    {

        //[DllImport(InternalLibLoader.OpenCL, EntryPoint = nameof(clCreateImage))]
        //public static extern IntPtr CreateImage(IntPtr context, MemFlags memoryFlag, )

        /// <summary>
        /// Get the list of image formats supported by an OpenCL implementation for a specified context, image type, and allocation information.
        /// </summary>
        /// <param name="context">
        /// Is a valid OpenCL context on which the image object(s) will be created.
        /// </param>
        /// <param name="flags">
        /// Is a bit-field that is used to specify usage information about the image formats being queried and is described in the Memory Flags table.<br/>
        /// flags may be CL_​MEM_​READ_​WRITE to query image formats that may be read from and written to by different kernel instances when correctly ordered by event dependencies,<br/>
        /// or CL_​MEM_​READ_​ONLY to query image formats that may be read from by a kernel, or CL_​MEM_​WRITE_​ONLY to query image formats that may be written to by a kernel,<br/>
        /// or CL_​MEM_​KERNEL_​READ_​AND_​WRITE to query image formats that may be both read from and written to by the same kernel instance.<br/>
        /// Please see Image Format Mapping for clarification.
        /// </param>
        /// <param name="imageType">
        /// Describes the image type and must be either CL_​MEM_​OBJECT_​IMAGE1D, CL_​MEM_​OBJECT_​IMAGE1D_​BUFFER, CL_​MEM_​OBJECT_​IMAGE2D, CL_​MEM_​OBJECT_​IMAGE3D, CL_​MEM_​OBJECT_​IMAGE1D_​ARRAY, or CL_​MEM_​OBJECT_​IMAGE2D_​ARRAY.
        /// </param>
        /// <param name="numEntries">
        /// Specifies the number of entries that can be returned in the memory location given by image_formats.
        /// </param>
        /// <param name="imageFormats">
        /// Is a pointer to a memory location where the list of supported image formats are returned.<br/>
        /// Each entry describes a cl_image_format structure supported by the OpenCL implementation.<br/>
        /// If image_formats is NULL, it is ignored.
        /// </param>
        /// <param name="numImageFormats">
        /// Is the actual number of supported image formats for a specific context and values specified by flags.<br/>
        /// If num_image_formats is NULL, it is ignored.
        /// </param>
        /// <returns>
        /// CL_​SUCCESS if the function is executed successfully. Otherwise, it returns an error code
        /// </returns>
        [DllImport(InternalLibLoader.OpenCL, EntryPoint = nameof(clGetSupportedImageFormats))]
        public static extern int GetSupportedImageFormats(IntPtr context, uint flags, uint imageType, uint numEntries, void* imageFormats, out uint numImageFormats);



    }
}
