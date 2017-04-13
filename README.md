# UnmanagedCode.HW

# Interoperating with Unmanaged Code

# Задание 1.
Создайте библиотеку для Power State management на основе Power Management API. Библиотека в минимальном варианте должна поддерживать следующий функционал:
1.	Получение текущей информации (на основе функции CallNtPowerInformation) об управлении питанием такую как:
a.	LastSleepTime
b.	LastWakeTime
c.	SystemBatteryState 
d.	SystemPowerInformation
2.	Резервировать и удалять hibernation файл (также см. функцию CallNtPowerInformation)
3.	Переводить компьютер в состояние сна/гибернации (см. SetSuspendState)
Примечание. Набор функций может быть расширен по согласованию с ментором

# Задание 2.
На основе данной библиотеки создайте COM компонент, который будет доступен из скриптовых языков и VBA (с поддержкой IDispatch)

# Задание 3.
Напишите тестовые приложения и скрипты (на базе VBScript/JScript), тестирующие данные библиотеки.

