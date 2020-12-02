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
    public partial class AdminControl : UserControl
    {
        private SqlHelper sqlas;
        public AdminControl()
        {
            InitializeComponent();
            //label1.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void GroupControlButton_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            flowLayoutPanel2.Controls.Clear();          
            Label label1 = new Label();
            label1.Text = "Select Group you wish to Delete";          
            sqlas = new SqlHelper();
            List<Groups> groups = sqlas.GetGroups();
            int width = flowLayoutPanel1.Width - 5;
            label1.Width = width;
            flowLayoutPanel1.Controls.Add(label1);
            foreach (Groups g in groups)
            {
                Button groupbutton = new Button();
                groupbutton.Text = g.GroupName;
                groupbutton.Width = width;
                flowLayoutPanel1.Controls.Add(groupbutton);
                groupbutton.Tag = g;
                groupbutton.Click += Groupbutton_Click;
            }
            TextBox textBox = new TextBox();
            Label newgrplabel = new Label();
            newgrplabel.Text = "Input New Group name";
            newgrplabel.Width = flowLayoutPanel2.Width - 5;
            textBox.Width = flowLayoutPanel2.Width - 5;
            flowLayoutPanel2.Controls.Add(newgrplabel);            
            flowLayoutPanel2.Controls.Add(textBox);
            flowLayoutPanel2.SetFlowBreak(textBox, true);
            Button add = new Button();
            add.Width = flowLayoutPanel2.Width - 5;
            add.Text = "Add new Group";
            flowLayoutPanel2.Controls.Add(add);
            //string send = textBox.Text;
            add.Tag = textBox;
            add.Click += Add_Click;
        }

        private void Add_Click(object sender, EventArgs e)
        {
            Button add = (Button)sender;
            TextBox kk = (TextBox)add.Tag;
            string grp = kk.Text;
           // string grp = (TextBox)(add.Tag).Tag.ToString();
            SqlHelper.InsertDataForSqlGroup(grp);
           // throw new NotImplementedException();
        }

        private void Groupbutton_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            Groups group = (Groups)button.Tag;
            DialogResult dialogResult = MessageBox.Show($"Do you realy want to delete {group.GroupName} ", "Delete", MessageBoxButtons.YesNo);
            if(dialogResult == DialogResult.Yes)
            {

                SqlHelper.DeleteGroup(group.Id.ToString());
            }
            else if (dialogResult == DialogResult.No)
            {

            }

           // MessageBox.Show($"ID:{group.Id} Name: {group.GroupName}");
           // throw new NotImplementedException();
        }

        private void LectureControlButton_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            flowLayoutPanel2.Controls.Clear();            
            Label label1 = new Label();
            label1.Text = "Select Lecture you wish to Delete";            
            sqlas = new SqlHelper();
            List<Lectures> lectures = sqlas.GetLectures();
            int width = flowLayoutPanel1.Width - 5;
            label1.Width = width;
            flowLayoutPanel1.Controls.Add(label1);
            
            foreach (Lectures g in lectures)
            {
                Button lecturebutton = new Button();
               // Label description = new Label();
                Label lecturedesc = new Label();
                lecturebutton.Text = g.LectureName;
                lecturebutton.Width = width;
                lecturedesc.Width = width;
                lecturedesc.Text = g.Description;
                // flowLayoutPanel2.Controls.Add(description);
                flowLayoutPanel1.Controls.Add(lecturebutton);
                flowLayoutPanel1.Controls.Add(lecturedesc);
                flowLayoutPanel1.SetFlowBreak(lecturedesc, true);
              //  flowLayoutPanel1.Controls.Add(lecturebutton);
                lecturebutton.Tag = g;
                lecturebutton.Click += Lecturebutton_Click;
            }
            TextBox textBox = new TextBox();
            TextBox textBox1 = new TextBox();
            Label newgrplabel = new Label();
           Label description = new Label();
            newgrplabel.Text = "Input New Lecture name";
            description.Text = "Description:";
            newgrplabel.Width = flowLayoutPanel2.Width - 5;         
            textBox.Width = flowLayoutPanel2.Width - 5;
            textBox1.Width = flowLayoutPanel2.Width - 5;
            flowLayoutPanel2.Controls.Add(newgrplabel);
            flowLayoutPanel2.Controls.Add(textBox);
            flowLayoutPanel2.SetFlowBreak(textBox, true);
            flowLayoutPanel2.Controls.Add(description);
            flowLayoutPanel2.SetFlowBreak(description, true);
            flowLayoutPanel2.Controls.Add(textBox1);
            flowLayoutPanel2.SetFlowBreak(textBox, true);
            Button add2 = new Button();
            add2.Width = flowLayoutPanel2.Width - 5;
            add2.Text = "Add new Lecture";
            flowLayoutPanel2.Controls.Add(add2);            
            ExTag exTag = new ExTag();
            exTag.Add("Name", textBox);
            exTag.Add("Desc", textBox1);

            //string send = textBox.Text;
            
            add2.Tag = exTag;
            add2.Click += Add2_Click;
        
    }

        private void Add2_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            ExTag exTag = (ExTag)button.Tag;
            TextBox name = (TextBox)(exTag.Get("Name"));
            TextBox desc = (TextBox)(exTag.Get("Desc"));
            SqlHelper.InsertDataForSqlLecture(name.Text, desc.Text);
            //MessageBox.Show($"bbz: {name.Text} bbd: {desc.Text}");
        }

        private void Lecturebutton_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            Lectures group = (Lectures)button.Tag;
            DialogResult dialogResult = MessageBox.Show($"Do you realy want to delete {group.LectureName} ", "Delete", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {

                SqlHelper.DeleteLecture(group.Id.ToString());
            }
            else if (dialogResult == DialogResult.No)
            {

            }
        }

        private void AcountControl_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            flowLayoutPanel2.Controls.Clear();
            Label label1 = new Label();
            label1.Text = "Select Account you wish to Delete";
            sqlas = new SqlHelper();
            List<UserInfo> userInfos = sqlas.GetUserInfo();
            int width = flowLayoutPanel1.Width - 5;
            label1.Width = width;
            flowLayoutPanel1.Controls.Add(label1);

            foreach (UserInfo g in userInfos)
            {
                Button userbutton = new Button();                
                userbutton.Text = $"{g.Name} {g.Surname} {g.Role}";
                userbutton.Width = width;               
                flowLayoutPanel1.Controls.Add(userbutton);                
                userbutton.Tag = g;
                userbutton.Click += Userbutton_Click;
            }           
            Button adduser = new Button();
            adduser.Width = flowLayoutPanel2.Width - 5;
            adduser.Text = "Add new User";
            flowLayoutPanel2.Controls.Add(adduser);
            adduser.Click += Adduser_Click;
            
            
        }

        private void Adduser_Click(object sender, EventArgs e)
        {
            RegisterWindow reg = new RegisterWindow();
            reg.Show();
        }

        private void Userbutton_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            UserInfo group = (UserInfo)button.Tag;
            DialogResult dialogResult = MessageBox.Show($"Do you realy want to delete {group.Name} {group.Surname} : {group.Role} ", "Delete", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {

                SqlHelper.DeleteUser(group.Id.ToString());
            }
            else if (dialogResult == DialogResult.No)
            {

            }
        }

      

        private void AssingLecturesbutt_Click(object sender, EventArgs e)
        {
            AssignLectures assign = new AssignLectures();
            assign.Show();
        }
    }
}
