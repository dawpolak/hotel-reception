using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelReception
{
    public partial class FormLogin : Form, ILogin
    {
        FormReception reception;
        public FormLogin(FormReception reception)
        {
            InitializeComponent();
            this.reception = reception;
        }

        public bool Access { get; set; }
        public bool CorrectUser { get; set; }
        public event Action<string, string> Login;

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            errorProviderLogin.Clear();
            errorProviderPassword.Clear();
            if (textBoxLogin.Text!="" && textBoxPassword.Text != "")
            {
                Login?.Invoke(textBoxLogin.Text, textBoxPassword.Text);
                if (Access && CorrectUser)
                {
                    this.Visible = false;
                    reception.ShowDialog();
                    textBoxLogin.Text = "";
                    textBoxPassword.Text = "";
                    this.Visible = true;
                }else
                {
                    if (!Access) MessageBox.Show("Nie mozna polaczyc sie z baza.");
                    if (!CorrectUser)
                    {
                        MessageBox.Show("Bledny login lub haslo");
                        textBoxLogin.Text = "";
                        textBoxPassword.Text = "";
                    };
                }
            }else
            {
                if (textBoxLogin.Text == "")
                {
                    errorProviderLogin.SetError(textBoxLogin, "Pole nie moze byc puste");
                    
                }
                if (textBoxPassword.Text == "")
                {
                    errorProviderPassword.SetError(textBoxPassword, "Pole nie moze byc puste");
                }
            }
            
        }

    }
}
