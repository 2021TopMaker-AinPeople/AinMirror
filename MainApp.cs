using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tizen.Applications;
using Tizen.NUI;
using Tizen.NUI.BaseComponents;
using Tizen.NUI.Xaml;
using TCamera = Tizen.Multimedia.Camera;
using TCameraView = Tizen.NUI.BaseComponents.CameraView;

namespace AinMirror
{

    public class MainApp : NUIApplication
    {
        private TCamera _camera;
        private TCameraView _cameraView;

        override protected void OnCreate()
        {
            base.OnCreate();
            Initialize();
        }

        // NOTE To use theme.xaml, uncomment below line.
        // ThemeManager.ApplyTheme(new Theme(Tizen.Applications.Application.Current.DirectoryInfo.Resource + "theme/theme.xaml"));

        //GetDefaultWindow().AddAvailableOrientation(Window.WindowOrientation.Portrait);
        //GetDefaultWindow().SetPreferredOrientation(Window.WindowOrientation.Portrait);

        void Initialize()
        {
            ThemeManager.ApplyTheme(new Theme(Tizen.Applications.Application.Current.DirectoryInfo.Resource + "theme/theme.xaml"));

            _camera = new TCamera(Tizen.Multimedia.CameraDevice.Rear);

            try
            {
                IEnumerable<Tizen.Multimedia.Flips> flips = _camera.Capabilities.SupportedStreamFlips;

                foreach (Tizen.Multimedia.Flips f in flips)
                {
                    Console.WriteLine(f);
                }

                //Console.WriteLine("SupportedStreamFlips: {0}", _camera.Capabilities.SupportedStreamFlips);
                //_camera.Settings.StreamFlip = Tizen.Multimedia.Flips.Horizontal;
                //_camera.Settings.StreamFlip = Tizen.Multimedia.Flips.Horizontal;
            }
            catch (ObjectDisposedException e)
            {
                Console.WriteLine("Caught: {0}", e.Message);
            }

            /*
            try
            {
                _camera.Settings.StreamFlip = Tizen.Multimedia.Flips.Horizontal;
            }
            catch(ObjectDisposedException e)
            {
                Console.WriteLine("Caught: {0}", e.Message);
            }
            */





            /*
            // default display type is Window (Overlay mode)
            _cameraView = new CameraView(_camera.Handle, CameraView.DisplayType.Window);
            _cameraView.Size = new Size(640, 480);
            _cameraView.Position = new Position(640, 640);
            */

            /*
            _cameraView = new TCameraView(_camera.Handle, CameraView.DisplayType.Window)
            {
                Size = new Size(1920, 1440),
                Position = new Position(1, -360),
                //BackgroundColor = Color.Blue,
            };
            */

            _cameraView = new TCameraView(_camera.Handle, TCameraView.DisplayType.Window)
            {
                Size = new Size(1920, 1080),
                Position = new Position(1, 1),
                //BackgroundColor = Color.Blue,
            };


            if (_camera != null && _camera.State == Tizen.Multimedia.CameraState.Created)
            {
                _camera.StartPreview();
                //_cameraView.Update();

            }



            //GetDefaultWindow().Add(new Scene1Page());
            //GetDefaultWindow().Add(new CameraPopup().cameraView(_camera.Handle, CameraView.DisplayType.Window));
            GetDefaultWindow().Add(_cameraView);
            //GetDefaultWindow().KeyEvent += OnScene1KeyEvent;

            //GetDefaultWindow().Add(new Scene1Page());
            GetDefaultWindow().Add(new MainAppPage());

            GetDefaultWindow().KeyEvent += OnScene1KeyEvent;
        }
        

        private void OnScene1KeyEvent(object sender, Window.KeyEventArgs e)
        {
            if (e.Key.State == Key.StateType.Down && (e.Key.KeyPressedName == "XF86Back" || e.Key.KeyPressedName == "Escape"))
            {
                Exit();
            }
        }

        override protected void OnPause()
        {
            base.OnPause();
        }

        override protected void OnResume()
        {
            base.OnResume();
        }

        override protected void OnTerminate()
        {
            base.OnTerminate();
        }

        override protected void OnAppControlReceived(AppControlReceivedEventArgs e)
        {
            base.OnAppControlReceived(e);
        }
    }
}
