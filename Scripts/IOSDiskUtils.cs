namespace Silverdale.DiskUtils
{
#if UNITY_IOS && !UNITY_EDITOR
    using System.Runtime.InteropServices;

    public class IOSDiskUtils : IDiskUtils
    {
        [DllImport("__Internal")]
        private static extern ulong getAvailableDiskSpace();

        [DllImport("__Internal")]
        private static extern ulong getTotalDiskSpace();

        [DllImport("__Internal")]
        private static extern ulong getBusyDiskSpace();

        public int CheckAvailableSpace() => (int)getAvailableDiskSpace();
        public int CheckTotalSpace() => (int)getTotalDiskSpace();
        public int CheckBusySpace() => (int)getBusyDiskSpace();
    }
#endif
}
