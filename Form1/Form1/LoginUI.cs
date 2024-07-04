using Form1.Connect_DB.Services;

namespace Form1
{
    public partial class LoginUI : Form
    {
        AccountService accountService { get; set; }
        public LoginUI()
        {
            InitializeComponent();
            accountService = new AccountService();
        }

        private void txt_userName_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            txt_userName.Text = "";
        }

        private void txt_passWord_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            txt_passWord.Text = "";
        }

        private void button_Login_Click(object sender, EventArgs e)
        {
            bool Result = accountService.IsExisted(txt_userName.Text, txt_passWord.Text);
            if (Result)
            {
                MessageBox.Show("Đăng nhập thành công!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                new App().Show();           
            }
            else
            {
                MessageBox.Show("Đăng nhập thất bại!", "Vui lòng xem lại thông tin", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_userName.Focus();
            }
        }
    }
}
