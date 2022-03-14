NoLock is a really basic console app that prevents a system from going into ScreenSave or ScreenLock mode.

It achieves this by calling `SetThreadExecutionState(EXECUTION_STATE.ES_CONTINUOUS | EXECUTION_STATE.ES_DISPLAY_REQUIRED)` every 5 minutes.

NoLock is useful if you need a PC to stay fully active at all times with the screen readable at a glance, e.g. to monitor a dashboard, a mailbox or a chat app, while doing other things like working on a different system.

Of course you could disable the screensaver/autoscreenlock, or set really long timeouts for them, but Group Policy may prevent you from making such changes, which is exactly the situation I found myself in.

NoLock does not prevent you from manually locking the screen with Windows-L.

If you know better ways of doing this, or if it's not needed to do this *every 5 minutes*: feel free to let me know, e.g. by filing an issue, or by creating a PR.
