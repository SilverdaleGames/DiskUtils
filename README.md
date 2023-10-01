# Silverdale.DiskUtils

The `Silverdale.DiskUtils` namespace provides a collection of utilities to interact and retrieve information about disk storage in Unity across different platforms including Android, iOS, and the Unity editor.

## DiskUtils Class

`DiskUtils` is a static class within the `Silverdale.DiskUtils` namespace that provides a unified interface to query disk storage information, such as available, total, and busy space.

### Structure

```csharp
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
```

### Methods

- **CheckAvailableSpace()**  
  Returns the available storage space in megabytes (MB).

- **CheckTotalSpace()**  
  Returns the total storage space in megabytes (MB).

- **CheckBusySpace()**  
  Returns the busy storage space in megabytes (MB).

## Example Usage

```csharp
using UnityEngine;
using Silverdale.DiskUtils;

public class DiskUsageExample : MonoBehaviour
{
    void Start()
    {
        int availableSpace = DiskUtils.CheckAvailableSpace();
        int totalSpace = DiskUtils.CheckTotalSpace();
        int busySpace = DiskUtils.CheckBusySpace();
        
        Debug.Log($"Available Space: {availableSpace} MB");
        Debug.Log($"Total Space: {totalSpace} MB");
        Debug.Log($"Busy Space: {busySpace} MB");
    }
}
```

In this example, we retrieve and log the available, total, and busy space on the disk when the script starts.

## Platform-Specific Implementations

`DiskUtils` utilizes platform-specific implementations to retrieve the disk storage information:

- **AndroidDiskUtils** for Android platforms.
- **IOSDiskUtils** for iOS platforms.
- **EditorDiskUtils** for Unity editor.

