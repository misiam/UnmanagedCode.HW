using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using UnmanagedCode.HW.PowerManagementApi.Task2COM.Models;

namespace UnmanagedCode.HW.PowerManagementApi.Task2COM.Interfaces
{
    [ComVisible(true)]
    [ComImport, Guid("9b7a420d-dbba-4289-902b-2acb77555feb")]
    [InterfaceType(ComInterfaceType.InterfaceIsDual)]
    public interface IPowerManagerCustom
    {
        #region PowerManager
        DateTime GetLastSleepTime();
        DateTime GetLastWakeTime();
        SystemBatteryStateModel GetSystemBatteryState();
        ProcessorPowerModel GetProcessorPowerModel();
        #endregion

        #region SuspendManager
        void SetSuspendState(bool hibernate, bool forceCritical, bool disableWakeEvent);
        #endregion

        #region HibernateFileManager
        void ReserveFile();
        void DeleteFile();
        #endregion
    }
}
