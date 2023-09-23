namespace MainProject
    {
    partial class Form1
        {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent ()
            {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            btnLanguageInstitute = new Button();
            btnFinance = new Button();
            btnUsers = new Button();
            btnExit = new Button();
            statusStrip1 = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            toolStripStatusLabel2 = new ToolStripStatusLabel();
            toolStripStatusLabel3 = new ToolStripStatusLabel();
            toolStripStatusLabel4 = new ToolStripStatusLabel();
            pictureBox1 = new PictureBox();
            timer1 = new System.Windows.Forms.Timer(components);
            toolStripStatusLabel5 = new ToolStripStatusLabel();
            statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnLanguageInstitute
            // 
            btnLanguageInstitute.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnLanguageInstitute.Image = (Image)resources.GetObject("btnLanguageInstitute.Image");
            btnLanguageInstitute.ImageAlign = ContentAlignment.MiddleRight;
            btnLanguageInstitute.Location = new Point(24, 94);
            btnLanguageInstitute.Name = "btnLanguageInstitute";
            btnLanguageInstitute.Size = new Size(237, 56);
            btnLanguageInstitute.TabIndex = 2;
            btnLanguageInstitute.Text = "Language Institute";
            btnLanguageInstitute.TextAlign = ContentAlignment.MiddleLeft;
            btnLanguageInstitute.UseVisualStyleBackColor = true;
            btnLanguageInstitute.Click += btnLanguageInstitute_Click;
            // 
            // btnFinance
            // 
            btnFinance.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnFinance.Image = (Image)resources.GetObject("btnFinance.Image");
            btnFinance.ImageAlign = ContentAlignment.MiddleRight;
            btnFinance.Location = new Point(276, 94);
            btnFinance.Name = "btnFinance";
            btnFinance.Size = new Size(274, 56);
            btnFinance.TabIndex = 3;
            btnFinance.Text = "Financial Management";
            btnFinance.TextAlign = ContentAlignment.MiddleLeft;
            btnFinance.UseVisualStyleBackColor = true;
            btnFinance.Click += btnFinance_Click;
            // 
            // btnUsers
            // 
            btnUsers.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnUsers.Image = (Image)resources.GetObject("btnUsers.Image");
            btnUsers.ImageAlign = ContentAlignment.MiddleRight;
            btnUsers.Location = new Point(571, 94);
            btnUsers.Name = "btnUsers";
            btnUsers.Size = new Size(122, 56);
            btnUsers.TabIndex = 4;
            btnUsers.Text = "Users";
            btnUsers.TextAlign = ContentAlignment.MiddleLeft;
            btnUsers.UseVisualStyleBackColor = true;
            btnUsers.Click += btnUsers_Click;
            // 
            // btnExit
            // 
            btnExit.Font = new Font("Comic Sans MS", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btnExit.Image = (Image)resources.GetObject("btnExit.Image");
            btnExit.ImageAlign = ContentAlignment.MiddleRight;
            btnExit.Location = new Point(795, 94);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(122, 56);
            btnExit.TabIndex = 6;
            btnExit.Text = "Exit";
            btnExit.TextAlign = ContentAlignment.MiddleLeft;
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1, toolStripStatusLabel5, toolStripStatusLabel2, toolStripStatusLabel3, toolStripStatusLabel4 });
            statusStrip1.Location = new Point(0, 570);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(924, 22);
            statusStrip1.TabIndex = 7;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(65, 17);
            toolStripStatusLabel1.Text = "UserName:";
            // 
            // toolStripStatusLabel2
            // 
            toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            toolStripStatusLabel2.Size = new Size(39, 17);
            toolStripStatusLabel2.Text = "Name";
            // 
            // toolStripStatusLabel3
            // 
            toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            toolStripStatusLabel3.Size = new Size(37, 17);
            toolStripStatusLabel3.Text = "          ";
            // 
            // toolStripStatusLabel4
            // 
            toolStripStatusLabel4.Name = "toolStripStatusLabel4";
            toolStripStatusLabel4.Size = new Size(33, 17);
            toolStripStatusLabel4.Text = "Time";
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Bottom;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 182);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(924, 388);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // toolStripStatusLabel5
            // 
            toolStripStatusLabel5.Name = "toolStripStatusLabel5";
            toolStripStatusLabel5.Size = new Size(13, 17);
            toolStripStatusLabel5.Text = ": ";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(924, 592);
            Controls.Add(pictureBox1);
            Controls.Add(statusStrip1);
            Controls.Add(btnExit);
            Controls.Add(btnUsers);
            Controls.Add(btnFinance);
            Controls.Add(btnLanguageInstitute);
            Margin = new Padding(5);
            Name = "Form1";
            Load += Form1_Load;
            Controls.SetChildIndex(btnLanguageInstitute, 0);
            Controls.SetChildIndex(btnFinance, 0);
            Controls.SetChildIndex(btnUsers, 0);
            Controls.SetChildIndex(btnExit, 0);
            Controls.SetChildIndex(statusStrip1, 0);
            Controls.SetChildIndex(pictureBox1, 0);
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
            }

        #endregion

        private Button btnLanguageInstitute;
        private Button btnFinance;
        private Button btnUsers;
        private Button btnExit;
        private StatusStrip statusStrip1;
        private PictureBox pictureBox1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private ToolStripStatusLabel toolStripStatusLabel2;
        private ToolStripStatusLabel toolStripStatusLabel3;
        private ToolStripStatusLabel toolStripStatusLabel4;
        private System.Windows.Forms.Timer timer1;
        private ToolStripStatusLabel toolStripStatusLabel5;
        }
    }