using System;
using System.Diagnostics;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace RecoilControl
{
    public partial class Form1 : Form
    {
        private bool Running = true;
        bool EnabledRecoilСontrol = false;
        bool FindProcess = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
            Thread MoveMouseTH = new Thread(MouseMoveControl);
            Thread RefreshTH = new Thread(Refresh_R);
            Thread ChecPRCTH = new Thread(CheckingProcess);
            MoveMouseTH.Start();
            RefreshTH.Start();
            ChecPRCTH.Start();
        }

        private void Refresh_Click(object sender, EventArgs e)
        {
            StepSlider.Value = 0;
            IncreaseSlider.Value = 0;
            MaxIncreaseSlider.Value = 0;
        }

        private void MouseMoveControl()
        {
            int i = 0;
            while (Running)
            {
                Thread.Sleep(1);
                if (MagicMouse.bGetAsyncKeyState(Keys.LButton) && EnabledRecoilСontrol && IncreaseSlider.Value != 0)
                {
                    MagicMouse.Move(0, StepSlider.Value + (IncreaseSlider.Value * i));
                    if ((StepSlider.Value + (IncreaseSlider.Value * i)) < MaxIncreaseSlider.Value)
                        i++;
                }
                else if (MagicMouse.bGetAsyncKeyState(Keys.LButton) && EnabledRecoilСontrol)
                {
                    MagicMouse.Move(0, StepSlider.Value);
                }
                else
                {
                    i = 0;
                }
            }
        }

        private void CheckingProcess()
        {
            while (true)
            {
                Thread.Sleep(500);
                Process[] pname = Process.GetProcessesByName("rainbowsix");
                if (pname.Length == 0)
                {
                    if (CheckProcessLabel.ForeColor != Color.Red)
                    {
                        CheckProcessLabel.Text = "Not Open !";
                        CheckProcessLabel.ForeColor = Color.Red;
                        StepSlider.Enabled = false;
                        IncreaseSlider.Enabled = false;
                        MaxIncreaseSlider.Enabled = false;

                        FindProcess = false;
                    }
                }
                else
                {
                    if (CheckProcessLabel.ForeColor != Color.Green)
                    {
                        CheckProcessLabel.Text = "Open !";
                        CheckProcessLabel.ForeColor = Color.Green;
                        StepSlider.Enabled = true;
                        IncreaseSlider.Enabled = true;
                        MaxIncreaseSlider.Enabled = true;

                        FindProcess = true;
                    }
                }
            }
        }

        private void Refresh_R()
        {
            while (Running)
            {
                Thread.Sleep(1);
                StepLabel.Text = "● Step(" + StepSlider.Value.ToString() + "):";
                IncreaseLabel.Text = "● Increase(" + IncreaseSlider.Value.ToString() + "):";
                MaxIncreaseLabel.Text = "● Max Inc(" + MaxIncreaseSlider.Value.ToString() + "):";

                bool buffer = true;

                while (MagicMouse.bGetAsyncKeyState(Keys.F2))
                {
                    if (buffer && FindProcess)
                    {
                        EnabledRecoilСontrol = !EnabledRecoilСontrol;
                        buffer = false;
                    }
                }

                if (EnabledRecoilСontrol)
                {
                    if (StatusLabel.ForeColor != Color.Green)
                    {
                        StatusLabel.Text = "Enabled !";
                        StatusLabel.ForeColor = Color.Green;
                        CheckProcessLabel.Text = string.Empty;

                        StepSlider.Enabled = false;
                        IncreaseSlider.Enabled = false;
                        MaxIncreaseSlider.Enabled = false;
                    }
                }
                else
                {
                    if (StatusLabel.ForeColor != Color.Red)
                    {
                        StatusLabel.Text = "Disabled !";
                        StatusLabel.ForeColor = Color.Red;

                        StepSlider.Enabled = true;
                        IncreaseSlider.Enabled = true;
                        MaxIncreaseSlider.Enabled = true;
                    }
                }

                Thread.Sleep(1);
            }
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            if (EnabledRecoilСontrol)
                EnabledRecoilСontrol = false;

            GC.Collect();
            Environment.Exit(0);
        }

        #region Перемещение формы
        private bool mouseDown;
        private Point lastLocation;

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Opacity = 0.8;
                mouseDown = true;
                lastLocation = e.Location;
            }
        }
        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Opacity = 1;
                mouseDown = false;
            }
        }
        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (mouseDown)
                {
                    this.Location = new Point(
                        (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                    this.Update();
                }
            }
        }
        #endregion
    }
}
