namespace CameraController
{
    partial class ucCamera
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ux_btnLeft = new System.Windows.Forms.Button();
            this.ux_btnDown = new System.Windows.Forms.Button();
            this.ux_btnUp = new System.Windows.Forms.Button();
            this.ux_btnRight = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ux_Zoom = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.ux_cmbCameraNumber = new System.Windows.Forms.ComboBox();
            this.ux_udSpeed = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.ux_udStepSpeed = new System.Windows.Forms.NumericUpDown();
            this.ux_btnHome = new System.Windows.Forms.Button();
            this.ux_btnZoomOut = new System.Windows.Forms.Button();
            this.ux_btnZoomIn = new System.Windows.Forms.Button();
            this.ux_udZoomSpeed = new System.Windows.Forms.NumericUpDown();
            this.ux_btnPreset1 = new System.Windows.Forms.Button();
            this.ux_btnPreset2 = new System.Windows.Forms.Button();
            this.ux_btnPreset3 = new System.Windows.Forms.Button();
            this.ux_btnPreset4 = new System.Windows.Forms.Button();
            this.ux_btnPreset5 = new System.Windows.Forms.Button();
            this.ux_btnPreset6 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.ux_chkAutoFocus = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ux_chkAutoBrightness = new System.Windows.Forms.CheckBox();
            this.ux_btnBrightPlus = new System.Windows.Forms.Button();
            this.ux_btnBrightMinus = new System.Windows.Forms.Button();
            this.ux_chkActive = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.ux_Zoom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ux_udSpeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ux_udStepSpeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ux_udZoomSpeed)).BeginInit();
            this.SuspendLayout();
            // 
            // ux_btnLeft
            // 
            this.ux_btnLeft.Location = new System.Drawing.Point(126, 107);
            this.ux_btnLeft.Name = "ux_btnLeft";
            this.ux_btnLeft.Size = new System.Drawing.Size(75, 23);
            this.ux_btnLeft.TabIndex = 19;
            this.ux_btnLeft.Text = "Left";
            this.ux_btnLeft.UseVisualStyleBackColor = true;
            this.ux_btnLeft.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ux_btnLeft_MouseDown);
            this.ux_btnLeft.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ux_btnLeft_MouseUp);
            // 
            // ux_btnDown
            // 
            this.ux_btnDown.Location = new System.Drawing.Point(206, 136);
            this.ux_btnDown.Name = "ux_btnDown";
            this.ux_btnDown.Size = new System.Drawing.Size(75, 23);
            this.ux_btnDown.TabIndex = 20;
            this.ux_btnDown.Text = "Down";
            this.ux_btnDown.UseVisualStyleBackColor = true;
            this.ux_btnDown.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ux_btnDown_MouseDown);
            this.ux_btnDown.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ux_btnDown_MouseUp);
            // 
            // ux_btnUp
            // 
            this.ux_btnUp.Location = new System.Drawing.Point(206, 78);
            this.ux_btnUp.Name = "ux_btnUp";
            this.ux_btnUp.Size = new System.Drawing.Size(75, 23);
            this.ux_btnUp.TabIndex = 18;
            this.ux_btnUp.Text = "Up";
            this.ux_btnUp.UseVisualStyleBackColor = true;
            this.ux_btnUp.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ux_btnUp_MouseDown);
            this.ux_btnUp.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ux_btnUp_MouseUp);
            // 
            // ux_btnRight
            // 
            this.ux_btnRight.Location = new System.Drawing.Point(287, 107);
            this.ux_btnRight.Name = "ux_btnRight";
            this.ux_btnRight.Size = new System.Drawing.Size(75, 23);
            this.ux_btnRight.TabIndex = 21;
            this.ux_btnRight.Text = "Right";
            this.ux_btnRight.UseVisualStyleBackColor = true;
            this.ux_btnRight.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ux_btnRight_MouseDown);
            this.ux_btnRight.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ux_btnRight_MouseUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Zoom";
            // 
            // ux_Zoom
            // 
            this.ux_Zoom.Location = new System.Drawing.Point(18, 63);
            this.ux_Zoom.Maximum = 17000;
            this.ux_Zoom.Name = "ux_Zoom";
            this.ux_Zoom.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.ux_Zoom.Size = new System.Drawing.Size(45, 104);
            this.ux_Zoom.TabIndex = 14;
            this.ux_Zoom.TickStyle = System.Windows.Forms.TickStyle.None;
            this.ux_Zoom.ValueChanged += new System.EventHandler(this.ux_Zoom_ValueChanged);
            this.ux_Zoom.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ux_Zoom_KeyDown);
            this.ux_Zoom.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ux_Zoom_KeyPress);
            this.ux_Zoom.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ux_Zoom_MouseUp);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(252, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "Pan Speed";
            // 
            // ux_cmbCameraNumber
            // 
            this.ux_cmbCameraNumber.FormattingEnabled = true;
            this.ux_cmbCameraNumber.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7"});
            this.ux_cmbCameraNumber.Location = new System.Drawing.Point(18, 8);
            this.ux_cmbCameraNumber.Name = "ux_cmbCameraNumber";
            this.ux_cmbCameraNumber.Size = new System.Drawing.Size(121, 21);
            this.ux_cmbCameraNumber.TabIndex = 17;
            this.ux_cmbCameraNumber.Text = "1";
            // 
            // ux_udSpeed
            // 
            this.ux_udSpeed.Location = new System.Drawing.Point(318, 48);
            this.ux_udSpeed.Maximum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.ux_udSpeed.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ux_udSpeed.Name = "ux_udSpeed";
            this.ux_udSpeed.Size = new System.Drawing.Size(54, 20);
            this.ux_udSpeed.TabIndex = 24;
            this.ux_udSpeed.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(123, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 25;
            this.label3.Text = "Step Speed";
            // 
            // ux_udStepSpeed
            // 
            this.ux_udStepSpeed.Location = new System.Drawing.Point(192, 48);
            this.ux_udStepSpeed.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ux_udStepSpeed.Name = "ux_udStepSpeed";
            this.ux_udStepSpeed.Size = new System.Drawing.Size(54, 20);
            this.ux_udStepSpeed.TabIndex = 26;
            this.ux_udStepSpeed.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // ux_btnHome
            // 
            this.ux_btnHome.Location = new System.Drawing.Point(206, 107);
            this.ux_btnHome.Name = "ux_btnHome";
            this.ux_btnHome.Size = new System.Drawing.Size(75, 23);
            this.ux_btnHome.TabIndex = 27;
            this.ux_btnHome.Text = "Home";
            this.ux_btnHome.UseVisualStyleBackColor = true;
            this.ux_btnHome.Click += new System.EventHandler(this.ux_btnHome_Click);
            // 
            // ux_btnZoomOut
            // 
            this.ux_btnZoomOut.Location = new System.Drawing.Point(5, 170);
            this.ux_btnZoomOut.Name = "ux_btnZoomOut";
            this.ux_btnZoomOut.Size = new System.Drawing.Size(20, 20);
            this.ux_btnZoomOut.TabIndex = 28;
            this.ux_btnZoomOut.Text = "-";
            this.ux_btnZoomOut.UseVisualStyleBackColor = true;
            this.ux_btnZoomOut.Click += new System.EventHandler(this.ux_btnZoomOut_Click);
            // 
            // ux_btnZoomIn
            // 
            this.ux_btnZoomIn.Location = new System.Drawing.Point(29, 170);
            this.ux_btnZoomIn.Name = "ux_btnZoomIn";
            this.ux_btnZoomIn.Size = new System.Drawing.Size(20, 20);
            this.ux_btnZoomIn.TabIndex = 29;
            this.ux_btnZoomIn.Text = "+";
            this.ux_btnZoomIn.UseVisualStyleBackColor = true;
            this.ux_btnZoomIn.Click += new System.EventHandler(this.ux_btnZoomIn_Click);
            // 
            // ux_udZoomSpeed
            // 
            this.ux_udZoomSpeed.Location = new System.Drawing.Point(3, 192);
            this.ux_udZoomSpeed.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.ux_udZoomSpeed.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ux_udZoomSpeed.Name = "ux_udZoomSpeed";
            this.ux_udZoomSpeed.Size = new System.Drawing.Size(54, 20);
            this.ux_udZoomSpeed.TabIndex = 30;
            this.ux_udZoomSpeed.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // ux_btnPreset1
            // 
            this.ux_btnPreset1.Location = new System.Drawing.Point(378, 25);
            this.ux_btnPreset1.Name = "ux_btnPreset1";
            this.ux_btnPreset1.Size = new System.Drawing.Size(75, 23);
            this.ux_btnPreset1.TabIndex = 31;
            this.ux_btnPreset1.Tag = "1";
            this.ux_btnPreset1.Text = "Preset 1";
            this.ux_btnPreset1.UseVisualStyleBackColor = true;
            this.ux_btnPreset1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ux_btnPreset_MouseUp);
            // 
            // ux_btnPreset2
            // 
            this.ux_btnPreset2.Location = new System.Drawing.Point(378, 54);
            this.ux_btnPreset2.Name = "ux_btnPreset2";
            this.ux_btnPreset2.Size = new System.Drawing.Size(75, 23);
            this.ux_btnPreset2.TabIndex = 32;
            this.ux_btnPreset2.Tag = "2";
            this.ux_btnPreset2.Text = "Preset 2";
            this.ux_btnPreset2.UseVisualStyleBackColor = true;
            this.ux_btnPreset2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ux_btnPreset_MouseUp);
            // 
            // ux_btnPreset3
            // 
            this.ux_btnPreset3.Location = new System.Drawing.Point(378, 83);
            this.ux_btnPreset3.Name = "ux_btnPreset3";
            this.ux_btnPreset3.Size = new System.Drawing.Size(75, 23);
            this.ux_btnPreset3.TabIndex = 33;
            this.ux_btnPreset3.Tag = "3";
            this.ux_btnPreset3.Text = "Preset 3";
            this.ux_btnPreset3.UseVisualStyleBackColor = true;
            this.ux_btnPreset3.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ux_btnPreset_MouseUp);
            // 
            // ux_btnPreset4
            // 
            this.ux_btnPreset4.Location = new System.Drawing.Point(378, 112);
            this.ux_btnPreset4.Name = "ux_btnPreset4";
            this.ux_btnPreset4.Size = new System.Drawing.Size(75, 23);
            this.ux_btnPreset4.TabIndex = 34;
            this.ux_btnPreset4.Tag = "4";
            this.ux_btnPreset4.Text = "Preset 4";
            this.ux_btnPreset4.UseVisualStyleBackColor = true;
            this.ux_btnPreset4.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ux_btnPreset_MouseUp);
            // 
            // ux_btnPreset5
            // 
            this.ux_btnPreset5.Location = new System.Drawing.Point(378, 141);
            this.ux_btnPreset5.Name = "ux_btnPreset5";
            this.ux_btnPreset5.Size = new System.Drawing.Size(75, 23);
            this.ux_btnPreset5.TabIndex = 35;
            this.ux_btnPreset5.Tag = "5";
            this.ux_btnPreset5.Text = "Preset 5";
            this.ux_btnPreset5.UseVisualStyleBackColor = true;
            this.ux_btnPreset5.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ux_btnPreset_MouseUp);
            // 
            // ux_btnPreset6
            // 
            this.ux_btnPreset6.Location = new System.Drawing.Point(378, 170);
            this.ux_btnPreset6.Name = "ux_btnPreset6";
            this.ux_btnPreset6.Size = new System.Drawing.Size(75, 23);
            this.ux_btnPreset6.TabIndex = 36;
            this.ux_btnPreset6.Tag = "6";
            this.ux_btnPreset6.Text = "Preset 6";
            this.ux_btnPreset6.UseVisualStyleBackColor = true;
            this.ux_btnPreset6.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ux_btnPreset_MouseUp);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(391, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 37;
            this.label4.Text = "Presets";
            // 
            // ux_chkAutoFocus
            // 
            this.ux_chkAutoFocus.AutoSize = true;
            this.ux_chkAutoFocus.Location = new System.Drawing.Point(206, 174);
            this.ux_chkAutoFocus.Name = "ux_chkAutoFocus";
            this.ux_chkAutoFocus.Size = new System.Drawing.Size(80, 17);
            this.ux_chkAutoFocus.TabIndex = 39;
            this.ux_chkAutoFocus.Text = "Auto Focus";
            this.ux_chkAutoFocus.UseVisualStyleBackColor = true;
            this.ux_chkAutoFocus.CheckedChanged += new System.EventHandler(this.ux_chkAutoFocus_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(62, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 41;
            this.label5.Text = "Brightness";
            // 
            // ux_chkAutoBrightness
            // 
            this.ux_chkAutoBrightness.AutoSize = true;
            this.ux_chkAutoBrightness.Checked = true;
            this.ux_chkAutoBrightness.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ux_chkAutoBrightness.Location = new System.Drawing.Point(65, 63);
            this.ux_chkAutoBrightness.Name = "ux_chkAutoBrightness";
            this.ux_chkAutoBrightness.Size = new System.Drawing.Size(48, 17);
            this.ux_chkAutoBrightness.TabIndex = 42;
            this.ux_chkAutoBrightness.Text = "Auto";
            this.ux_chkAutoBrightness.UseVisualStyleBackColor = true;
            this.ux_chkAutoBrightness.CheckedChanged += new System.EventHandler(this.ux_chkAutoBrightness_CheckedChanged);
            // 
            // ux_btnBrightPlus
            // 
            this.ux_btnBrightPlus.Location = new System.Drawing.Point(89, 84);
            this.ux_btnBrightPlus.Name = "ux_btnBrightPlus";
            this.ux_btnBrightPlus.Size = new System.Drawing.Size(20, 20);
            this.ux_btnBrightPlus.TabIndex = 44;
            this.ux_btnBrightPlus.Text = "+";
            this.ux_btnBrightPlus.UseVisualStyleBackColor = true;
            this.ux_btnBrightPlus.Click += new System.EventHandler(this.ux_btnBrightPlus_Click);
            // 
            // ux_btnBrightMinus
            // 
            this.ux_btnBrightMinus.Location = new System.Drawing.Point(65, 84);
            this.ux_btnBrightMinus.Name = "ux_btnBrightMinus";
            this.ux_btnBrightMinus.Size = new System.Drawing.Size(20, 20);
            this.ux_btnBrightMinus.TabIndex = 43;
            this.ux_btnBrightMinus.Text = "-";
            this.ux_btnBrightMinus.UseVisualStyleBackColor = true;
            this.ux_btnBrightMinus.Click += new System.EventHandler(this.ux_btnBrightMinus_Click);
            // 
            // ux_chkActive
            // 
            this.ux_chkActive.AutoSize = true;
            this.ux_chkActive.Location = new System.Drawing.Point(192, 10);
            this.ux_chkActive.Name = "ux_chkActive";
            this.ux_chkActive.Size = new System.Drawing.Size(56, 17);
            this.ux_chkActive.TabIndex = 45;
            this.ux_chkActive.Text = "Active";
            this.ux_chkActive.UseVisualStyleBackColor = true;
            this.ux_chkActive.CheckedChanged += new System.EventHandler(this.ux_chkActive_CheckedChanged);
            // 
            // ucCamera
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ux_chkActive);
            this.Controls.Add(this.ux_btnBrightPlus);
            this.Controls.Add(this.ux_btnBrightMinus);
            this.Controls.Add(this.ux_chkAutoBrightness);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ux_chkAutoFocus);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ux_btnPreset6);
            this.Controls.Add(this.ux_btnPreset5);
            this.Controls.Add(this.ux_btnPreset4);
            this.Controls.Add(this.ux_btnPreset3);
            this.Controls.Add(this.ux_btnPreset2);
            this.Controls.Add(this.ux_btnPreset1);
            this.Controls.Add(this.ux_udZoomSpeed);
            this.Controls.Add(this.ux_btnZoomIn);
            this.Controls.Add(this.ux_btnRight);
            this.Controls.Add(this.ux_btnZoomOut);
            this.Controls.Add(this.ux_btnLeft);
            this.Controls.Add(this.ux_btnHome);
            this.Controls.Add(this.ux_btnDown);
            this.Controls.Add(this.ux_udStepSpeed);
            this.Controls.Add(this.ux_btnUp);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ux_udSpeed);
            this.Controls.Add(this.ux_Zoom);
            this.Controls.Add(this.ux_cmbCameraNumber);
            this.Controls.Add(this.label2);
            this.Name = "ucCamera";
            this.Size = new System.Drawing.Size(462, 221);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ucCamera_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ucCamera_KeyPress);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ucCamera_KeyUp);
            this.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.ucCamera_PreviewKeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.ux_Zoom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ux_udSpeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ux_udStepSpeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ux_udZoomSpeed)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ux_btnLeft;
        private System.Windows.Forms.Button ux_btnDown;
        private System.Windows.Forms.Button ux_btnUp;
        private System.Windows.Forms.Button ux_btnRight;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar ux_Zoom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox ux_cmbCameraNumber;
        private System.Windows.Forms.NumericUpDown ux_udSpeed;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown ux_udStepSpeed;
        private System.Windows.Forms.Button ux_btnHome;
        private System.Windows.Forms.Button ux_btnZoomOut;
        private System.Windows.Forms.Button ux_btnZoomIn;
        private System.Windows.Forms.NumericUpDown ux_udZoomSpeed;
        private System.Windows.Forms.Button ux_btnPreset1;
        private System.Windows.Forms.Button ux_btnPreset2;
        private System.Windows.Forms.Button ux_btnPreset3;
        private System.Windows.Forms.Button ux_btnPreset4;
        private System.Windows.Forms.Button ux_btnPreset5;
        private System.Windows.Forms.Button ux_btnPreset6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox ux_chkAutoFocus;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox ux_chkAutoBrightness;
        private System.Windows.Forms.Button ux_btnBrightPlus;
        private System.Windows.Forms.Button ux_btnBrightMinus;
        private System.Windows.Forms.CheckBox ux_chkActive;


    }
}
