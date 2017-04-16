set powerManager = CreateObject("UnmanagedCode.HW.PowerManagementApi.Task2COM.PowerManagerCustom")

Dim lastSleepTime, lastWakeTime, systemBatteryState, processorPowerModel

lastSleepTime = "lastSleepTIme: " & FormatDateTime(powerManager.GetLastSleepTime()) & chr(13)
lastWakeTime = "lastWakeTime: "& FormatDateTime(powerManager.GetLastWakeTime()) & chr(13)
systemBatteryState = powerManager.GetSystemBatteryState() & chr(13)
processorPowerModel = powerManager.GetProcessorPowerModel()


WScript.Echo(lastSleepTime & lastWakeTime & systemBatteryState & processorPowerModel) 


