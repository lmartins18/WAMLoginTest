using Microsoft.Identity.Client;

namespace WAMLoginTest
{
    public partial class Form2 : Form
    {
        public string? Token { get; private set; }

        public Form2()
        {
            InitializeComponent();
            // make form invisible
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            ShowInTaskbar = false;
            Opacity = 0;
            Size = new Size(0, 0);
        }

        private async void Form2_Load(object sender, EventArgs e)
        {
            try
            {
                Token = await MSGraph.SignInUserAndGetTokenUsingMSAL(this.Handle);
            }
            catch (MsalClientException mex)
            {

                if (mex.ErrorCode.Equals("authentication_canceled"))
                {
                    MessageBox.Show("Login canceled.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("An error occurred, please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            this.Dispose();
        }
    }
}
