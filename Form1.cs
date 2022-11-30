namespace WAMLoginTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void loginBtn_Click(object sender, EventArgs e)
        {
            // The reason I'm using a second form to authenticate, is that for some reason, if I canceled the login (close the dialog) and tried to login again,
            // the program constantly raised the same exception with the following details:
            // 
            //  Message = Unknown Status: Unexpected
            //  Error: 0xffffffff80010012
            //  Context: Unexpected exception while waiting for accounts control to finish: '(pii)'
            //  Tag: 0x1f7d734b(error code - 2147418094)(internal error code 528315211)
            //  Since I could not find any info/solution for that problem, I ended up using a second form as a workaround.
            using(Form2 frm = new())
            {
                // Basically, login using second form, if successfull display token in label. (this is just proof-of-concept...).
                frm.ShowDialog();
                if(frm.IsDisposed)
                {
                    tokenLbl.Text = frm.Token;
                }
            }
        }
    }
}