using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace CameraController
{
    public partial class ucCamera : UserControl
    {




        public class CameraEventArgs : EventArgs
        {
            public string Message { get; set; }
        }

        public ucCamera()
        {
            InitializeComponent();
        }

        #region Events

        // ----------------------------------------  Begin Events  ----------------------------------------


        public event EventHandler BecameActive;
        public event EventHandler<CameraEventArgs> SendHistory;

        private void OnActive()
        {
            var eventHandler = BecameActive;
            if (eventHandler != null)
            {
                eventHandler(this, new EventArgs());
            }
        }


        private void OnSendHistory(string output)
        {
            var eventHandler = SendHistory;

            if (eventHandler != null)
            {
                eventHandler(this, new CameraEventArgs() { Message = output });
            }

        }


        // ----------------------------------------  End Events  ----------------------------------------

        #endregion



        #region Properties

        // ----------------------------------------  Begin Properties  ----------------------------------------

        System.IO.Ports.SerialPort _serialCapturePort;


        public System.IO.Ports.SerialPort SerialCapturePort
        {
            get
            {
                return _serialCapturePort;
            }
            set
            {
                _serialCapturePort = value;
                //_serialCapturePort.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(_serialCapturePort_DataReceived);
            }
        }

        void _serialCapturePort_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {

        }

        public int CameraNumber
        {
            get
            {
                return int.Parse(ux_cmbCameraNumber.Text);
            }
            set
            {
                ux_cmbCameraNumber.Text = value.ToString();
            }
        }

        public bool Active
        {
            get
            {
                return ux_chkActive.Checked;
            }
            set
            {
                ux_chkActive.Checked = value;
            }
        }

        // ----------------------------------------  End Properties  ----------------------------------------

        #endregion



        const byte COMMAND_TERMINATOR = 0xff;


        enum PanDirection
        {
            Up,
            Down,
            Left,
            Right
        }



        #region Button Events

        // ----------------------------------------  Begin Button Events  ----------------------------------------


        private void ux_btnUp_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                PanUpStep();
            }
            else
            {
                PanUp();
            }

        }

        private void PanUp()
        {
            PanCamera(int.Parse(ux_cmbCameraNumber.Text), PanDirection.Up, (int)ux_udSpeed.Value, (int)ux_udSpeed.Value);
        }

        private void PanUpStep()
        {
            PanRelative(int.Parse(ux_cmbCameraNumber.Text),
                PanDirection.Up,
                (int)ux_udSpeed.Value,
                (int)ux_udSpeed.Value,
                (int)ux_udStepSpeed.Value);
        }

        private void ux_btnUp_MouseUp(object sender, MouseEventArgs e)
        {
            StopPanCamera(int.Parse(ux_cmbCameraNumber.Text), (int)ux_udSpeed.Value, (int)ux_udSpeed.Value);
        }

        private void ux_btnDown_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                PanDownStep();
            }
            else
            {
                PanDown();
            }
        }

        private void PanDown()
        {
            PanCamera(int.Parse(ux_cmbCameraNumber.Text), PanDirection.Down, (int)ux_udSpeed.Value, (int)ux_udSpeed.Value);
        }

        private void PanDownStep()
        {
            PanRelative(int.Parse(ux_cmbCameraNumber.Text),
                PanDirection.Down,
                (int)ux_udSpeed.Value,
                (int)ux_udSpeed.Value,
                (int)ux_udStepSpeed.Value);
        }

        private void ux_btnDown_MouseUp(object sender, MouseEventArgs e)
        {
            StopPanCamera(int.Parse(ux_cmbCameraNumber.Text), (int)ux_udSpeed.Value, (int)ux_udSpeed.Value);
        }

        private void ux_btnLeft_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                PanLeftStep();
            }
            else
            {
                PanLeft();
            }

        }

        private void PanLeft()
        {
            PanCamera(int.Parse(ux_cmbCameraNumber.Text), PanDirection.Left, (int)ux_udSpeed.Value, (int)ux_udSpeed.Value);
        }

        private void PanLeftStep()
        {
            PanRelative(int.Parse(ux_cmbCameraNumber.Text),
                PanDirection.Left,
                (int)ux_udSpeed.Value,
                (int)ux_udSpeed.Value,
                (int)ux_udStepSpeed.Value);
        }

        private void ux_btnLeft_MouseUp(object sender, MouseEventArgs e)
        {
            StopPanCamera(int.Parse(ux_cmbCameraNumber.Text), (int)ux_udSpeed.Value, (int)ux_udSpeed.Value);
        }

        private void ux_btnRight_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                PanRightStep();
            }
            else
            {
                PanRight();
            }

        }

        private void PanRight()
        {
            PanCamera(int.Parse(ux_cmbCameraNumber.Text), PanDirection.Right, (int)ux_udSpeed.Value, (int)ux_udSpeed.Value);
        }

        private void PanRightStep()
        {
            PanRelative(int.Parse(ux_cmbCameraNumber.Text),
                    PanDirection.Right,
                    (int)ux_udSpeed.Value,
                    (int)ux_udSpeed.Value,
                    (int)ux_udStepSpeed.Value);
        }

        private void ux_btnRight_MouseUp(object sender, MouseEventArgs e)
        {
            StopPanCamera(int.Parse(ux_cmbCameraNumber.Text), (int)ux_udSpeed.Value, (int)ux_udSpeed.Value);
        }



        private void ux_btnHome_Click(object sender, EventArgs e)
        {
            PanTiltHome(int.Parse(ux_cmbCameraNumber.Text));
        }


        private void ux_Zoom_ValueChanged(object sender, EventArgs e)
        {
            //ZoomDirect(int.Parse(ux_cmbCameraNumber.Text), ux_Zoom.Value);
        }

        private void ux_Zoom_MouseUp(object sender, MouseEventArgs e)
        {
            ZoomDirect(int.Parse(ux_cmbCameraNumber.Text), ux_Zoom.Value);
        }

        private void ux_Zoom_KeyPress(object sender, KeyPressEventArgs e)
        {
            //ZoomDirect(int.Parse(ux_cmbCameraNumber.Text), ux_Zoom.Value);
        }

        private void ux_Zoom_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                if (ux_Zoom.Value < ux_Zoom.Maximum)
                {
                    ux_Zoom.Value += 1;
                    ZoomDirect(int.Parse(ux_cmbCameraNumber.Text), ux_Zoom.Value);
                }
            }
            else if (e.KeyCode == Keys.Down)
            {
                if (ux_Zoom.Value > ux_Zoom.Minimum)
                {
                    ux_Zoom.Value -= 1;
                    ZoomDirect(int.Parse(ux_cmbCameraNumber.Text), ux_Zoom.Value);
                }
            }



            e.SuppressKeyPress = true;
        }




        private void ux_btnZoomIn_Click(object sender, EventArgs e)
        {
            //do not exceed the maximum
            ux_Zoom.Value = Math.Min(ux_Zoom.Maximum, ux_Zoom.Value + (int)ux_udZoomSpeed.Value);
            ZoomDirect(int.Parse(ux_cmbCameraNumber.Text), ux_Zoom.Value);
        }

        private void ux_btnZoomOut_Click(object sender, EventArgs e)
        {
            //do not exceed the minimum
            ux_Zoom.Value = Math.Max(ux_Zoom.Minimum, ux_Zoom.Value - (int)ux_udZoomSpeed.Value);
            ZoomDirect(int.Parse(ux_cmbCameraNumber.Text), ux_Zoom.Value);

        }






        // ----------------------------------------  End Button Events  ----------------------------------------

        #endregion


        #region Camera Commands

        // ----------------------------------------  Begin Camera Commands  ----------------------------------------


        private void PanCamera(int cameraNumber, PanDirection direction, int tiltSpeed, int panSpeed)
        {
            byte[] command = new byte[9];

            //Up:  8x 01 06 01 VV WW 03 01 FF
            //  VV = pan speed 0x01 - 0x18 - 24 dec
            //  WW = tilt speed 0x01 - 0x14 - 20 dec


            command[0] = (byte)(0x80 | (byte)cameraNumber);
            command[1] = 0x01;
            command[2] = 0x06;
            command[3] = 0x01;
            command[4] = (byte)panSpeed;
            command[5] = (byte)tiltSpeed;
            switch (direction)
            {
                case PanDirection.Up:
                    command[6] = 0x03;
                    command[7] = 0x01;
                    break;
                case PanDirection.Down:
                    command[6] = 0x03;
                    command[7] = 0x02;
                    break;
                case PanDirection.Left:
                    command[6] = 0x01;
                    command[7] = 0x03;
                    break;
                case PanDirection.Right:
                    command[6] = 0x02;
                    command[7] = 0x03;
                    break;
                default:
                    break;
            }
            command[8] = COMMAND_TERMINATOR;

            SendCommand(SerialCapturePort, command);
        }

        private void PanRelative(int cameraNumber, PanDirection direction, int panSpeed, int tiltSpeed, int stepSpeed)
        {
            byte[] command = new byte[15];

            //Up:  8x 01 06 03 VV WW 0Y 0Y 0Y 0Y 0Z 0Z 0Z 0Z FF
            //  VV = pan speed 0x01 - 0x18 - 24 dec
            //  WW = tilt speed 0x01 - 0x14 - 20 dec
            //  YY = pan position
            //  ZZ = tilt position


            command[0] = (byte)(0x80 | (byte)cameraNumber);
            command[1] = 0x01;
            command[2] = 0x06;
            command[3] = 0x03;
            command[4] = (byte)panSpeed;
            command[5] = (byte)tiltSpeed;
            switch (direction)
            {
                case PanDirection.Up:
                    CameraBitShift((Int16)stepSpeed).CopyTo(command, 10);
                    break;
                case PanDirection.Down:
                    CameraBitShift((Int16)(stepSpeed * -1)).CopyTo(command, 10);
                    break;
                case PanDirection.Left:
                    CameraBitShift((Int16)(stepSpeed * -1)).CopyTo(command, 6);
                    break;
                case PanDirection.Right:
                    CameraBitShift((Int16)stepSpeed).CopyTo(command, 6);
                    break;
                default:
                    break;
            }
            command[14] = COMMAND_TERMINATOR;

            SendCommand(SerialCapturePort, command);
        }

        private void StopPanCamera(int cameraNumber, int tiltSpeed, int panSpeed)
        {
            byte[] command = new byte[9];

            //Stop:  8x 01 06 01 VV WW 03 03 FF
            //  VV = pan speed 0x01 - 0x18 - 24 dec
            //  WW = tilt speed 0x01 - 0x14 - 20 dec


            command[0] = (byte)(0x80 | (byte)cameraNumber);
            command[1] = 0x01;
            command[2] = 0x06;
            command[3] = 0x01;
            command[4] = (byte)panSpeed;
            command[5] = (byte)tiltSpeed;
            command[6] = 0x03;
            command[7] = 0x03;
            command[8] = COMMAND_TERMINATOR;

            SendCommand(SerialCapturePort, command);
        }

        private void PanTiltHome(int cameraNumber)
        {
            byte[] command = new byte[5];

            //Reset:  8x 01 06 05 FF

            command[0] = (byte)(0x80 | (byte)cameraNumber);
            command[1] = 0x01;
            command[2] = 0x06;
            command[3] = 0x04;
            command[4] = COMMAND_TERMINATOR;

            SendCommand(SerialCapturePort, command);
        }

        private void ResetPanTilt(int cameraNumber)
        {
            byte[] command = new byte[5];

            //Reset:  8x 01 06 05 FF

            command[0] = (byte)(0x80 | (byte)cameraNumber);
            command[1] = 0x01;
            command[2] = 0x06;
            command[3] = 0x05;
            command[4] = COMMAND_TERMINATOR;

            SendCommand(SerialCapturePort, command);
        }



        private void ZoomDirect(int cameraNumber, int zoomValue)
        {
            byte[] command = new byte[9];

            //Zoom Direct:  8x 01 04 47 0Z 0Z 0Z 0Z FF
            //  ZZ = Zoom Data, 0000 Wide, 03FF (Tele) D30 Mode (1023), 7AC0 (~25000) D70 Mode - set to 23000 for better response on tele


            command[0] = (byte)(0x80 | (byte)cameraNumber);
            command[1] = 0x01;
            command[2] = 0x04;
            command[3] = 0x47;
            CameraBitShift((Int16)zoomValue).CopyTo(command, 4);
            //BitConverter.GetBytes(CameraBitShift(zoomValue)).CopyTo(command, 4);
            command[8] = COMMAND_TERMINATOR;

            SendCommand(SerialCapturePort, command);
        }

        private byte[] CameraBitShift(byte bytShift)
        {
            byte[] output = new byte[4];
            //output += (intShift & 0xf0000) << 16;
            output[0] = (byte)((bytShift & 0xf000) >> 12);
            output[1] = (byte)((bytShift & 0x0f00) >> 8);
            output[2] = (byte)((bytShift & 0x00f0) >> 4);
            output[3] = (byte)((bytShift & 0x000f));
            return output;
        }

        private byte[] CameraBitShift(Int16 intShift)
        {
            byte[] output = new byte[4];
            //output[0] = (byte)((intShift & 0xf0000) >> 16);
            output[0] = (byte)((intShift & 0xf000) >> 12);
            output[1] = (byte)((intShift & 0x0f00) >> 8);
            output[2] = (byte)((intShift & 0x00f0) >> 4);
            output[3] = (byte)((intShift & 0x000f));
            return output;
        }


        private void SendCommand(System.IO.Ports.SerialPort srlCapture, byte[] command)
        {
            string output;
            output = Common.SendCameraCommand(srlCapture, command);

            OnSendHistory(output);

        }


        private void ucCamera_KeyDown(object sender, KeyEventArgs e)
        {
            Debug.Print("KeyDown on ucCamera");
        }

        private void ucCamera_KeyPress(object sender, KeyPressEventArgs e)
        {
            Debug.Print("KeyPress on ucCamera");
        }

        private void ucCamera_KeyUp(object sender, KeyEventArgs e)
        {
            Debug.Print("KeyUp on ucCamera");
        }

        private void ucCamera_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            Debug.Print("Preview KeyDown on ucCamera");
        }

        protected override void OnKeyDown(KeyEventArgs e)
        {
            base.OnKeyDown(e);
            Debug.Print("OnKeyDown on ucCamera");
        }




        private void SetPreset(int cameraNumber, int presetNumber)
        {
            //convert to zeroBased
            int preset = presetNumber - 1;
            if (preset > 5 || preset < 0)
            {
                return;  //ignore out of range values
            }

            byte[] command = new byte[7];

            //Up:  8x 01 06 03 VV WW 0Y 0Y 0Y 0Y 0Z 0Z 0Z 0Z FF
            //  VV = pan speed 0x01 - 0x18 - 24 dec
            //  WW = tilt speed 0x01 - 0x14 - 20 dec
            //  YY = pan position
            //  ZZ = tilt position


            command[0] = (byte)(0x80 | (byte)cameraNumber);
            command[1] = 0x01;
            command[2] = 0x04;
            command[3] = 0x3F;
            command[4] = 0x01;
            command[5] = (byte)preset;
            command[6] = COMMAND_TERMINATOR;

            SendCommand(SerialCapturePort, command);
        }

        private void RecallPreset(int cameraNumber, int presetNumber)
        {
            //convert to zeroBased
            int preset = presetNumber - 1;
            if (preset > 5 || preset < 0)
            {
                return;  //ignore out of range values
            }

            byte[] command = new byte[7];


            command[0] = (byte)(0x80 | (byte)cameraNumber);
            command[1] = 0x01;
            command[2] = 0x04;
            command[3] = 0x3F;
            command[4] = 0x02;
            command[5] = (byte)preset;
            command[6] = COMMAND_TERMINATOR;

            SendCommand(SerialCapturePort, command);

            //ReadAutoZoom(cameraNumber);

        }

        private void ReadAutoZoom(int cameraNumber)
        {
            //8x 09 04 38 FF
            byte[] cmd = new byte[5];

            cmd[0] = (byte)(0x80 | (byte)cameraNumber);
            cmd[1] = 0x09;
            cmd[2] = 0x04;
            cmd[3] = 0x38;
            cmd[4] = COMMAND_TERMINATOR;

            Common.SendCameraCommand(SerialCapturePort, cmd);

        }


        private void ux_btnPreset_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                SetLabel((Button)sender);
            }
            else if ((Control.ModifierKeys & Keys.Control) == Keys.Control)
            {
                SetPreset(int.Parse(ux_cmbCameraNumber.Text), int.Parse((string)((Button)sender).Tag));
            }
            else
            {
                RecallPreset(int.Parse(ux_cmbCameraNumber.Text), int.Parse((string)((Button)sender).Tag));
            }
        }

        delegate void setLabelDelegate(Button control);

        private void SetLabel(Button control)
        {
            if (control.InvokeRequired)
            {
                setLabelDelegate del = new setLabelDelegate(SetLabel);
                control.Invoke(del, control);
            }
            else
            {
                SetLabel lbl = new SetLabel(control.Text);
                lbl.ShowDialog();
                if (lbl.DialogResult == DialogResult.OK)
                {
                    control.Text = lbl.Label;
                }
                //control.Text = 
            }
        }


        private void ux_chkAutoFocus_CheckedChanged(object sender, EventArgs e)
        {

            CheckBox ctl = sender as CheckBox;

            byte[] command = new byte[6];

            //8x 01 04 38 02 ff  autofocus on

            command[0] = (byte)(0x80 | (byte.Parse(ux_cmbCameraNumber.Text)));
            command[1] = 0x01;
            command[2] = 0x04;
            command[3] = 0x38;
            //command[4] = 0x02;
            command[5] = COMMAND_TERMINATOR;


            if (ctl.Checked)
            {
                command[4] = 0x02;
            }
            else
            {
                command[4] = 0x03;
            }


            SendCommand(SerialCapturePort, command);

        }

        private void ux_chkAutoBrightness_CheckedChanged(object sender, EventArgs e)
        {

            CheckBox ctl = sender as CheckBox;

            byte[] command = new byte[6];

            //8x 01 04 39 00 ff  auto AE on
            //8x 01 04 39 03 ff  auto AE manual - full manual shutter, iris, gain
            //8x 01 04 39 0d ff  auto AE manual - bright mode

            command[0] = (byte)(0x80 | (byte.Parse(ux_cmbCameraNumber.Text)));
            command[1] = 0x01;
            command[2] = 0x04;
            command[3] = 0x39;
            //command[4] = 0x02;
            command[5] = COMMAND_TERMINATOR;


            if (ctl.Checked)
            {
                command[4] = 0x00;  //auto ae
            }
            else
            {
                command[4] = 0x0D;  //manual - Bright mode
            }


            SendCommand(SerialCapturePort, command);

        }

        private void ux_btnBrightMinus_Click(object sender, EventArgs e)
        {
            if (!ux_chkAutoBrightness.Checked)
            {
                byte[] command = new byte[6];

                //8x 01 04 0d 02 ff - increase brightness
                //8x 01 04 0d 03 ff - decrease brightness

                command[0] = (byte)(0x80 | (byte.Parse(ux_cmbCameraNumber.Text)));
                command[1] = 0x01;
                command[2] = 0x04;
                command[3] = 0x0d;
                command[4] = 0x03;
                command[5] = COMMAND_TERMINATOR;

                SendCommand(SerialCapturePort, command);
            }
        }

        private void ux_btnBrightPlus_Click(object sender, EventArgs e)
        {

            if (!ux_chkAutoBrightness.Checked)
            {
                byte[] command = new byte[6];

                //8x 01 04 0d 02 ff - increase brightness
                //8x 01 04 0d 03 ff - decrease brightness

                command[0] = (byte)(0x80 | (byte.Parse(ux_cmbCameraNumber.Text)));
                command[1] = 0x01;
                command[2] = 0x04;
                command[3] = 0x0d;
                command[4] = 0x02;
                command[5] = COMMAND_TERMINATOR;

                SendCommand(SerialCapturePort, command);
            }
        }

        private void ux_chkActive_CheckedChanged(object sender, EventArgs e)
        {
            if (((CheckBox)sender).Checked)
            {
                OnActive();
            }
        }




        // ----------------------------------------  End Camera Commands  ----------------------------------------

        #endregion



        internal void SendKeyDown(KeyEventArgs e)
        {
            if (!e.Shift)
            {
                switch (e.KeyCode)
                {
                    case Keys.Up:
                        PanUp();
                        break;
                    case Keys.Down:
                        PanDown();
                        break;
                    case Keys.Left:
                        PanLeft();
                        break;
                    case Keys.Right:
                        PanRight();
                        break;
                    default:
                        break;
                }
            }
            else
            {
                switch (e.KeyCode)
                {
                    case Keys.Up:
                        PanUpStep();
                        break;
                    case Keys.Down:
                        PanDownStep();
                        break;
                    case Keys.Left:
                        PanLeftStep();
                        break;
                    case Keys.Right:
                        PanRightStep();
                        break;
                    default:
                        break;
                }
            }

        }

        internal void SendKeyUp(KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Up:
                    StopPanCamera(int.Parse(ux_cmbCameraNumber.Text), (int)ux_udSpeed.Value, (int)ux_udSpeed.Value);
                    break;
                case Keys.Down:
                    StopPanCamera(int.Parse(ux_cmbCameraNumber.Text), (int)ux_udSpeed.Value, (int)ux_udSpeed.Value);
                    break;
                case Keys.Left:
                    StopPanCamera(int.Parse(ux_cmbCameraNumber.Text), (int)ux_udSpeed.Value, (int)ux_udSpeed.Value);
                    break;
                case Keys.Right:
                    StopPanCamera(int.Parse(ux_cmbCameraNumber.Text), (int)ux_udSpeed.Value, (int)ux_udSpeed.Value);
                    break;
                default:
                    break;
            }
        }
       
    }
}
