using Register_Login_System.Components;
using System.Text.Json;
using System.Windows.Forms;

namespace Register_Login_System
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            txtUsername.Text = txtUsername.Text.Trim();
            txtPassword.Text = txtPassword.Text.Trim();

            if (string.IsNullOrWhiteSpace(txtUsername.Text))
            {
                MessageBox.Show("Nhập tên tài khoản.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUsername.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("Nhập mật khẩu.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPassword.Focus();
                return;
            }

            //File .json lưu vào \bin\Debug\net10.0-windows
            //File này làm mock csdl

            string filepath = "users.json";
            bool loginSuccess = false;

            if (File.Exists(filepath))
            {
                string jsonContent = File.ReadAllText(filepath);
                List<Users> list = JsonSerializer.Deserialize<List<Users>>(jsonContent);

                if (list != null)
                {
                    foreach (var u in list)
                    {
                        if (u.Username == txtUsername.Text && u.Password == txtPassword.Text)
                        {
                            loginSuccess = true;
                            break;
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Tài khoản không tồn tại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (loginSuccess)
            {
                this.Hide();

                using (var app = new MainApplication())
                {
                    app.ShowDialog();
                }

                this.Close();
            }
            else
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu sai.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUsername.Clear();
                txtPassword.Clear();
                txtUsername.Focus();
            }
        }

        private void lklbRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();

            using (RegisterForm regForm = new RegisterForm())
            {
                regForm.ShowDialog();

                if (regForm.exitRequest)
                {
                    this.Close();
                }
                else
                {
                    this.Show();
                }
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();

            using (PasswordRecovery passRec = new PasswordRecovery())
            {
                passRec.ShowDialog();

                if (passRec.exitRequest)
                {
                    this.Close();
                }
                else
                {
                    this.Show();
                }
            }
        }
    }
}
