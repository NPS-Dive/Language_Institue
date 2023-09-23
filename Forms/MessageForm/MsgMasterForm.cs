using BaseControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainProject.Forms
    {
    public partial class MsgMasterForm : Forms.MasterForm.MasterForm
        {

        /// <summary>
        /// varibale for determining the number of the buttons of MSGbox
        /// </summary>
        public int BtnCount = 1;


        public MsgMasterForm ()
            {
            InitializeComponent();
            }

        private void MsgMasterForm_Load ( object sender, EventArgs e )
            {
            if (BtnCount == 1)
                {
                btnCancel.Visible = false;
                btnOK.Left = (this.Width / 2) - (btnOK.Width / 2);
                }

            }

        private void btnOK_Click ( object sender, EventArgs e )
            {
            this.Close();
            }

        private void btnCancel_Click ( object sender, EventArgs e )
            {

            }
        }
    }
