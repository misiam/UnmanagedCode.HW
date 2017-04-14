using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnmanagedCode.HW.PowerManagementApi.Task1.Structures;

namespace UnmanagedCode.HW.PowerManagementApi.Task1
{
    public class NtPowerInformation
    {
        public DateTime LastSleepTime { get; set; }
        public DateTime LastWakeTime { get; set; }
        public SystemBatteryState SystemBatteryState { get; set; }
        public ProcessorPowerInformation[] SystemPowerInfo { get; set; }

    }
}
