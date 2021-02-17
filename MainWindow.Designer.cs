
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
            this.mainPanel = new System.Windows.Forms.Panel();
            this.bunnyHopCheckbox = new System.Windows.Forms.CheckBox();
            this.wallHackCheckbox = new System.Windows.Forms.CheckBox();
            this.antiFlashCheckbox = new System.Windows.Forms.CheckBox();
            this.creditLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.mainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.Controls.Add(this.bunnyHopCheckbox);
            this.mainPanel.Controls.Add(this.wallHackCheckbox);
            this.mainPanel.Controls.Add(this.antiFlashCheckbox);
            this.mainPanel.Location = new System.Drawing.Point(12, 45);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(186, 105);
            this.mainPanel.TabIndex = 1;
            // 
            // bunnyHopCheckbox
            // 
            this.bunnyHopCheckbox.AutoSize = true;
            this.bunnyHopCheckbox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunnyHopCheckbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bunnyHopCheckbox.ForeColor = System.Drawing.Color.Lime;
            this.bunnyHopCheckbox.Location = new System.Drawing.Point(30, 71);
            this.bunnyHopCheckbox.Name = "bunnyHopCheckbox";
            this.bunnyHopCheckbox.Size = new System.Drawing.Size(125, 28);
            this.bunnyHopCheckbox.TabIndex = 2;
            this.bunnyHopCheckbox.Text = "Bunny-Hop";
            this.bunnyHopCheckbox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunnyHopCheckbox.UseVisualStyleBackColor = true;
            this.bunnyHopCheckbox.CheckedChanged += new System.EventHandler(this.bunnyHopCheckbox_CheckedChanged);
            // 
            // wallHackCheckbox
            // 
            this.wallHackCheckbox.AutoSize = true;
            this.wallHackCheckbox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.wallHackCheckbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.wallHackCheckbox.ForeColor = System.Drawing.Color.Lime;
            this.wallHackCheckbox.Location = new System.Drawing.Point(30, 37);
            this.wallHackCheckbox.Name = "wallHackCheckbox";
            this.wallHackCheckbox.Size = new System.Drawing.Size(114, 28);
            this.wallHackCheckbox.TabIndex = 1;
            this.wallHackCheckbox.Text = "Wall-Hack";
            this.wallHackCheckbox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.wallHackCheckbox.UseVisualStyleBackColor = true;
            this.wallHackCheckbox.CheckedChanged += new System.EventHandler(this.wallHackCheckbox_CheckedChanged);
            // 
            // antiFlashCheckbox
            // 
            this.antiFlashCheckbox.AutoSize = true;
            this.antiFlashCheckbox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.antiFlashCheckbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.antiFlashCheckbox.ForeColor = System.Drawing.Color.Lime;
            this.antiFlashCheckbox.Location = new System.Drawing.Point(30, 3);
            this.antiFlashCheckbox.Name = "antiFlashCheckbox";
            this.antiFlashCheckbox.Size = new System.Drawing.Size(113, 28);
            this.antiFlashCheckbox.TabIndex = 0;
            this.antiFlashCheckbox.Text = "Anti-Flash";
            this.antiFlashCheckbox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.antiFlashCheckbox.UseVisualStyleBackColor = true;
            this.antiFlashCheckbox.CheckedChanged += new System.EventHandler(this.antiFlashCheckbox_CheckedChanged);
            // 
            // creditLabel
            // 
            this.creditLabel.AutoSize = true;
            this.creditLabel.Cursor = System.Windows.Forms.Cursors.No;
            this.creditLabel.Font = new System.Drawing.Font("Unispace", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.creditLabel.ForeColor = System.Drawing.Color.Lime;
            this.creditLabel.Location = new System.Drawing.Point(36, 168);
            this.creditLabel.Name = "creditLabel";
            this.creditLabel.Size = new System.Drawing.Size(131, 21);
            this.creditLabel.TabIndex = 2;
            this.creditLabel.Text = "By Lukyynn_";
            this.creditLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Cursor = System.Windows.Forms.Cursors.No;
            this.label2.Font = new System.Drawing.Font("Unispace", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.Lime;
            this.label2.Location = new System.Drawing.Point(8, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(190, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "CSGO: MultiHack";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InfoText;
            this.ClientSize = new System.Drawing.Size(210, 198);
            this.Controls.Add(this.creditLabel);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.label2);
            this.Cursor = System.Windows.Forms.Cursors.No;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainWindow";
            this.Text = "MultiHack";
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.CheckBox antiFlashCheckbox;
        private System.Windows.Forms.CheckBox bunnyHopCheckbox;
        private System.Windows.Forms.CheckBox wallHackCheckbox;
        private System.Windows.Forms.Label creditLabel;
        private System.Windows.Forms.Label label2;
    }
}