namespace BugseePlugin
{
    public partial class BugseeLauncher
    {
        static BugseeLauncher()
        {
            AndroidOptionsHandler = GetAndroidOptions;
            IosOptionsHandler = GetIosOptions;
        }

        private static AndroidLaunchOptions GetAndroidOptions()
        {
            return new AndroidLaunchOptions()
            {
                // Set custom Android launch options here.
                VideoEnabled = true,
                VideoMode = BugseePlugin.BugseeAndroidVideoMode.V3
            };
        }

        private static IOSLaunchOptions GetIosOptions()
        {
            return new IOSLaunchOptions()
            {
                // Set custom iOS launch options here. 
                MonitorNetwork = false
            };
        }
    }
}
