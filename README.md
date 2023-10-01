namespace Silverdale.Utils
{
    //Example usage
    public static class StorageUtils
    {
        public static long GetAvailableFreeSpaceMb()
        {
            return DiskUtils.DiskUtils.CheckAvailableSpace();
        }

        public static long GetTotalSpaceMb()
        {
            return DiskUtils.DiskUtils.CheckTotalSpace();
        }
        
        public static bool IsEnoughSpaceAvailable(long totalRequiredSpaceMb)
        {
            long availableSpaceMb = GetAvailableFreeSpaceMb();
            return availableSpaceMb >= totalRequiredSpaceMb;
        }
    }
}