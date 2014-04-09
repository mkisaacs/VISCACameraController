namespace CameraController
{
    partial class SetLabel
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
            this.label1 = new System.Windows.Forms.Label();
            this.ux_txtLabel = new System.Windows.Forms.TextBox();
            this.ux_btnOK = new System.Windows.Forms.Button();
            this.ux_btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Label";
            // 
            // ux_txtLabel
            // 
            this.ux_txtLabel.Location = new System.Drawing.Point(50, 0);
            this.ux_txtLabel.Name = "ux_txtLabel";
            this.ux_txtLabel.Size = new System.Drawing.Size(77, 20);
            this.ux_txtLabel.TabIndex = 1;
            // 
            // ux_btnOK
            // 
            this.ux_btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.ux_btnOK.Location = new System.Drawing.Point(133, 0);
            this.ux_btnOK.Name = "ux_btnOK";
            this.ux_btnOK.Size = new System.Drawing.Size(31, 23);
            this.ux_btnOK.TabIndex = 2;
            this.ux_btnOK.Text = "OK";
            this.ux_btnOK.UseVisualStyleBackColor = true;
            // 
            // ux_btnCancel
            // 
            this.ux_btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ux_btnCancel.Location = new System.Drawing.Point(170, 0);
            this.ux_btnCancel.Name = "ux_btnCancel";
            this.ux_btnCancel.Size = new System.Drawing.Size(57, 23);
            this.ux_btnCancel.TabIndex = 3;
            this.ux_btnCancel.Text = "Cancel";
            this.ux_btnCancel.UseVisualStyleBackColor = true;
            this.ux_btnCancel.Click += new System.EventHandler(this.ux_btnCancel_Click);
            // 
            // SetLabel
            // 
            this.AcceptButton = this.ux_btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.ux_btnCancel;
            this.ClientSize = new System.Drawing.Size(259, 25);
            this.Controls.Add(this.ux_btnCancel);
            this.Controls.Add(this.ux_btnOK);
            this.Controls.Add(this.ux_txtLabel);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "SetLabel";
            this.Text = "SetLabel";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ux_txtLabel;
        private System.Windows.Forms.Button ux_btnOK;
        private System.Windows.Forms.Button ux_btnCancel;
    }
}