using MainProject.Forms;

    public class MsgBox
        {
        public static void Show ( string StrMSG )
            {
             MsgMasterForm frm = new();
            frm.lblMSG.Text = StrMSG;
            frm.ShowDialog();
            }
        public static void Show ( string StrMSG, string StrTitle )
            {
            MsgMasterForm frm = new();
            frm.lblMSG.Text = StrMSG;
            frm.strFormName = StrTitle;
            frm.ShowDialog();
            }
        public static DialogResult Show ( string StrMSG, string StrTitle, int BtnCount )
            {
            MsgMasterForm frm = new();
            frm.lblMSG.Text = StrMSG;
            frm.strFormName = StrTitle;
            frm.BtnCount = BtnCount;
            return frm.ShowDialog();
            }
        }
   
