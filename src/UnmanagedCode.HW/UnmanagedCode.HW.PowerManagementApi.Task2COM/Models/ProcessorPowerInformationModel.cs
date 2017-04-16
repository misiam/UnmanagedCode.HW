using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace UnmanagedCode.HW.PowerManagementApi.Task2COM.Models
{
    [ComVisible(true)]
    public class ProcessorPowerInformationModel
    {
        public uint Number;
        public uint MaxMhz;
        public uint CurrentMhz;
        public uint MhzLimit;
        public uint MaxIdleState;
        public uint CurrentIdleState;

        public override string ToString()
        {
            string result = $"ProcessorPowerInformationModel:  \n"
                            + $"    Number: {Number}\n"
                            + $"    MaxMhz: {MaxMhz}\n"
                            + $"    CurrentMhz: {CurrentMhz}\n"
                            + $"    MhzLimit: {MhzLimit}\n"
                            + $"    MaxIdleState: {MaxIdleState}\n"
                            + $"    CurrentIdleState: {CurrentIdleState}\n"
                ;
            return result;
        }
    }
}
