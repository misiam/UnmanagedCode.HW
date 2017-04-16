using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace UnmanagedCode.HW.PowerManagementApi.Task2COM.Models
{
    [ComVisible(true)]
    public class SystemBatteryStateModel
    {
        public bool AcOnLine;
        public bool BatteryPresent;
        public bool Charging;
        public bool Discharging;

        public long MaxCapacity;
        public long RemainingCapacity;
        public long Rate;
        public long EstimatedTimeInSeconds;
        public long DefaultAlert1;
        public long DefaultAlert2;

        public override string ToString()
        {
            string result = $"SystemBatteryStateModel:  \n"
                            + $"    AcOnLine: {AcOnLine}\n"
                            + $"    BatteryPresent: {BatteryPresent}\n"
                            + $"    Charging: {Charging}\n"
                            + $"    Discharging: {Discharging}\n"
                            + $"    MaxCapacity: {MaxCapacity}\n"
                            + $"    RemainingCapacity: {RemainingCapacity}\n"
                            + $"    Rate: {Rate}\n"
                            + $"    EstimatedTimeInSeconds: {EstimatedTimeInSeconds}\n"
                            + $"    DefaultAlert1: {DefaultAlert1}\n"
                            + $"    DefaultAlert2: {DefaultAlert2}\n"
                ;
            return result;  
        }
    }
}
