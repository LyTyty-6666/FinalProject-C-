namespace FinalProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            string UN = this.txtUsername.Text.ToString().Trim().ToLower();
            string PW = this.txtPW.Text.ToString().Trim().ToLower();
            if(string.IsNullOrWhiteSpace(UN)&&
                string.IsNullOrWhiteSpace(PW)) 
            { 
                MessageBox.Show("Enter the User Name or PassWord","Invalid"
                ,MessageBoxButtons.OK,MessageBoxIcon.Warning); 
                FillText(); 
                return;
            }
            if (UN.Equals("admin") && PW.Equals("admin123")) 
            { 
                MainForm open = new MainForm();
                open.Show();
                this.Hide();
            }
            else 
            {
                MessageBox.Show("The User Name or PassWrod Incorrect!", "Information"
                , MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning); 
                FillText();
                return;
            }
        }

        private void FillText() 
        { 
            this.txtPW.Focus();
            this.txtUsername.Focus();
        }

    }
}
