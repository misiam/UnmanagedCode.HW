using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace UnmanagedCode.HW.PowerManagementApi.Task2COM.Models
{
    [ComVisible(true)]
    public class ProcessorPowerModel
    {
        public int Item = 42;
        public ProcessorPowerInformationModel[] Items;

        public override string ToString()
        {
            if (Items == null || Items.Length ==0)
            {
                return "no Items";
            }

            string result = string.Join("\n",Items .Select(x => x.ToString()));
            return result;
        }
    }
}
