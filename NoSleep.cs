using static ModLoader;
using static ServerManager;

namespace grasmanek94.NoSleep
{
    [ModManager]
    public static class NoSleep
    {
        [ModCallback(EModCallbackType.AfterWorldLoad, "AfterWorldLoad")]
        static void AfterWorldLoad()
        {
            ServerSettings.Time.SleepTimeStart = 23.999f;
            ServerSettings.Time.SleepTimeEnd = 0.000f;
            ServerSettings.Time.GuardShiftDayStart = ServerManager.ServerSettings.Time.SleepTimeEnd;
            ServerSettings.Time.GuardShiftDayEnd = ServerManager.ServerSettings.Time.SleepTimeStart;
            ServerSettings.Time.GuardShiftNightStart = ServerManager.ServerSettings.Time.SleepTimeEnd;
            ServerSettings.Time.GuardShiftNightEnd = ServerManager.ServerSettings.Time.SleepTimeStart;
        }
    }
}
