namespace MainProject
    {
    public partial class Form1 : Forms.MasterForm.MasterForm
        {
        public Form1 ()
            {
            InitializeComponent();
            }

        private void Form1_Load ( object sender, EventArgs e )
            {
            //in case of making a login for system
            /* In 
            UserAccount.Forms.Login.LoginForm loginForm = new()
                {
                strFormName = "Login Page"
                };
            loginForm.ShowDialog();
            
            if (UserInstance.Permission.ToLower() == "admin")
                {

                }
            if (UserInstance.Permission.ToLower() == "prorammer")
                {

                }
            if (UserInstance.Permission.ToLower() == "accountant")
                {
                btnLanguageInstitute.Enabled = false;
                btnUsers.Enabled = false;
                }
            if (UserInstance.Permission.ToLower() == "professor")
                {
                btnFinance.Enabled = false;
                btnUsers.Enabled = false;
                }
            if (UserInstance.Permission.ToLower() == "educator")
                {
                btnFinance.Enabled = false;
                btnUsers.Enabled = false;
                }

            toolStripStatusLabel1.Text = UserInstance.UserName;
            toolStripStatusLabel2.Text = UserInstance.Name + " " + UserInstance.LastName;
            */

            }

        private void btnLanguageInstitute_Click ( object sender, EventArgs e )
            {
            LanguageInstituteTest.Form1 form = new()
                {
                strFormName = "Language Institute"
                };
            form.ShowDialog();
            }

        private void btnFinance_Click ( object sender, EventArgs e )
            {
            FinancialSystem.MainFormFinance form = new()
                {
                strFormName = "Financial Management"
                };
            form.ShowDialog();
            }

        private void btnUsers_Click ( object sender, EventArgs e )
            {
            UserAccount.Form1 form = new()
                {
                strFormName = "Users & Accounts Management"
                };
            form.ShowDialog();
            }

        private void btnExit_Click ( object sender, EventArgs e )
            {
           if(MsgBox.Show("Do You Really want to Quit?","Exit Message",2)==DialogResult.OK)
                {
                Application.Exit();
                }
            }

        private void timer1_Tick ( object sender, EventArgs e )
            {
            toolStripStatusLabel4.Text = DateTime.Now.ToLongTimeString();
            }
        }
    }