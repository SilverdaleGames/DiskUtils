namespace Silverdale.DiskUtils
{
    public class EditorDiskUtils : IDiskUtils
    {
        public int CheckAvailableSpace() => 1000; // Mock Value
        public int CheckTotalSpace() => 2000; // Mock Value
        public int CheckBusySpace() => 1000; // Mock Value
    }
}