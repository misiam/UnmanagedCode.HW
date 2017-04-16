set powerManager = CreateObject("UnmanagedCode.HW.PowerManagementApi.Task2COM.PowerManagerCustom")

Dim hibernate, forceCritical, disableWakeEvent
hibernate = False
forceCritical = False
disableWakeEvent = False

Call powerManager.SetSuspendState(hibernate, forceCritical, disableWakeEvent)

