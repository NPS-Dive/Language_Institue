namespace MainProject.Forms
    {
   public  partial class MsgMasterForm
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
            lblMSG = new Label();
            btnOK = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // lblMSG
            // 
            lblMSG.AutoSize = true;
            lblMSG.Font = new Font("Tahoma", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblMSG.Location = new Point(31, 135);
            lblMSG.Name = "lblMSG";
            lblMSG.Size = new Size(59, 23);
            lblMSG.TabIndex = 2;
            lblMSG.Text = "label1";
            // 
            // btnOK
            // 
            btnOK.DialogResult = DialogResult.OK;
            btnOK.Location = new Point(66, 210);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(105, 40);
            btnOK.TabIndex = 3;
            btnOK.Text = "Yep!";
            btnOK.UseVisualStyleBackColor = true;
            btnOK.Click += btnOK_Click;
            // 
            // btnCancel
            // 
            btnCancel.DialogResult = DialogResult.Cancel;
            btnCancel.Location = new Point(177, 210);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(105, 40);
            btnCancel.TabIndex = 4;
            btnCancel.Text = "Nope!";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // MsgMasterForm
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(433, 278);
            Controls.Add(btnCancel);
            Controls.Add(btnOK);
            Controls.Add(lblMSG);
            Margin = new Padding(5);
            Name = "MsgMasterForm";
            Load += MsgMasterForm_Load;
            Controls.SetChildIndex(lblMSG, 0);
            Controls.SetChildIndex(btnOK, 0);
            Controls.SetChildIndex(btnCancel, 0);
            ResumeLayout(false);
            PerformLayout();
            }

        #endregion
        private Button btnOK;
        public Label lblMSG;
        private Button btnCancel;
        }
    }