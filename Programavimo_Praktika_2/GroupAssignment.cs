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

namespace Programavimo_Praktika_2
{
    public partial class GroupAssignment : Form
    {
        public GroupAssignment()
        {
            InitializeComponent();
        }

        private void GroupAssignment_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'praktika2DataSet4.UserTable' table. You can move, or remove it, as needed.
            this.userTableTableAdapter.Starting(this.praktika2DataSet4.UserTable);
            // TODO: This line of code loads data into the 'praktika2DataSet4.Groups' table. You can move, or remove it, as needed.
            this.groupsTableAdapter.Fill(this.praktika2DataSet4.Groups);

        }

        private void filterUnAssignedUsersToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.userTableTableAdapter.FilterUnAssignedUsers(this.praktika2DataSet4.UserTable);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void filterUnAssignedUsersToolStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"nusiunciau {comboBox1.SelectedValue} ir  {comboBox2.SelectedValue}");
            SqlHelper.InsertDataForSqlAssignGroups((int)comboBox1.SelectedValue, (int)comboBox2.SelectedValue);
        }

        private void unAssignedUsersToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.userTableTableAdapter.UnAssignedUsers(this.praktika2DataSet4.UserTable);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void unAssignedUsersToolStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void fillByUnAssignedToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.userTableTableAdapter.FillByUnAssigned(this.praktika2DataSet4.UserTable);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void unAssignedToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.userTableTableAdapter.UnAssigned(this.praktika2DataSet4.UserTable);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void startingToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.userTableTableAdapter.Starting(this.praktika2DataSet4.UserTable);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
