using OnvifCamera.Media;
using OnvifCamera.PTZ;
using OnvifCamera.Service;
using System;
using System.Drawing;
using System.ComponentModel;
using System.Windows;
using System.Windows.Forms;
using MessageBox = System.Windows.Forms.MessageBox;
using System.Drawing.Imaging;
using System.Threading.Tasks;
using OnvifCamera.Logging;
using System.Threading;

namespace OnvifCamera
{
    public partial class Camera : UserControl
    {
        private MediaClient Media;
        private Profile[] profiles;
        Profile profile;
        private PTZClient PTZ;
        private PTZPreset[] presets;
        private PTZConfigurationOptions options;
        private PTZVector vector;
        private PTZ.PTZSpeed velocity;
        private PTZ.PTZConfiguration[] configs;
        //
        private bool
            initialised,            
            Connect = true;
        //
        private string
            _Presettoken,
            timeout;

        System.Timers.Timer _Timer = new System.Timers.Timer(2000);

        public Camera()
        {
            InitializeComponent();
            //
            //Media = OnvifServices.GetOnvifMediaClient(IPTextBox.Text, LoginTextBox.Text, PasswordTextBox.Text);
            //profiles = Media.GetProfiles();
            //
            _Timer.Elapsed += TimerEvent;
            _Timer.Enabled = true;
        }

        private void TimerEvent(object sender, System.Timers.ElapsedEventArgs e)
        {
            //FpsLabel.Text = $"Битрейт: {profiles[0].VideoEncoderConfiguration.RateControl.BitrateLimit} kbp/s";
            //BitrateLabel.Text = $"Кадров: {profiles[0].VideoEncoderConfiguration.RateControl.FrameRateLimit}";
        }

    
        private void показатьКнопкиУправленияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Media = OnvifServices.GetOnvifMediaClient(IPTextBox.Text, LoginTextBox.Text, PasswordTextBox.Text);
            profiles = Media.GetProfiles();
            //
            if (btnUp.Visible)
            {
                ButtonsVisibility(false);
                ContextItems.Items[0].Text = "[Показать] Кнопки управления";
            }
            else
            {
                ButtonsVisibility(true);
                ContextItems.Items[0].Text = "[Скрыть] Кнопки управления";
            }
        }

        private void ButtonsVisibility(bool visible)
        {
            btnUp.Visible = visible;
            btnLeft.Visible = visible;
            btnRight.Visible = visible;
            btnDown.Visible = visible;
            btnZoomIn.Visible = visible;
            btnZoomOut.Visible = visible;
        } 

        #region Camera SDK
        private void PTZInitialization()
        {
            Media = OnvifServices.GetOnvifMediaClient(IPTextBox.Text, LoginTextBox.Text, PasswordTextBox.Text);
            PTZ = OnvifServices.GetOnvifPTZClient(IPTextBox.Text, LoginTextBox.Text, PasswordTextBox.Text);
            
            //
            if (profiles[0].PTZConfiguration != null)
            {
                timeout = profiles[0].PTZConfiguration.DefaultPTZTimeout;
                //
                configs = PTZ.GetConfigurations();
                options = PTZ.GetConfigurationOptions(configs[0].token);
                //
                velocity = new PTZ.PTZSpeed()
                {
                    PanTilt = new PTZ.Vector2D()
                    {
                        x = 0,
                        y = 0,
                        space = options.Spaces.ContinuousPanTiltVelocitySpace[0].URI,
                    },
                    Zoom = new PTZ.Vector1D()
                    {
                        x = 0,
                        space = options.Spaces.ContinuousZoomVelocitySpace[0].URI,
                    }
                };
                vector = new PTZVector()
                {
                    PanTilt = new PTZ.Vector2D()
                    {
                        x = 0,
                        y = 0,
                        space = options.Spaces.RelativePanTiltTranslationSpace[0].URI
                    },
                    Zoom = new PTZ.Vector1D()
                    {
                        x = 0
                    }
                };
            }
            //
            if (configs != null && configs.Length != 0)
            {
                presets = PTZ.GetPresets(configs[0].token);
            }
            //
            if (presets != null && presets.Length != 0)
            {
                _Presettoken = presets[0].token;
            }
            //
            var MediaUri = OnvifServices.GetStreamURI(Media, profiles[0].token);
            var streamUri = MediaUri.Uri.Insert(7, LoginTextBox.Text + ":" + PasswordTextBox.Text + "@");
            //
            StreamPlayer.StartPlay(streamUri);
            initialised = true;
            
        }
        #endregion

