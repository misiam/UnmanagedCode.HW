using System;
using System.Runtime.InteropServices;
using UnmanagedCode.HW.PowerManagementApi.Task1.Structures;

namespace UnmanagedCode.HW.PowerManagementApi.Task1
{
    internal class PowerManagementInterop
    {
        internal const uint STATUS_SUCCESS = 0;

        [DllImport("PowrProf.dll", SetLastError = true)]
        public static extern uint CallNtPowerInformation(
            int informaitonLevel,
            IntPtr inputBuffer,
            int inputBufSize,
            IntPtr outputBuffer,
            int outputBufferSize);


        [DllImport("PowrProf.dll")]
        public static extern uint CallNtPowerInformation(
            int informationLevel,
            IntPtr lpInputBuffer,
            int inputBufSize,
            [Out] ProcessorPowerInformation[] lpOutputBuffer,
            int nOutputBufferSize
            );


        /// <summary>
        /// Suspends the system by shutting power down. Depending on the Hibernate parameter, the system either enters a suspend (sleep) state or hibernation (S4).
        /// </summary>
        /// <param name="Hibernate">If this parameter is TRUE, the system hibernates. If the parameter is FALSE, the system is suspended.</param>
        /// <param name="ForceCritical">This parameter has no effect. </param>
        /// <param name="DisableWakeEvent">If this parameter is TRUE, the system disables all wake events. If the parameter is FALSE, any system wake events remain enabled.</param>
        /// <returns>If the function succeeds, the return value is nonzero.
        /// If the function fails, the return value is zero. To get extended error information, call <strong>GetLastError</strong>.
        /// </returns>
        /// <remarks>
        /// The calling process must have the SE_SHUTDOWN_NAME privilege. To enable the SE_SHUTDOWN_NAME privilege, use the AdjustTokenPrivileges function. For more information, see Changing Privileges in a Token.
        /// An application may use SetSuspendState to transition the system from the working state to the standby (sleep), or optionally, hibernate (S4) state. This function is similar to the SetSystemPowerState function.
        /// </remarks>
        [DllImport("PowrProf.dll")]
        public static extern uint SetSuspendState(
            bool Hibernate,
            bool ForceCritical,
            bool DisableWakeEvent
            );
    }
}
