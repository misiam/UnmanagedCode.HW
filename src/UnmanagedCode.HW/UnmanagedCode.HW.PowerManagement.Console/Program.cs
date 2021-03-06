﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnmanagedCode.HW.PowerManagementApi.Task1;

namespace UnmanagedCode.HW.PowerManagement.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            var powerManager = new PowerManager();


            DateTime lastSleepTime = powerManager.GetLastSleepTime();
            DateTime lastWakeTime = powerManager.GetLastWakeTime();
            var systemBatteryState = powerManager.GetSystemBatteryState();
            var powerInformation = powerManager.GetSystemPowerInformation();


            var hibernateFileManager = new HibernateFileManager();
            hibernateFileManager.ReserveFile();

            var suspendManager = new SuspendManager();
            //suspendManager.SetSuspendState(false, false, false);


            System.Console.WriteLine("Press any key to continue");
            System.Console.ReadKey();


        }

    }
}
