using System;
using System.Runtime.InteropServices;

namespace demo.xamarin.gphoto.gphoto
{
    public class ShowListOfPhotos
    {
        [DllImport("libcameratether.dylib", EntryPoint = "camera_tether")]

        static extern void DisplayPhotos(int cameraId, ContextBoundObject context);

        public static void DisplayListOfPhotosFromCamera(int cameraId, ContextBoundObject context) {
            DisplayPhotos(cameraId, context);
        }
    }
}
