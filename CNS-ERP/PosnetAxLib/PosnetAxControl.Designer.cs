using AxPosnetLib;

namespace PosnetAxLib
{
    partial class PosnetAxControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PosnetAxControl));
            this.axPosnetLib1 = new AxPosnetLib.AxPosnetLib();
            ((System.ComponentModel.ISupportInitialize)(this.axPosnetLib1)).BeginInit();
            this.SuspendLayout();
            // 
            // axPosnetLib1
            // 
            this.axPosnetLib1.Enabled = true;
            this.axPosnetLib1.Location = new System.Drawing.Point(3, 39);
            this.axPosnetLib1.Name = "axPosnetLib1";
            this.axPosnetLib1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axPosnetLib1.OcxState")));
            this.axPosnetLib1.Size = new System.Drawing.Size(100, 50);
            this.axPosnetLib1.TabIndex = 0;
            // 
            // PosnetAxControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.axPosnetLib1);
            this.Name = "PosnetAxControl";
            ((System.ComponentModel.ISupportInitialize)(this.axPosnetLib1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AxPosnetLib.AxPosnetLib axPosnetLib1;
    }
}
