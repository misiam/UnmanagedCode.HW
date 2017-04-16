using System;
using System.ComponentModel;
using System.Runtime.InteropServices;

namespace UnmanagedCode.HW.PowerManagementApi.Task1
{
    public class HibernateFileManager
    {
        public void ReserveFile()
        {
            HibernateFileAction(HibernateFileActions.Reserve);

        }

        public void DeleteFile()
        {
            HibernateFileAction(HibernateFileActions.Delete);

        }

        private void HibernateFileAction(HibernateFileActions fileActions)
        {
            int intSize = Marshal.SizeOf<bool>();
            IntPtr intPtr = Marshal.AllocCoTaskMem(intSize);
            Marshal.WriteByte(intPtr, (byte)fileActions);

            var retval = PowerManagementInterop.CallNtPowerInformation(
                (int) PowerInformationLevel.SystemReserveHiberFile,
                intPtr,
                intSize,
                IntPtr.Zero,
                0);
            Marshal.FreeHGlobal(intPtr);
            if (retval == PowerManagementInterop.STATUS_SUCCESS)
            {
                
            }
            else
            {
                throw new Win32Exception();
                //throw new ApplicationException("CallNtPowerInformation returned: " + retval + " ");
            }


        }

        private enum HibernateFileActions
        {
            Delete = 0,
            Reserve = 1,

        }

    }
}
