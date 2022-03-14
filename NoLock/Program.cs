// Created using .NET 6 Console Application template that uses "top-level statements".
// See https://aka.ms/new-console-template for more information.

using System.Runtime.InteropServices;

Console.WriteLine("NoLock started: " + DateTime.Now.ToShortTimeString());

while (true)
{
    await Task.Delay(TimeSpan.FromMinutes(5));
    Console.WriteLine("NoLock SetThreadExecutionState: " + DateTime.Now.ToShortTimeString());
    PreventSleep();
}

static void PreventSleep()
{
    SetThreadExecutionState(EXECUTION_STATE.ES_CONTINUOUS | EXECUTION_STATE.ES_DISPLAY_REQUIRED);
}

[DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
static extern EXECUTION_STATE SetThreadExecutionState(EXECUTION_STATE esFlags);