set powerManager = CreateObject("UnmanagedCode.HW.PowerManagementApi.Task2COM.PowerManagerCustom")

powerManager.ReserveFile()

WScript.Echo("done reserve")