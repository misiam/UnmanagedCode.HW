using System.ComponentModel;

namespace UnmanagedCode.HW.PowerManagementApi.Task1
{
    public class SuspendManager
    {
        /// <summary>
        /// Suspends the system by shutting power down. Depending on the Hibernate parameter, the system either enters a suspend (sleep) state or hibernation (S4).
        /// </summary>
        /// <param name="hibernate">If this parameter is TRUE, the system hibernates. If the parameter is FALSE, the system is suspended.</param>
        /// <param name="forceCritical">This parameter has no effect. </param>
        /// <param name="disableWakeEvent">If this parameter is TRUE, the system disables all wake events. If the parameter is FALSE, any system wake events remain enabled.</param>
        public void SetSuspendState(bool hibernate, bool forceCritical, bool disableWakeEvent)
        {
            uint result = PowerManagementInterop.SetSuspendState(hibernate, forceCritical, disableWakeEvent);

            if (result == 0)
            {
                throw new Win32Exception();
            }


        }
    }
}
