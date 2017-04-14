using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using UnmanagedCode.HW.PowerManagementApi.Task1.Structures;

namespace UnmanagedCode.HW.PowerManagementApi.Task1
{
    internal class PowerManagementInterop
    {
        [DllImport("PowrProf.dll", SetLastError = true)]
        public static extern uint CallNtPowerInformation(
            int informaitonLevel,
            IntPtr inputBuffer,
            int inputBufSize,
            IntPtr outputBuffer,
            int outputBufferSize);


        [DllImport("powrprof.dll")]
        public static extern uint CallNtPowerInformation(
        int informationLevel,
        IntPtr lpInputBuffer,
        int inputBufSize,
        [Out] ProcessorPowerInformation[] lpOutputBuffer,
        int nOutputBufferSize
    );


    }
}
