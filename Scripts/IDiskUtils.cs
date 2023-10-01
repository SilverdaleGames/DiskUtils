namespace Silverdale.DiskUtils
{
    public interface IDiskUtils
    {
        int CheckAvailableSpace();
        int CheckTotalSpace();
        int CheckBusySpace();
    }
}
