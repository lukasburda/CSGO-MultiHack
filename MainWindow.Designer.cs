
namespace CSGOHack
{
    partial class MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.hacksInfo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // hacksInfo
            // 
            this.hacksInfo.AutoSize = true;
            this.hacksInfo.Cursor = System.Windows.Forms.Cursors.No;
            this.hacksInfo.Font = new System.Drawing.Font("Righteous", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hacksInfo.ForeColor = System.Drawing.Color.Lime;
            this.hacksInfo.Location = new System.Drawing.Point(13, 9);
            this.hacksInfo.Name = "hacksInfo";
            this.hacksInfo.Size = new System.Drawing.Size(282, 37);
            this.hacksInfo.TabIndex = 0;
            this.hacksInfo.Text = "HACKS ACTIVATED!";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InfoText;
            this.ClientSize = new System.Drawing.Size(307, 61);
            this.Controls.Add(this.hacksInfo);
            this.Cursor = System.Windows.Forms.Cursors.No;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainWindow";
            this.Text = "CSGO: Hacks by Lukyynn_";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label hacksInfo;
    }
}