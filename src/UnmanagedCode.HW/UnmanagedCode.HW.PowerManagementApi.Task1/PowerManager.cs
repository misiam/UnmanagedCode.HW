using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Management;
using System.Runtime.InteropServices;
using UnmanagedCode.HW.PowerManagementApi.Task1.Structures;

namespace UnmanagedCode.HW.PowerManagementApi.Task1
{
    public class PowerManager
    {
        private const uint STATUS_SUCCESS = 0;

        private DateTime GetLastBootUpTime()
        {
            var osClass = new ManagementClass("Win32_OperatingSystem");
            var properies = new List<PropertyData>();

            foreach (var queryObj in osClass.GetInstances())
            {
                properies.AddRange(queryObj.Properties.Cast<PropertyData>());
            }

            var lasBootUpProperty = properies.First(x => x.Name == "LastBootUpTime");
            DateTime dateTime = ManagementDateTimeConverter.ToDateTime(lasBootUpProperty.Value.ToString());
            return dateTime;
        }

        private T GetStructure<T>(PowerInformationLevel informationLevel)
        {
            var informaitonLevel = (int)informationLevel;
            IntPtr lpInBuffer = IntPtr.Zero;
            int inputBufSize = 0;
            int outputPtrSize = Marshal.SizeOf<T>();
            IntPtr outputPtr = Marshal.AllocCoTaskMem(outputPtrSize);

            var retval = PowerManagementInterop.CallNtPowerInformation(
                informaitonLevel,
                lpInBuffer,
                inputBufSize,
                outputPtr,
                outputPtrSize);

            if (retval == STATUS_SUCCESS)
            {
                var obj = Marshal.PtrToStructure<T>(outputPtr);
                return obj;
            }

            throw new ApplicationException("CallNtPowerInformation returned: " + retval);
        }

        public DateTime GetLastSleepTime()
        {
            long lastSleepTimeTicks = GetStructure<long>(PowerInformationLevel.LastSleepTime);

            //Console.WriteLine("lastSleepTime in ticks" + lastSleepTimeTicks);
            DateTime bootUpTime = GetLastBootUpTime();
            DateTime lastSleepTime = bootUpTime.AddTicks(lastSleepTimeTicks);
            return lastSleepTime;
        }

        public DateTime GetLastWakeTime()
        {
            long lastWakeTimeTicks = GetStructure<long>(PowerInformationLevel.LastWakeTime);

            //Console.WriteLine("lastWakeTime in ticks" + lastWakeTimeTicks);

            DateTime bootUpTime = GetLastBootUpTime();
            DateTime lastWakeTime = bootUpTime.AddTicks(lastWakeTimeTicks);
            return lastWakeTime;
        }


        public SystemBatteryState GetSystemBatteryState()
        {
            var batteryState = GetStructure<SystemBatteryState>(PowerInformationLevel.SystemBatteryState);

            //Console.WriteLine(batteryState.AcOnLine);
            //Console.WriteLine(batteryState.BatteryPresent);
            //Console.WriteLine(batteryState.Charging);

            return batteryState;

        }

        public ProcessorPowerInformation[] GetSystemPowerInformation()
        {
            var procCount = Environment.ProcessorCount;
            var procInfo = new ProcessorPowerInformation[procCount];
            var retval = PowerManagementInterop.CallNtPowerInformation(
                (int) PowerInformationLevel.ProcessorInformation,
                IntPtr.Zero,
                0,
                procInfo,
                procInfo.Length*Marshal.SizeOf(typeof (ProcessorPowerInformation))
                );

            if (retval == STATUS_SUCCESS)
            {
                //foreach (var item in procInfo)
                //{
                //    Console.WriteLine(item.CurrentMhz);
                //}
            }
            else
            {
                throw new ApplicationException("CallNtPowerInformation returned: " + retval);
            }

            return procInfo;
        }

    }
}
