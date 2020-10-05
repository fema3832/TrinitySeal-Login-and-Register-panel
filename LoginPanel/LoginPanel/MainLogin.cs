// Github: https://github.com/rixan1337
// Login panel created by: rixan1337
// Website: https://rixan.xyz
// Discord: rixan#1337

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginPanel
{
    public partial class MainLogin : Form
    {
        public MainLogin()
        {
            InitializeComponent();
            TrinitySeal.Seal.Secret = "YOUR APPLICATION SECRET";
            TokenText.Visible = false;
            ConfirmRegister.Visible = false;

            UserText.Text  = "Username";
            PassText.Text  = "Password";
            TokenText.Text = "Invite code";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Location = Screen.AllScreens[1].WorkingArea.Location;

            TrinitySeal.Seal.Initialize("1.0");
            if (TrinitySeal.ProgramVariables.Freemode == true)
            {
                this.Hide();
                NewWin menu = new NewWin();
                menu.Closed += (s, args) => this.Close();
                menu.Show();
            }
        }

        // Enter placeholder

        private void UserText_Enter(object sender, EventArgs e)
        {
            if (UserText.Text == "Username")
            {
                UserText.Text = "";
                UserText.ForeColor = Color.Silver;
            }
        }

        private void PassText_Enter(object sender, EventArgs e)
        {
            if (PassText.Text == "Password")
            {
                PassText.Text = "";
                PassText.PasswordChar = '*';
                PassText.ForeColor = Color.Silver;
            }
        }

        private void TokenText_Enter(object sender, EventArgs e)
        {
            if (TokenText.Text == "Invite code")
            {
                TokenText.Text = "";
                TokenText.ForeColor = Color.Silver;
            }
        }

        // Leave placeholder

        private void UserText_Leave(object sender, EventArgs e)
        {
            if (UserText.Text == "")
            {
                UserText.Text = "Username";
                UserText.ForeColor = Color.Gray;
            }
        }

        private void PassText_Leave(object sender, EventArgs e)
        {
            if (PassText.Text == "")
            {
                PassText.Text = "Password";
                PassText.PasswordChar = char.Parse("\0");
                PassText.ForeColor = Color.Gray;
            }
        }

        private void TokenText_Leave(object sender, EventArgs e)
        {
            if (TokenText.Text == "")
            {
                TokenText.Text = "Invite code";
                TokenText.ForeColor = Color.Gray;
            }
        }

        // Buttons

        private void Login_Click(object sender, EventArgs e)
        {
            bool response = TrinitySeal.Seal.Login(UserText.Text, PassText.Text);
            if (response)
            {
                this.Hide();
                NewWin menu = new NewWin();
                menu.Show();
                menu.Closed += (s, args) => this.Show();
            }
        }

        private void Register_Click(object sender, EventArgs e)
        {
            ConfirmRegister.Visible = true;
            TokenText.Visible = true;
            Login.Enabled = false;
        }

        private void ConfirmRegister_Click(object sender, EventArgs e)
        {
            bool response = TrinitySeal.Seal.Register(UserText.Text, PassText.Text, "none", TokenText.Text);
            if (response)
            {
                ConfirmRegister.Visible = false;
                TokenText.Visible = false;
                Login.Enabled = true;
            }
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Move

        private void MenuMain_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }
        Point lastPoint;
        private void Main_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void Háttér_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void Háttér_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }
    }
}
