using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnmanagedCode.HW.PowerManagementApi.Task1
{
    internal enum PowerInformationLevel
    {
        AdministratorPowerPolicy = 9,  /* This information level is not supported. */

        LastSleepTime = 15,         /*    The lpInBuffer parameter must be NULL; otherwise, the function returns ERROR_INVALID_PARAMETER.
                                          The lpOutputBuffer buffer receives a ULONGLONG that specifies the interrupt-time count, 
                                          in 100-nanosecond units, at the last system sleep time.
                                    */
        LastWakeTime = 14,            /* The lpInBuffer parameter must be NULL; otherwise, the function returns ERROR_INVALID_PARAMETER. 
                                        The lpOutputBuffer buffer receives a ULONGLONG that specifies the interrupt-time count, 
                                        in 100-nanosecond units, at the last system wake time.  
                                      */
        ProcessorInformation = 11,
        ProcessorPowerPolicyAc = 18,
        ProcessorPowerPolicyCurrent = 22,
        ProcessorPowerPolicyDc = 19,
        SystemBatteryState = 5,      /* The lpInBuffer parameter must be NULL; otherwise, the function returns ERROR_INVALID_PARAMETER.
                                            The lpOutputBuffer buffer receives a SYSTEM_BATTERY_STATE structure containing information about the current system battery.
                                     */
        SystemExecutionState  = 16,
        SystemPowerCapabilities = 4,
        SystemPowerInformation = 12, /* The lpInBuffer parameter must be NULL; otherwise, the function returns ERROR_INVALID_PARAMETER.
                                        The lpOutputBuffer buffer receives a SYSTEM_POWER_INFORMATION structure.
                                        Applications can use this level to retrieve information about the idleness of the system.
                                     */
        SystemPowerPolicyAc = 0,
        SystemPowerPolicyCurrent = 8,
        SystemPowerPolicyDc = 1,
        SystemReserveHiberFile = 10,
        VerifyProcessorPowerPolicyAc = 20,
        VerifyProcessorPowerPolicyDc = 21,
        VerifySystemPolicyAc = 2,
        VerifySystemPolicyDc = 3,

    }
}
