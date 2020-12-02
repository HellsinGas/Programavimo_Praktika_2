
namespace Programavimo_Praktika_2
{
    partial class AssignLectures
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.LecturerLectureComboBox = new System.Windows.Forms.ComboBox();
            this.lectureTableBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.praktika2DataSet2 = new Programavimo_Praktika_2.Praktika2DataSet2();
            this.lectureTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.LecturerComboBox = new System.Windows.Forms.ComboBox();
            this.userTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.praktika2DataSet1 = new Programavimo_Praktika_2.Praktika2DataSet1();
            this.combolecturesforGROUPS = new System.Windows.Forms.ComboBox();
            this.groupcombobox = new System.Windows.Forms.ComboBox();
            this.userTableTableAdapter = new Programavimo_Praktika_2.Praktika2DataSet1TableAdapters.UserTableTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.lectureTableTableAdapter1 = new Programavimo_Praktika_2.Praktika2DataSet2TableAdapters.LectureTableTableAdapter();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.praktika2DataSet3 = new Programavimo_Praktika_2.Praktika2DataSet3();
            this.groupsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupsTableAdapter = new Programavimo_Praktika_2.Praktika2DataSet3TableAdapters.GroupsTableAdapter();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.lectureTableBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.praktika2DataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lectureTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.praktika2DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.praktika2DataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // LecturerLectureComboBox
            // 
            this.LecturerLectureComboBox.DataSource = this.lectureTableBindingSource1;
            this.LecturerLectureComboBox.DisplayMember = "Name";
            this.LecturerLectureComboBox.FormattingEnabled = true;
            this.LecturerLectureComboBox.Location = new System.Drawing.Point(12, 351);
            this.LecturerLectureComboBox.Name = "LecturerLectureComboBox";
            this.LecturerLectureComboBox.Size = new System.Drawing.Size(299, 24);
            this.LecturerLectureComboBox.TabIndex = 0;
            this.LecturerLectureComboBox.ValueMember = "ID";
            // 
            // lectureTableBindingSource1
            // 
            this.lectureTableBindingSource1.DataMember = "LectureTable";
            this.lectureTableBindingSource1.DataSource = this.praktika2DataSet2;
            // 
            // praktika2DataSet2
            // 
            this.praktika2DataSet2.DataSetName = "Praktika2DataSet2";
            this.praktika2DataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lectureTableBindingSource
            // 
            this.lectureTableBindingSource.DataMember = "LectureTable";
            // 
            // LecturerComboBox
            // 
            this.LecturerComboBox.DataSource = this.userTableBindingSource;
            this.LecturerComboBox.DisplayMember = "surname";
            this.LecturerComboBox.FormattingEnabled = true;
            this.LecturerComboBox.Location = new System.Drawing.Point(12, 381);
            this.LecturerComboBox.Name = "LecturerComboBox";
            this.LecturerComboBox.Size = new System.Drawing.Size(299, 24);
            this.LecturerComboBox.TabIndex = 1;
            this.LecturerComboBox.ValueMember = "id";
            // 
            // userTableBindingSource
            // 
            this.userTableBindingSource.DataMember = "UserTable";
            this.userTableBindingSource.DataSource = this.praktika2DataSet1;
            // 
            // praktika2DataSet1
            // 
            this.praktika2DataSet1.DataSetName = "Praktika2DataSet1";
            this.praktika2DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // combolecturesforGROUPS
            // 
            this.combolecturesforGROUPS.DataSource = this.lectureTableBindingSource1;
            this.combolecturesforGROUPS.DisplayMember = "Name";
            this.combolecturesforGROUPS.FormattingEnabled = true;
            this.combolecturesforGROUPS.Location = new System.Drawing.Point(449, 351);
            this.combolecturesforGROUPS.Name = "combolecturesforGROUPS";
            this.combolecturesforGROUPS.Size = new System.Drawing.Size(339, 24);
            this.combolecturesforGROUPS.TabIndex = 2;
            this.combolecturesforGROUPS.ValueMember = "ID";
            // 
            // groupcombobox
            // 
            this.groupcombobox.DataSource = this.groupsBindingSource;
            this.groupcombobox.DisplayMember = "GroupName";
            this.groupcombobox.FormattingEnabled = true;
            this.groupcombobox.Location = new System.Drawing.Point(449, 381);
            this.groupcombobox.Name = "groupcombobox";
            this.groupcombobox.Size = new System.Drawing.Size(339, 24);
            this.groupcombobox.TabIndex = 3;
            this.groupcombobox.ValueMember = "ID";
            this.groupcombobox.SelectedIndexChanged += new System.EventHandler(this.comboBox4_SelectedIndexChanged);
            // 
            // userTableTableAdapter
            // 
            this.userTableTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 411);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(299, 27);
            this.button1.TabIndex = 4;
            this.button1.Text = "Assing Lecturer To Lecture";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lectureTableTableAdapter1
            // 
            this.lectureTableTableAdapter1.ClearBeforeFill = true;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(13, 13);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(388, 332);
            this.flowLayoutPanel1.TabIndex = 5;
            // 
            // praktika2DataSet3
            // 
            this.praktika2DataSet3.DataSetName = "Praktika2DataSet3";
            this.praktika2DataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupsBindingSource
            // 
            this.groupsBindingSource.DataMember = "Groups";
            this.groupsBindingSource.DataSource = this.praktika2DataSet3;
            // 
            // groupsTableAdapter
            // 
            this.groupsTableAdapter.ClearBeforeFill = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(449, 411);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(339, 27);
            this.button2.TabIndex = 6;
            this.button2.Text = "Assing Lecture to Group";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // AssignLectures
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 458);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupcombobox);
            this.Controls.Add(this.combolecturesforGROUPS);
            this.Controls.Add(this.LecturerComboBox);
            this.Controls.Add(this.LecturerLectureComboBox);
            this.Name = "AssignLectures";
            this.Text = "AssignLectures";
            this.Load += new System.EventHandler(this.AssignLectures_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lectureTableBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.praktika2DataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lectureTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.praktika2DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.praktika2DataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox LecturerLectureComboBox;
        private System.Windows.Forms.ComboBox LecturerComboBox;
        private System.Windows.Forms.ComboBox combolecturesforGROUPS;
        private System.Windows.Forms.ComboBox groupcombobox;
        private Praktika2DataSet praktika2DataSet;
        private System.Windows.Forms.BindingSource lectureTableBindingSource;
        private Praktika2DataSetTableAdapters.LectureTableTableAdapter lectureTableTableAdapter;
        private Praktika2DataSet1 praktika2DataSet1;
        private System.Windows.Forms.BindingSource userTableBindingSource;
        private Praktika2DataSet1TableAdapters.UserTableTableAdapter userTableTableAdapter;
        private System.Windows.Forms.Button button1;
        private Praktika2DataSet2 praktika2DataSet2;
        private System.Windows.Forms.BindingSource lectureTableBindingSource1;
        private Praktika2DataSet2TableAdapters.LectureTableTableAdapter lectureTableTableAdapter1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private Praktika2DataSet3 praktika2DataSet3;
        private System.Windows.Forms.BindingSource groupsBindingSource;
        private Praktika2DataSet3TableAdapters.GroupsTableAdapter groupsTableAdapter;
        private System.Windows.Forms.Button button2;
    }
}