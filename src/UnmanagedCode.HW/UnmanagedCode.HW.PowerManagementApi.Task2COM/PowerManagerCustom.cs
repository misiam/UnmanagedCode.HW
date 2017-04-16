using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using UnmanagedCode.HW.PowerManagementApi.Task1;
using UnmanagedCode.HW.PowerManagementApi.Task2COM.Interfaces;
using UnmanagedCode.HW.PowerManagementApi.Task2COM.Models;

namespace UnmanagedCode.HW.PowerManagementApi.Task2COM
{
    [ComVisible(true)]
    [Guid("f56c6801-5d6e-43e1-af9f-47dbcbb971ba")]
    [ClassInterface(ClassInterfaceType.None)]
    public class PowerManagerCustom : IPowerManagerCustom
    {
        private PowerManager _powerManager ;
        private SuspendManager _suspendManager;
        private HibernateFileManager _hibernateFileManager;

        public PowerManagerCustom()
        {
            _powerManager = new PowerManager();
            _suspendManager = new SuspendManager();
            _hibernateFileManager = new HibernateFileManager();
        }

        public void ReserveFile()
        {
            _hibernateFileManager.ReserveFile();
        }

        public void DeleteFile()
        {
            _hibernateFileManager.DeleteFile();
        }

        public void SetSuspendState(bool hibernate, bool forceCritical, bool disableWakeEvent)
        {
            _suspendManager.SetSuspendState(hibernate, forceCritical, disableWakeEvent);
        }

        public DateTime GetLastSleepTime()
        {
            return this._powerManager.GetLastSleepTime();
        }

        public DateTime GetLastWakeTime()
        {
            return this._powerManager.GetLastWakeTime();
        }

        public SystemBatteryStateModel GetSystemBatteryState()
        {
            var batteryState = this._powerManager.GetSystemBatteryState();
            var model = new SystemBatteryStateModel()
            {
                AcOnLine = batteryState.AcOnLine,
                BatteryPresent = batteryState.BatteryPresent,
                Charging = batteryState.Charging,
                Discharging = batteryState.Discharging,
                MaxCapacity = batteryState.MaxCapacity,
                RemainingCapacity = batteryState.RemainingCapacity,
                Rate = batteryState.Rate,
                EstimatedTimeInSeconds = batteryState.EstimatedTime,
                DefaultAlert1 = batteryState.DefaultAlert1,
                DefaultAlert2 = batteryState.DefaultAlert2,
            };

            return model;
        }

        private ProcessorPowerInformationModel[] GetSystemPowerInformation()
        {
            var items = this._powerManager.GetSystemPowerInformation();

            var models = items.Select(x => new ProcessorPowerInformationModel()
            {
                Number = x.Number,
                MaxMhz = x.MaxMhz,
                CurrentMhz = x.CurrentMhz,
                MhzLimit = x.MhzLimit,
                MaxIdleState = x.MaxIdleState,
                CurrentIdleState = x.CurrentIdleState,
            }).ToArray();

            return models;
        }

        public ProcessorPowerModel GetProcessorPowerModel()
        {
            return new ProcessorPowerModel()
            {
                Items = GetSystemPowerInformation(),
            };
        }
    }
}
