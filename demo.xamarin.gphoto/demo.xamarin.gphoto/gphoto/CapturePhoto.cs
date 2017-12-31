using System;
using System.Runtime.InteropServices;

namespace demo.xamarin.gphoto.gphoto
{
    public static class CapturePhoto
    {
        [DllImport("libcapture.dylib", EntryPoint = "capture_to_memory")]

        static extern void CapturePhotoToMemorylib(int cameraId, ContextBoundObject context, String ptr, String size);

        [DllImport("libcapture.dylib", EntryPoint = "capture_to_file")]

        static extern void CapturePhotoToFilelib(int cameraId, ContextBoundObject context, String ptr, String size);


        public static void CapturePhotoToMemory(int cameraId, ContextBoundObject context, String ptr, String size)
        {
            CapturePhotoToMemorylib(cameraId, context, ptr, size);
        }

        public static void CapturePhotoToFile(int cameraId, ContextBoundObject context, String ptr, String size)
        {
            CapturePhotoToMemorylib(cameraId, context, ptr, size);
        }
    }
}
