using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace CameraController
{
    public partial class Main : Form
    {
        private CaptureMode _currentCaptureMode = CaptureMode.Waiting;


        List<CameraController.ucCamera> _cameraControllers = new List<ucCamera>();
        ucCamera _activeCamera = null;


        System.IO.Ports.SerialPort _srlCapture = new System.IO.Ports.SerialPort();
        //System.IO.Ports.SerialPort _srlOutput = new System.IO.Ports.SerialPort();

        enum CaptureMode
        {
            Capturing,
            Waiting
        };

        /// <summary>
        /// Initialization for Main form
        /// </summary>
        public Main()
        {

            InitializeComponent();

        }

        private void btnCapture_Click(object sender, EventArgs e)
        {

            ChangeFormState();

        }

        private void ChangeFormState()
        {
            switch (_currentCaptureMode)
            {
                case CaptureMode.Waiting:
                    ux_btnCapture.Text = "Stop Capture";
                    _currentCaptureMode = CaptureMode.Capturing;
                    BeginCapture();
                    break;

                case CaptureMode.Capturing:
                    ux_btnCapture.Text = "Capture";
                    _currentCaptureMode = CaptureMode.Waiting;
                    EndCapture();
                    break;
            }

        }


        private void BeginCapture()
        {
            _srlCapture.PortName = ux_cmbInputPort.SelectedValue.ToString();
            //srlCapture.BaudRate = 1200;
            //srlCapture.Handshake = System.IO.Ports.Handshake.RequestToSend;
            _srlCapture.BaudRate = 9600;


            _srlCapture.Parity = System.IO.Ports.Parity.None;
            _srlCapture.Handshake = System.IO.Ports.Handshake.None;
            _srlCapture.StopBits = System.IO.Ports.StopBits.One;
            _srlCapture.DataBits = 8;


            //srlCapture.DtrEnable = true;  //turn on for the parallel to serial converter to receive power necessary to operate

            _srlCapture.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(srlCapture_DataReceived);
            _srlCapture.WriteTimeout = 3000;
            _srlCapture.ReadTimeout = 3000;
            _srlCapture.Open();

            ucCamera1.SerialCapturePort = _srlCapture;
            ucCamera2.SerialCapturePort = _srlCapture;


            Common.InitializeCameras(_srlCapture);


        }

        delegate void CallFunction();

        void srlCapture_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {

            string strCapture;
            StringBuilder strBuilder = new StringBuilder();

            do
            {

                if (ux_chkConvertFromHex.Checked)
                {
                    int bytesLength = _srlCapture.BytesToRead;
                    byte[] readBytes = new byte[bytesLength];
                    _srlCapture.Read(readBytes, 0, bytesLength);

                    for (int i = 0; i < bytesLength; i++)
                    {
                        string formatByte = string.Format("{0:x2} ", readBytes[i]);
                        strBuilder.Append(formatByte);
                    }


                    //int readByte;
                    //for (int i = 0; i < srlCapture.BytesToRead; i++)
                    //{
                    //    readByte = srlCapture.ReadByte();
                    //    string formatByte = string.Format("{0:x2} ", readByte);
                    //    strBuilder.Append(formatByte);
                    //}
                    strCapture = strBuilder.ToString();
                }
                else
                {
                    strCapture = _srlCapture.ReadExisting();
                }

                //MessageBox.Show(strCapture);

                UpdateDisplay(strCapture);
            }
            while (_srlCapture.BytesToRead > 0);

        }

        private void UpdateDisplay(string strCapture)
        {
            CallFunction del = delegate()
            {
                ux_txtReceivedData.Text += strCapture + Environment.NewLine; //+ ConvertToNumeric(strCapture);
                ux_txtReceivedData.SelectionStart = ux_txtReceivedData.Text.Length;
                ux_txtReceivedData.ScrollToCaret();
            };

            //gui controls need to have their methods called within thier own threads
            if (ux_txtReceivedData.InvokeRequired)
            {

                ux_txtReceivedData.Invoke(del);
            }
            else
            {
                del.Invoke();
            }

        }

        private string ConvertToNumeric(string strCapture)
        {
            //int i;
            StringBuilder strOutput = new StringBuilder();

            foreach (char ch in strCapture)
            {

                strOutput.Append(ch.ToString() + ": " + (int)ch + Environment.NewLine);

            }

            return strOutput.ToString() + Environment.NewLine;

        }


        private void EndCapture()
        {
            _srlCapture.Close();
        }


        private void Main_Load(object sender, EventArgs e)
        {
            Array arrPorts = System.IO.Ports.SerialPort.GetPortNames();
            Array.Sort(arrPorts);
            ux_cmbInputPort.DataSource = arrPorts;
            foreach (var control in Controls)
            {
                if (control is ucCamera)
                {
                    _cameraControllers.Add((ucCamera)control);
                }
            }

            foreach (var camera in _cameraControllers)
            {
                camera.BecameActive += new EventHandler(camera_Active);
            }

        }

        void camera_Active(object sender, EventArgs e)
        {
            foreach (var camera in _cameraControllers)
            {
                if (camera != sender)
                {
                    camera.Active = false;
                }
                else
                {
                    _activeCamera = camera;
                }
            }
        }

        private void ux_btnSend_Click(object sender, EventArgs e)
        {

            if (ux_chkConvertFromHex.Checked)
            {
                List<byte> sendBytes = new List<byte>();
                //StringBuilder sendString = new StringBuilder(16);
                string workingString = CameraController.Common.StripSpaces(ux_txtSendData.Text);
                for (int i = 0; i < workingString.Length; )
                {
                    //sendString.Append(
                    //sendString.Append(((sbyte)(Convert.ToSByte(workingString.Substring(i, 2), 16))));
                    sendBytes.Add(Convert.ToByte(workingString.Substring(i, 2), 16));
                    i += 2;
                }
                _srlCapture.Write(sendBytes.ToArray(), 0, sendBytes.Count); //+ Environment.NewLine);

            }
            else
            {
                //srlOutput.CtsHolding
                _srlCapture.Write(ux_txtSendData.Text + Environment.NewLine);
                //MessageBox.Show(srlOutput.BytesToWrite.ToString());

            }
            //ux_txtSendData.Text = "";

        }

        private void ucCamera1_SendHistory(object sender, CameraController.ucCamera.CameraEventArgs e)
        {
            AddHistory(e.Message);
        }

        delegate void MessageDelegate(string message);

        private void AddHistory(string message)
        {
            if (ux_txtSendHistory.InvokeRequired)
            {
                //invoke self on the thread owning this control
                MessageDelegate del = new MessageDelegate(AddHistory);
                ux_txtSendHistory.Invoke(del, message);
            }
            else
            {
                ux_txtSendHistory.AppendText(message + Environment.NewLine);
            }

        }

        private void Main_KeyDown(object sender, KeyEventArgs e)
        {

            Debug.Print("KeyDown on Main " + e.KeyValue);

            if (_activeCamera != null)
            {
                _activeCamera.SendKeyDown(e);
                e.SuppressKeyPress = true;
            }
        }


        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Up || keyData == Keys.Down ||
                keyData == Keys.Left || keyData == Keys.Right)
            {
                Debug.Print("ProcessCmdKey " + msg.Msg.ToString());
                Main_KeyDown(this, new KeyEventArgs(keyData));
                return false; 
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void Main_KeyUp(object sender, KeyEventArgs e)
        {
            Debug.Print("Main_KeyUp " + e.KeyValue);
            if (_activeCamera != null)
            {
                _activeCamera.SendKeyUp(e);
                e.SuppressKeyPress = true;
            }
        }


        //private void ux_btnOn_Click(object sender, EventArgs e)
        //{
        //    srlCapture.DtrEnable = true;
        //    srlCapture.RtsEnable = true;
        //}

        //private void ux_btnOff_Click(object sender, EventArgs e)
        //{
        //    srlCapture.DtrEnable = false;
        //    srlCapture.RtsEnable = false;
        //}





    }
}