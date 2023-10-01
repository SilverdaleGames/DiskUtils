namespace Silverdale.DiskUtils
{
#if UNITY_ANDROID && !UNITY_EDITOR
    using UnityEngine;

    public class AndroidDiskUtils : IDiskUtils
    {
        public int CheckAvailableSpace()
        {
            using (AndroidJavaClass dataUtils = new AndroidJavaClass("com.dikra.diskutils.DiskUtils"))
            {
                return dataUtils.CallStatic<int>("availableSpace", true);
            }
        }

        public int CheckTotalSpace()
        {
            using (AndroidJavaClass dataUtils = new AndroidJavaClass("com.dikra.diskutils.DiskUtils"))
            {
                return dataUtils.CallStatic<int>("totalSpace", true);
            }
        }

        public int CheckBusySpace()
        {
            using (AndroidJavaClass dataUtils = new AndroidJavaClass("com.dikra.diskutils.DiskUtils"))
            {
                return dataUtils.CallStatic<int>("busySpace", true);
            }
        }
    }
#endif
}