        public void Zoomin()
        {
            float speed = 0.3F;
            try
            {
                velocity = new PTZ.PTZSpeed()
                {
                    PanTilt = new PTZ.Vector2D()
                    {
                        x = 0,
                        y = 0,
                        space = options.Spaces.ContinuousPanTiltVelocitySpace[0].URI,
                    },
                    Zoom = new PTZ.Vector1D()
                    {
                        x = 0,
                        space = options.Spaces.ContinuousZoomVelocitySpace[0].URI,
                    }
                };
                if (initialised)
                {
                    velocity.Zoom.x = speed * options.Spaces.ContinuousZoomVelocitySpace[0].XRange.Max;
                    velocity.Zoom.space = options.Spaces.ContinuousZoomVelocitySpace[0].URI;
                    PTZ.ContinuousMove(profile.token, velocity, timeout);
                }
            }

            catch
            {
                MessageBox.Show("Oshibka");
            }
        }

        public void Zoomout()
        {
            float speed = 0.5F;
            try
            {
                velocity = new PTZ.PTZSpeed()
                {
                    PanTilt = new PTZ.Vector2D()
                    {
                        x = 0,
                        y = 0,
                        space = options.Spaces.ContinuousPanTiltVelocitySpace[0].URI,
                    },
                    Zoom = new PTZ.Vector1D()
                    {
                        x = 0,
                        space = options.Spaces.ContinuousZoomVelocitySpace[0].URI,
                    }
                };
                if (initialised)
                {

                    velocity.Zoom.x = speed * options.Spaces.ContinuousZoomVelocitySpace[0].XRange.Min;
                    velocity.Zoom.space = options.Spaces.ContinuousZoomVelocitySpace[0].URI;
                    PTZ.ContinuousMove(profile.token, velocity, timeout);
                }

            }
            catch
            {
                MessageBox.Show("Oshibka");
            }

        }


        public void PanLeft()
        {
            try
            {
                velocity = new PTZ.PTZSpeed()
                {
                    PanTilt = new PTZ.Vector2D()
                    {
                        x = 0,
                        y = 0,
                        space = options.Spaces.ContinuousPanTiltVelocitySpace[0].URI,
                    },
                    Zoom = new PTZ.Vector1D()
                    {
                        x = 0,
                        space = options.Spaces.ContinuousZoomVelocitySpace[0].URI,
                    }
                };

                if (initialised)
                {
                    velocity.PanTilt.x = options.Spaces.ContinuousPanTiltVelocitySpace[0].XRange.Min / 5;
                    velocity.PanTilt.y = 0;
                    PTZ.ContinuousMoveAsync(profile.token, velocity, timeout);

                }
            }
            catch
            {
                MessageBox.Show("Oshibka");
            }

        }

        public void PanRight()
        {
            try
            {
                velocity = new PTZ.PTZSpeed()
                {
                    PanTilt = new PTZ.Vector2D()
                    {
                        x = 0,
                        y = 0,
                        space = options.Spaces.ContinuousPanTiltVelocitySpace[0].URI,
                    },
                    Zoom = new PTZ.Vector1D()
                    {
                        x = 0,
                        space = options.Spaces.ContinuousZoomVelocitySpace[0].URI,
                    }
                };
                if (initialised)
                {
                    velocity.PanTilt.x = options.Spaces.ContinuousPanTiltVelocitySpace[0].XRange.Max / 5;
                    velocity.PanTilt.y = 0;
                    PTZ.ContinuousMoveAsync(profile.token, velocity, timeout);
                }
            }
            catch
            {
                MessageBox.Show("Oshibka");

            }
        }

        public void TiltUp()
        {
            try
            {
                velocity = new PTZ.PTZSpeed()
                {
                    PanTilt = new PTZ.Vector2D()
                    {
                        x = 0,
                        y = 0,
                        space = options.Spaces.ContinuousPanTiltVelocitySpace[0].URI,
                    },
                    Zoom = new PTZ.Vector1D()
                    {
                        x = 0,
                        space = options.Spaces.ContinuousZoomVelocitySpace[0].URI,
                    }
                };
                if (initialised)
                {
                    velocity.PanTilt.x = 0;
                    velocity.PanTilt.y = options.Spaces.ContinuousPanTiltVelocitySpace[0].YRange.Max / 5;
                    PTZ.ContinuousMoveAsync(profile.token, velocity, timeout);
                }
            }
            catch
            {
                MessageBox.Show("Oshibka");
            }
        }

        public void TiltDown()
        {
            try
            {
                velocity = new PTZ.PTZSpeed()
                {
                    PanTilt = new PTZ.Vector2D()
                    {
                        x = 0,
                        y = 0,
                        space = options.Spaces.ContinuousPanTiltVelocitySpace[0].URI,
                    },
                    Zoom = new PTZ.Vector1D()
                    {
                        x = 0,
                        space = options.Spaces.ContinuousZoomVelocitySpace[0].URI,
                    }
                };
                if (initialised)
                {
                    velocity.PanTilt.x = 0;
                    velocity.PanTilt.y = options.Spaces.ContinuousPanTiltVelocitySpace[0].YRange.Min / 5;
                    PTZ.ContinuousMoveAsync(profile.token, velocity, timeout);
                }
            }

            catch
            {
                MessageBox.Show("Oshibka");
            }
        }

