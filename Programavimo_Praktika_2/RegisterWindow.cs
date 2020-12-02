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
using Programavimo_Praktika_2.Backend.Models;
using Programavimo_Praktika_2;

namespace Programavimo_Praktika_2
{
    public partial class RegisterWindow : Form
    {
        public RegisterWindow()
        {
            InitializeComponent();
        }

        private void confirmbutton_Click(object sender, EventArgs e)
        {
            SqlHelper sql = new SqlHelper();
            SqlHelper.InsertDataForSql(namebox.Text, surnamebox.Text, namebox.Text, surnamebox.Text, emailbox.Text, rolebox.Text);
        }
    }
}
