using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace UnmanagedCode.HW.PowerManagementApi.Task1.Structures
{
    [StructLayout(LayoutKind.Sequential)]
    public struct SystemBatteryState
    {
        /// <summary>
        /// If this member is TRUE, the system battery charger is currently operating on external power.
        /// 0 Offline
        /// 1 Online
        /// 255 unknown status
        /// </summary>
        public bool AcOnLine;
        /// <summary>
        /// If this member is TRUE, at least one battery is present in the system.
        /// 
        /// </summary>
        public bool BatteryPresent;
        /// <summary>
        /// If this member is TRUE, a battery is currently charging.
        /// </summary>
        public bool Charging;
        /// <summary>
        /// If this member is TRUE, a battery is currently discharging.
        /// </summary>
        public bool Discharging;


        public byte spare1;
        public byte spare2;
        public byte spare3;
        public byte spare4;

        //public bool[] Spare1;


        /// <summary>
        /// The theoretical capacity of the battery when new.
        /// </summary>
        public UInt32 MaxCapacity;
        /// <summary>
        /// The estimated remaining capacity of the battery.
        /// </summary>
        public UInt32 RemainingCapacity;
        /// <summary>
        /// The current rate of discharge of the battery, in mW. <br/>
        /// A nonzero, positive rate indicates charging; a negative rate indicates discharging. <br/>
        /// Some batteries report only discharging rates. <br/>
        /// This value should be treated as a LONG as it can contain negative values (with the high bit set).
        /// </summary>
        public UInt32 Rate;
        /// <summary>
        /// The estimated time remaining on the battery, in seconds.
        /// </summary>
        public UInt32 EstimatedTime;
        /// <summary>
        /// The manufacturer's suggestion of a capacity, in mWh, at which a low battery alert should occur. <br/>
        /// Definitions of low vary from manufacturer to manufacturer. <br/>
        /// In general, a warning state will occur before a low state, but you should not assume that it always will. <br/>
        /// To reduce risk of data loss, this value is usually used as the default setting for the critical battery alarm.
        /// </summary>
        public UInt32 DefaultAlert1;
        /// <summary>
        /// The manufacturer's suggestion of a capacity, in mWh, at which a warning battery alert should occur. <br/>
        /// Definitions of warning vary from manufacturer to manufacturer. <br/>
        /// In general, a warning state will occur before a low state, but you should not assume that it always will. <br/>
        /// To reduce risk of data loss, this value is usually used as the default setting for the low battery alarm.
        /// </summary>
        public UInt32 DefaultAlert2;
    }

}