        public void Stop()
        {
            try
            {
                profile = Media.GetProfile(profile.token);
                PTZ.Stop(profile.token, true, true);
            }

            catch
            {
                MessageBox.Show("Oshibka");
            }
        }

        private void Zoom_Out_MouseDown(object sender, EventArgs e)
        {
            try
            {
                Thread thread = new Thread(new ThreadStart(Zoomout));
                thread.Start();
            }
            catch (Exception ex)
            {
                EventLogging.LogEvents("Function: Zoom_Out_MouseDown()" + ex);
            }
        }

        private void Zoom_Out_MouseUp(object sender, EventArgs e)
        {
            try
            {
                Thread thread = new Thread(new ThreadStart(Stop));
                thread.Start();
            }

            catch
            {
                MessageBox.Show("Oshibka");
            }
        }

        private void Zoom_In_MouseDown(object sender, EventArgs e)
        {
            try
            {
                Thread thread = new Thread(new ThreadStart(Zoomin));
                thread.Start();
            }
            catch
            {
                MessageBox.Show("Oshibka");
            }
        }

        private void Zoom_In_MouseUp(object sender, EventArgs e)
        {
            try
            {
                Thread thread = new Thread(new ThreadStart(Stop));
                thread.Start();
            }
            catch
            {
                MessageBox.Show("Oshibka");
            }
        }

        private void Down_MouseDown(object sender, EventArgs e)
        {
            try
            {
                Thread thread = new Thread(new ThreadStart(TiltDown));
                thread.Start();
            }
            catch
            {
                MessageBox.Show("Oshibka");
            }
        }

        private void Down_MouseUp(object sender, EventArgs e)
        {
            try
            {
                Thread thread = new Thread(new ThreadStart(Stop));
                thread.Start();
            }
            catch
            {
                MessageBox.Show("Oshibka");
            }
        }

        private void Right_MouseDown(object sender, EventArgs e)
        {
            try
            {
                Thread thread = new Thread(new ThreadStart(PanRight));
                thread.Start();
            }

            catch
            {
                MessageBox.Show("Oshibka");
            }
        }      

        private void Camera_Load(object sender, EventArgs e)
        {

        }

        private void btnZoomOut_Click(object sender, EventArgs e)
        {

        }

        private void btnZoomIn_Click(object sender, EventArgs e)
        {

        }

        private void btnDown_Click(object sender, EventArgs e)
        {

        }

        private void btnRight_Click(object sender, EventArgs e)
        {

        }

        private void btnLeft_Click(object sender, EventArgs e)
        {

        }

        private void btnUp_Click(object sender, EventArgs e)
        {

        }

        private void ConnectButton_Click(object sender, EventArgs e)
        {
            if (Connect)
            {
                try
                {
                    PTZInitialization();
                    //
                    Connect = false;
                }
                catch (NullReferenceException) { MessageBox.Show("Нет данных для подключения", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                catch (Exception Error) { MessageBox.Show($"{Error}", "Ошибка"); }
            }
            else
            {
                StreamPlayer.Stop();
                //
                Connect = true;
            }
        }

        private void Right_MouseUp(object sender, EventArgs e)
        {
            try
            {
                Thread thread = new Thread(new ThreadStart(Stop));
                thread.Start();
            }
            catch
            {
                MessageBox.Show("Oshibka");
            }
        }

        private void Left_MouseDown(object sender, EventArgs e)
        {
            try
            {
                Thread thread = new Thread(new ThreadStart(PanLeft));
                thread.Start();
            }
            catch
            {
                MessageBox.Show("Oshibka");
            }
        }

        private void Left_MouseUp(object sender, EventArgs e)
        {
            try
            {
                Thread thread = new Thread(new ThreadStart(Stop));
                thread.Start();
            }
            catch
            {
                MessageBox.Show("Oshibka");
            }

        }

        private void Up_MouseDown(object sender, EventArgs e)
        {
            try
            {
                Thread thread = new Thread(new ThreadStart(TiltUp));
                thread.Start();
            }
            catch
            {
                MessageBox.Show("Oshibka");
            }
        }

        private void Up_MouseUp(object sender, EventArgs e)
        {
            try
            {
                Thread thread = new Thread(new ThreadStart(Stop));
                thread.Start();
            }
            catch
            {
                MessageBox.Show("Oshibka");
            }

        }

        private void Reset_Click(object sender, EventArgs e)
        {
            PTZ.GotoPreset(profile.token, _Presettoken, velocity);
        }

    }
}