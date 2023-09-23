using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainProject.Forms.MasterForm
    {
    public partial class MasterForm : Form
        {

        public string strFormName = "Master Form";
        public MasterForm ()
            {
            InitializeComponent();
            }

        private void picExit_Click ( object sender, EventArgs e )
            {
            this.Close();
            }

        private void MasterForm_Load ( object sender, EventArgs e )
            {
            lblFormName.Text = strFormName;
            picExit.Left = pnlMaster.Width - picExit.Width;
            lblFormName.Left = (pnlMaster.Width / 2) - (lblFormName.Width / 2);
            }
        }
    }
