set powerManager = CreateObject("UnmanagedCode.HW.PowerManagementApi.Task2COM.PowerManagerCustom")

powerManager.DeleteFile()

WScript.Echo("done deleted")