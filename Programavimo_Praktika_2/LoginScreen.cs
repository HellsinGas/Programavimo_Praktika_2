using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Programavimo_Praktika_2.Backend.Repositories;


namespace Programavimo_Praktika_2
{
    public partial class LoginScreen : Form
    {
        public LoginScreen()
        {
            InitializeComponent();
            passbox.PasswordChar ='*';
        }

        private void loginbutt_Click(object sender, EventArgs e)
        {
            bool login = SqlHelper.LoginwithSql(usernamebox.Text, passbox.Text);
            if (login == true)
            {
                LogedInScreen logins = new LogedInScreen(usernamebox.Text, passbox.Text);
                logins.Show();
            }
        }
    }
}
