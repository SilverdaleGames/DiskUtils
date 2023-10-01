using UnityEngine;

namespace Silverdale.DiskUtils
{
    public static class DiskUtils
    {
        private static IDiskUtils instance;

        static DiskUtils()
        {
#if UNITY_ANDROID && !UNITY_EDITOR
            instance = new AndroidDiskUtils();
#elif UNITY_IOS && !UNITY_EDITOR
            instance = new IOSDiskUtils();
#else
            instance = new EditorDiskUtils();
#endif

        }

        public static int CheckAvailableSpace() => instance.CheckAvailableSpace();
        public static int CheckTotalSpace() => instance.CheckTotalSpace();
        public static int CheckBusySpace() => instance.CheckBusySpace();
    }	
}