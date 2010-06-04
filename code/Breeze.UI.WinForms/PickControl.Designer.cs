namespace Breeze.UI.WinForms
{
    partial class PickControl
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
            this.connectedController1 = new Breeze.UI.WinForms.ConnectedController();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // connectedController1
            // 
            this.connectedController1.Location = new System.Drawing.Point(3, 3);
            this.connectedController1.Name = "connectedController1";
            this.connectedController1.Size = new System.Drawing.Size(490, 273);
            this.connectedController1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 197);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Pack 1";
            // 
            // PickControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.connectedController1);
            this.Name = "PickControl";
            this.Size = new System.Drawing.Size(661, 492);
            this.Load += new System.EventHandler(this.PickControl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ConnectedController connectedController1;
        private System.Windows.Forms.Label label1;
    }
}
