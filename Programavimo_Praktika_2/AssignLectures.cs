using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Programavimo_Praktika_2.Backend.Models;
using Programavimo_Praktika_2.Backend.Repositories;

namespace Programavimo_Praktika_2
{
    public partial class AssignLectures : Form
    {
        public AssignLectures()
        {
            InitializeComponent();
            SqlHelper sql = new SqlHelper();
            List<LecturedBy> listas = new List<LecturedBy>();
            listas = sql.GetLecturedBy();
            foreach (LecturedBy c in listas) {

                Label lecture = new Label();
                Label alecturer = new Label();
                lecture.Text = SqlHelper.InsertDataFromUserForLecturesBy(c.UserId);
                alecturer.Text = SqlHelper.InsertDataFromUserForLecturesByLectureID(c.LectureId);
                flowLayoutPanel1.Controls.Add(lecture);
                flowLayoutPanel1.Controls.Add(alecturer);
                flowLayoutPanel1.SetFlowBreak(alecturer, true);
              //  MessageBox.Show($"Pamokos ID {c.LectureId} , Destytojo ID {c.UserId}");
            }
            //flowLayoutPanel1.
           // Label lecture = new Label();
           // Label alecturer = new Label();
            
        }

        private void AssignLectures_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'praktika2DataSet3.Groups' table. You can move, or remove it, as needed.
            this.groupsTableAdapter.Fill(this.praktika2DataSet3.Groups);
            // TODO: This line of code loads data into the 'praktika2DataSet2.LectureTable' table. You can move, or remove it, as needed.
            this.lectureTableTableAdapter1.Fill(this.praktika2DataSet2.LectureTable);
            // TODO: This line of code loads data into the 'praktika2DataSet1.UserTable' table. You can move, or remove it, as needed.
            this.userTableTableAdapter.FillBy1(this.praktika2DataSet1.UserTable);

        }

   

        

        private void button1_Click(object sender, EventArgs e)
        {
            SqlHelper.InsertDataForSqlLecturedBy((int)LecturerLectureComboBox.SelectedValue, (int)LecturerComboBox.SelectedValue);
            MessageBox.Show($"Lecturer : {LecturerLectureComboBox.Text} Assigned to : {LecturerComboBox.Text}");
        }

        private void fillBy1ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.userTableTableAdapter.FillBy1(this.praktika2DataSet1.UserTable);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlHelper.InsertDataForSqlGroupLectures((int)combolecturesforGROUPS.SelectedValue, (int)groupcombobox.SelectedValue);
           MessageBox.Show($"Lecture: {combolecturesforGROUPS.Text} Assigned to : {groupcombobox.Text}");
        }
    }
}
