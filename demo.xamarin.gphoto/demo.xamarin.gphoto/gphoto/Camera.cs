using System;
using System.Runtime.InteropServices;

namespace demo.xamarin.gphoto.gphoto
{
    public static class Camera
    {
        [DllImport("libopencamera.dylib", EntryPoint = "sample_open_camera")]

        static extern void OpenCameralib(int cameraId, string model, string port, ContextBoundObject context);

        public static void OpenCamera(int cameraId, string model, string port, ContextBoundObject context)
        {
            OpenCameralib(cameraId, model, port, context);
        }
    }
}
