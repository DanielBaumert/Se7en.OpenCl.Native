using System;
using System.Runtime.InteropServices;

namespace Se7en.OpenCl.Native
{
    public unsafe static partial class NativeCl
    {
        [DllImport(InternalLibLoader.OpenCL, EntryPoint = nameof(clCreateKernel))]
        public static extern IntPtr CreateKernel(IntPtr program, [In][MarshalAs(UnmanagedType.LPStr)] string kernelName, [Out][MarshalAs(UnmanagedType.I4)] out int errcodeRet);

        [DllImport(InternalLibLoader.OpenCL, EntryPoint = nameof(clCreateKernelsInProgram))]
        public static extern int CreateKernelsInProgram(IntPtr program, uint numKernels, [Out][MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.SysUInt, SizeParamIndex = 1)] IntPtr[] kernels, out uint numKernelsRet);
      
        [DllImport(InternalLibLoader.OpenCL, EntryPoint = nameof(clRetainKernel))]
        public static extern int RetainKernel(IntPtr kernel);
        
        [DllImport(InternalLibLoader.OpenCL, EntryPoint = nameof(clReleaseKernel))]
        public static extern int ReleaseKernel(IntPtr kernel);

        /// <summary>
        /// To set the argument value for a specific argument of a kernel, call the function
        /// </summary>
        /// <param name="kernel">kernel is a valid kernel object.</param>
        /// <param name="argIndex">
        /// arg_index is the argument index.<br/>
        /// Arguments to the kernel are referred by indices that go from 0 for the leftmost argument to n - 1,<br/>
        /// where n is the total number of arguments declared by a kernel.</param>
        /// <param name="argSize">
        /// arg_size specifies the size of the argument value.<br/>
        /// If the argument is a memory object, the arg_size value must be equal to sizeof(cl_mem).<br/>
        /// For arguments declared with the local qualifier, the size specified will be the size in bytes of the buffer that must be allocated for the local argument.<br/>
        /// If the argument is of type sampler_t, the arg_size value must be equal to sizeof(cl_sampler).<br/>
        /// If the argument is of type queue_t, the arg_size value must be equal to sizeof(cl_command_queue).<br/>
        /// For all other arguments, the size will be the size of argument type.</param>
        /// <param name="argValue">
        /// arg_value is a pointer to data that should be used as the argument value for argument specified by arg_index.<br/>
        /// The argument data pointed to by arg_value is copied and the arg_value pointer can therefore be reused by the application after clSetKernelArg returns.<br/>
        /// The argument value specified is the value used by all API calls that enqueue kernel (clEnqueueNDRangeKernel and clEnqueueTask)<br/>
        /// until the argument value is changed by a call to clSetKernelArg for kernel.
        /// </param>
        /// <returns></returns>
        [DllImport(InternalLibLoader.OpenCL, EntryPoint = nameof(clSetKernelArg))]
        public static extern int SetKernelArg(IntPtr kernel, uint argIndex, IntPtr argSize, IntPtr argValue);
        /// <summary>
        /// Returns information about the kernel object.
        /// </summary>
        /// <param name="kernel">
        /// kernel specifies the kernel object being queried.
        /// </param>
        /// <param name="paramName">
        /// param_name specifies the information to query.<br/>
        /// The list of supported param_name types and the information returned in param_value by clGetKernelInfo is described in the Kernel Object Queries table.
        /// </param>
        /// <param name="paramValueSize">
        /// param_value is a pointer to memory where the appropriate result being queried is returned.<br/>
        /// If param_value is NULL, it is ignored.
        /// </param>
        /// <param name="paramValue">
        /// param_value_size is used to specify the size in bytes of memory pointed to by param_value.<br/>
        /// This size must be ≥ size of return type as described in the Kernel Object Queries table.
        /// </param>
        /// <param name="paramValueSizeRet">
        /// param_value_size_ret returns the actual size in bytes of data being queried by param_name.<br/>
        /// If param_value_size_ret is NULL, it is ignored.
        /// </param>
        /// <returns>
        /// CL_​SUCCESS if the function is executed successfully. Otherwise, it returns an error
        /// </returns>
        [DllImport(InternalLibLoader.OpenCL, EntryPoint = nameof(clGetKernelInfo))]
        public static extern int GetKernelInfo(IntPtr kernel, uint paramName, IntPtr paramValueSize, void* paramValue, out IntPtr paramValueSizeRet);
        /// <summary>
        /// Returns information about the kernel object.
        /// </summary>
        /// <param name="kernel">
        /// kernel specifies the kernel object being queried.
        /// </param>
        /// <param name="paramName">
        /// param_name specifies the information to query.<br/>
        /// The list of supported param_name types and the information returned in param_value by clGetKernelInfo is described in the Kernel Object Queries table.
        /// </param>
        /// <param name="paramValueSize">
        /// param_value is a pointer to memory where the appropriate result being queried is returned.<br/>
        /// If param_value is NULL, it is ignored.
        /// </param>
        /// <param name="paramValue">
        /// param_value_size is used to specify the size in bytes of memory pointed to by param_value.<br/>
        /// This size must be ≥ size of return type as described in the Kernel Object Queries table.
        /// </param>
        /// <param name="paramValueSizeRet">
        /// param_value_size_ret returns the actual size in bytes of data being queried by param_name.<br/>
        /// If param_value_size_ret is NULL, it is ignored.
        /// </param>
        /// <returns>
        /// CL_​SUCCESS if the function is executed successfully. Otherwise, it returns an error
        /// </returns>
        [DllImport(InternalLibLoader.OpenCL, EntryPoint = nameof(clGetKernelInfo))]
        public static extern int GetKernelInfo(IntPtr kernel, int paramName, IntPtr paramValueSize, IntPtr paramValue, out IntPtr paramValueSizeRet);
        /// <summary>
        /// To enqueue a command to execute a kernel on a device
        /// </summary>
        /// <param name="commandQueue">
        /// command_queue is a valid host command-queue.<br/>
        /// The kernel will be queued for execution on the device associated with command_queue.
        /// </param>
        /// <param name="kernel">
        /// kernel is a valid kernel object.<br/>
        /// The OpenCL context associated with kernel and command-queue must be the same
        /// </param>
        /// <param name="workDim">
        /// work_dim is the number of dimensions used to specify the global work-items and work-items in the work-group.<br/>
        /// work_dim must be greater than zero and less than or equal to CL_​DEVICE_​MAX_​WORK_​ITEM_​DIMENSIONS.<br/>
        /// If global_work_size is NULL, or the value in any passed dimension is 0 then the kernel command will trivially succeed after its event dependencies<br/>
        /// are satisfied and subsequently update its completion event.<br/>
        /// The behavior in this situation is similar to that of an enqueued marker, except that unlike a marker,<br/>
        /// an enqueued kernel with no events passed to event_wait_list may run at any time.
        /// </param>
        /// <param name="globalWorkOffset">
        /// global_work_offset can be used to specify an array of work_dim unsigned<br/>
        /// values that describe the offset used to calculate the global ID of a work-item.<br/>
        /// If global_work_offset is NULL, the global IDs start at offset (0, 0, 0).</param>
        /// <param name="globalWorkSize">
        /// global_work_size points to an array of work_dim unsigned values that describe the number of global work-items in work_dim dimensions<br/>
        /// that will execute the kernel function.<br/>
        /// The total number of global work-items is computed as global_work_size[0] × …​ × global_work_size[work_dim - 1].</param>
        /// <param name="localWorkSize">
        /// local_work_size points to an array of work_dim unsigned values that describe the number of work-items<br/>
        /// that make up a work-group (also referred to as the size of the work-group) that will execute the kernel specified by kernel.<br/>
        /// The total number of work-items in a work-group is computed as local_work_size[0] × …​ × local_work_size[work_dim - 1].<br/>
        /// The total number of work-items in the work-group must be less than or equal to the CL_​KERNEL_​WORK_​GROUP_​SIZE<br/>
        /// value specified in the Kernel Object Device Queries table,<br/>
        /// and the number of work-items specified in local_work_size[0], …​, local_work_size[work_dim - 1]<br/>
        /// must be less than or equal to the corresponding values specified by CL_​DEVICE_​MAX_​WORK_​ITEM_​SIZES[0], …​, CL_​DEVICE_​MAX_​WORK_​ITEM_​SIZES[work_dim - 1].<br/>
        /// The explicitly specified local_work_size will be used to determine how to break the global<br/> 
        /// work-items specified by global_work_size into appropriate work-group instances.
        /// </param>
        /// <param name="numEventsInWaitList">
        /// event_wait_list and num_events_in_wait_list specify events that need to complete before this particular command can be executed.<br/>
        /// If event_wait_list is NULL, then this particular command does not wait on any event to complete.<br/>
        /// If event_wait_list is NULL, num_events_in_wait_list must be 0. If event_wait_list is not NULL,<br/>
        /// the list of events pointed to by event_wait_list must be valid and num_events_in_wait_list must be greater than 0.<br/>
        /// The events specified in event_wait_list act as synchronization points.<br/>
        /// The context associated with events in event_wait_list and command_queue must be the same.<br/>
        /// The memory associated with event_wait_list can be reused or freed after the function returns.
        /// </param>
        /// <param name="eventWaitList">
        /// event_wait_list and num_events_in_wait_list specify events that need to complete before this particular command can be executed.<br/>
        /// If event_wait_list is NULL, then this particular command does not wait on any event to complete.<br/>
        /// If event_wait_list is NULL, num_events_in_wait_list must be 0. If event_wait_list is not NULL,<br/>
        /// the list of events pointed to by event_wait_list must be valid and num_events_in_wait_list must be greater than 0.<br/>
        /// The events specified in event_wait_list act as synchronization points.<br/>
        /// The context associated with events in event_wait_list and command_queue must be the same.<br/>
        /// The memory associated with event_wait_list can be reused or freed after the function returns.
        /// </param>
        /// <param name="e">
        /// event returns an event object that identifies this particular kernel-instance.<br/>
        /// Event objects are unique and can be used to identify a particular kernel-instance later on.<br/>
        /// If event is NULL, no event will be created for this kernel-instance and therefore it will not be possible for<br/>
        /// the application to query or queue a wait for this particular kernel-instance.<br/>
        /// If the event_wait_list and the event arguments are not NULL, the event argument should not refer to an element of the event_wait_list array.
        /// </param>
        /// <returns></returns>
        [DllImport(InternalLibLoader.OpenCL, EntryPoint = nameof(clEnqueueNDRangeKernel))]
        public static extern int EnqueueNDRangeKernel(IntPtr commandQueue, IntPtr kernel, uint workDim, [In][MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 2)] IntPtr[] globalWorkOffset, [In][MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 2)] IntPtr[] globalWorkSize, [In][MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 2)] IntPtr[] localWorkSize, uint numEventsInWaitList, [In][MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.SysUInt, SizeParamIndex = 6)] IntPtr[] eventWaitList, [Out][MarshalAs(UnmanagedType.Struct)] out IntPtr e);
    }
}
