using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace UnmanagedCode.HW.PowerManagementApi.Task1.Structures
{
    [StructLayout(LayoutKind.Sequential)]
    public struct ProcessorPowerInformation
    {
        /// <summary>
        /// The system processor number.
        /// </summary>
        public uint Number;
        /// <summary>
        /// The maximum specified clock frequency of the system processor, in megahertz.
        /// </summary>
        public uint MaxMhz;
        /// <summary>
        /// The processor clock frequency, in megahertz. This number is the maximum specified processor clock frequency multiplied by the current processor throttle.
        /// </summary>
        public uint CurrentMhz;
        /// <summary>
        /// The limit on the processor clock frequency, in megahertz. This number is the maximum specified processor clock frequency multiplied by the current processor thermal throttle limit.
        /// </summary>
        public uint MhzLimit;
        /// <summary>
        /// The maximum idle state of this processor.
        /// </summary>
        public uint MaxIdleState;
        /// <summary>
        /// The current idle state of this processor.
        /// </summary>
        public uint CurrentIdleState;
    }
}
