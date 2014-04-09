namespace CameraController
{

    /// <summary>
    /// Main form for this application
    /// </summary>
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ux_btnCapture = new System.Windows.Forms.Button();
            this.ux_txtReceivedData = new System.Windows.Forms.TextBox();
            this.ux_lblInputPort = new System.Windows.Forms.Label();
            this.ux_cmbInputPort = new System.Windows.Forms.ComboBox();
            this.ux_txtSendData = new System.Windows.Forms.TextBox();
            this.ux_btnSend = new System.Windows.Forms.Button();
            this.ux_chkConvertFromHex = new System.Windows.Forms.CheckBox();
            this.ux_txtSendHistory = new System.Windows.Forms.TextBox();
            this.ucCamera2 = new CameraController.ucCamera();
            this.ucCamera1 = new CameraController.ucCamera();
            this.SuspendLayout();
            // 
            // ux_btnCapture
            // 
            this.ux_btnCapture.Location = new System.Drawing.Point(192, 13);
            this.ux_btnCapture.Name = "ux_btnCapture";
            this.ux_btnCapture.Size = new System.Drawing.Size(75, 23);
            this.ux_btnCapture.TabIndex = 0;
            this.ux_btnCapture.Text = "Capture";
            this.ux_btnCapture.UseVisualStyleBackColor = true;
            this.ux_btnCapture.Click += new System.EventHandler(this.btnCapture_Click);
            // 
            // ux_txtReceivedData
            // 
            this.ux_txtReceivedData.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ux_txtReceivedData.Location = new System.Drawing.Point(12, 274);
            this.ux_txtReceivedData.Multiline = true;
            this.ux_txtReceivedData.Name = "ux_txtReceivedData";
            this.ux_txtReceivedData.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ux_txtReceivedData.Size = new System.Drawing.Size(272, 125);
            this.ux_txtReceivedData.TabIndex = 1;
            // 
            // ux_lblInputPort
            // 
            this.ux_lblInputPort.AutoSize = true;
            this.ux_lblInputPort.Location = new System.Drawing.Point(12, 18);
            this.ux_lblInputPort.Name = "ux_lblInputPort";
            this.ux_lblInputPort.Size = new System.Drawing.Size(53, 13);
            this.ux_lblInputPort.TabIndex = 3;
            this.ux_lblInputPort.Text = "Input Port";
            // 
            // ux_cmbInputPort
            // 
            this.ux_cmbInputPort.FormattingEnabled = true;
            this.ux_cmbInputPort.Location = new System.Drawing.Point(65, 15);
            this.ux_cmbInputPort.Name = "ux_cmbInputPort";
            this.ux_cmbInputPort.Size = new System.Drawing.Size(121, 21);
            this.ux_cmbInputPort.TabIndex = 4;
            // 
            // ux_txtSendData
            // 
            this.ux_txtSendData.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.ux_txtSendData.Location = new System.Drawing.Point(12, 405);
            this.ux_txtSendData.Multiline = true;
            this.ux_txtSendData.Name = "ux_txtSendData";
            this.ux_txtSendData.Size = new System.Drawing.Size(960, 137);
            this.ux_txtSendData.TabIndex = 8;
            // 
            // ux_btnSend
            // 
            this.ux_btnSend.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ux_btnSend.Location = new System.Drawing.Point(897, 553);
            this.ux_btnSend.Name = "ux_btnSend";
            this.ux_btnSend.Size = new System.Drawing.Size(75, 23);
            this.ux_btnSend.TabIndex = 9;
            this.ux_btnSend.Text = "Send";
            this.ux_btnSend.UseVisualStyleBackColor = true;
            this.ux_btnSend.Click += new System.EventHandler(this.ux_btnSend_Click);
            // 
            // ux_chkConvertFromHex
            // 
            this.ux_chkConvertFromHex.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ux_chkConvertFromHex.AutoSize = true;
            this.ux_chkConvertFromHex.Checked = true;
            this.ux_chkConvertFromHex.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ux_chkConvertFromHex.Location = new System.Drawing.Point(865, 382);
            this.ux_chkConvertFromHex.Name = "ux_chkConvertFromHex";
            this.ux_chkConvertFromHex.Size = new System.Drawing.Size(108, 17);
            this.ux_chkConvertFromHex.TabIndex = 13;
            this.ux_chkConvertFromHex.Text = "Convert from Hex";
            this.ux_chkConvertFromHex.UseVisualStyleBackColor = true;
            // 
            // ux_txtSendHistory
            // 
            this.ux_txtSendHistory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ux_txtSendHistory.Location = new System.Drawing.Point(293, 274);
            this.ux_txtSendHistory.Multiline = true;
            this.ux_txtSendHistory.Name = "ux_txtSendHistory";
            this.ux_txtSendHistory.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ux_txtSendHistory.Size = new System.Drawing.Size(289, 125);
            this.ux_txtSendHistory.TabIndex = 16;
            // 
            // ucCamera2
            // 
            this.ucCamera2.Active = false;
            this.ucCamera2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ucCamera2.CameraNumber = 2;
            this.ucCamera2.Location = new System.Drawing.Point(490, 42);
            this.ucCamera2.Name = "ucCamera2";
            this.ucCamera2.SerialCapturePort = null;
            this.ucCamera2.Size = new System.Drawing.Size(466, 223);
            this.ucCamera2.TabIndex = 26;
            // 
            // ucCamera1
            // 
            this.ucCamera1.Active = false;
            this.ucCamera1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ucCamera1.CameraNumber = 1;
            this.ucCamera1.Location = new System.Drawing.Point(12, 42);
            this.ucCamera1.Name = "ucCamera1";
            this.ucCamera1.SerialCapturePort = null;
            this.ucCamera1.Size = new System.Drawing.Size(472, 223);
            this.ucCamera1.TabIndex = 25;
            this.ucCamera1.SendHistory += new System.EventHandler<CameraController.ucCamera.CameraEventArgs>(this.ucCamera1_SendHistory);
            // 
            // Main
            // 
            this.AcceptButton = this.ux_btnSend;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 588);
            this.Controls.Add(this.ucCamera2);
            this.Controls.Add(this.ucCamera1);
            this.Controls.Add(this.ux_txtSendHistory);
            this.Controls.Add(this.ux_chkConvertFromHex);
            this.Controls.Add(this.ux_btnSend);
            this.Controls.Add(this.ux_txtSendData);
            this.Controls.Add(this.ux_cmbInputPort);
            this.Controls.Add(this.ux_lblInputPort);
            this.Controls.Add(this.ux_txtReceivedData);
            this.Controls.Add(this.ux_btnCapture);
            this.KeyPreview = true;
            this.Name = "Main";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Main_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Main_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Main_KeyUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ux_btnCapture;
        private System.Windows.Forms.TextBox ux_txtReceivedData;
        private System.Windows.Forms.Label ux_lblInputPort;
        private System.Windows.Forms.ComboBox ux_cmbInputPort;
        private System.Windows.Forms.TextBox ux_txtSendData;
        private System.Windows.Forms.Button ux_btnSend;
        private System.Windows.Forms.CheckBox ux_chkConvertFromHex;
        private System.Windows.Forms.TextBox ux_txtSendHistory;
        private CameraController.ucCamera ucCamera1;
        private CameraController.ucCamera ucCamera2;
    }
}

