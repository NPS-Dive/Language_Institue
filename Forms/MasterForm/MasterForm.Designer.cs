namespace MainProject.Forms.MasterForm
    {
    partial class MasterForm
        {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose ( bool disposing )
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
        private void InitializeComponent ()
            {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MasterForm));
            pnlMaster = new Panel();
            lblFormName = new Label();
            picExit = new PictureBox();
            panel1 = new Panel();
            pnlMaster.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picExit).BeginInit();
            SuspendLayout();
            // 
            // pnlMaster
            // 
            pnlMaster.BackColor = Color.FromArgb(192, 255, 192);
            pnlMaster.Controls.Add(lblFormName);
            pnlMaster.Controls.Add(picExit);
            pnlMaster.Dock = DockStyle.Top;
            pnlMaster.Location = new Point(0, 0);
            pnlMaster.Margin = new Padding(4);
            pnlMaster.Name = "pnlMaster";
            pnlMaster.Size = new Size(774, 54);
            pnlMaster.TabIndex = 0;
            // 
            // lblFormName
            // 
            lblFormName.AutoSize = true;
            lblFormName.BackColor = Color.FromArgb(255, 255, 192);
            lblFormName.Font = new Font("Tahoma", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblFormName.Location = new Point(278, 12);
            lblFormName.Name = "lblFormName";
            lblFormName.Size = new Size(59, 23);
            lblFormName.TabIndex = 2;
            lblFormName.Text = "label1";
            // 
            // picExit
            // 
            picExit.Image = (Image)resources.GetObject("picExit.Image");
            picExit.Location = new Point(750, 3);
            picExit.Name = "picExit";
            picExit.Size = new Size(48, 48);
            picExit.SizeMode = PictureBoxSizeMode.AutoSize;
            picExit.TabIndex = 1;
            picExit.TabStop = false;
            picExit.Click += picExit_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 128, 255);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 54);
            panel1.Name = "panel1";
            panel1.Size = new Size(774, 3);
            panel1.TabIndex = 1;
            // 
            // MasterForm
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 255, 192);
            ClientSize = new Size(774, 447);
            ControlBox = false;
            Controls.Add(panel1);
            Controls.Add(pnlMaster);
            Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            Name = "MasterForm";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Load += MasterForm_Load;
            pnlMaster.ResumeLayout(false);
            pnlMaster.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picExit).EndInit();
            ResumeLayout(false);
            }

        #endregion

        private Panel pnlMaster;
        private PictureBox picExit;
        private Label lblFormName;
        private Panel panel1;
        }
    }