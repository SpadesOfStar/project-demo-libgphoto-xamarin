using Android.App;
using Android.Widget;
using Android.OS;
using demo.xamarin.gphoto.gphoto;
using System;

namespace demo.xamarin.gphoto
{
    [Activity(Label = "demo.xamarin.gphoto", MainLauncher = true)]
    public class MainActivity : Activity
    {
        int cameraId;
        string model, port, ptr, size;
        bool captureToMemory = false;
        ContextBoundObject context;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.Main);
        }

        private void OpenCameraTest() {
            Camera.OpenCamera(cameraId, model, port, context);
        }

        private void CapturePhotoTest() {
            if(captureToMemory) {
                CapturePhoto.CapturePhotoToMemory(cameraId, context, ptr, size);
            }
            else {
                CapturePhoto.CapturePhotoToFile(cameraId, context, ptr, size);
            }
        }

        private void startCameraRecordingTest() {
            // needs more research
        }

        private void stopCameraRecordingTest() {
            // needs more research
        }

        private void showListOfPhotosTest() {
            ShowListOfPhotos.DisplayListOfPhotosFromCamera(cameraId, context);
        }

        private void transferFileToAndroidTest() {
            // needs more research
        }

        private void displayLiveViewTest() {
            // needs more research
        }
    }
}

