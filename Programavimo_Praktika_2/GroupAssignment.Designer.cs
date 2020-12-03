
namespace Programavimo_Praktika_2
{
    partial class GroupAssignment
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.groupsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.praktika2DataSet4BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.praktika2DataSet4 = new Programavimo_Praktika_2.Praktika2DataSet4();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.userTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupsTableAdapter = new Programavimo_Praktika_2.Praktika2DataSet4TableAdapters.GroupsTableAdapter();
            this.userTableTableAdapter = new Programavimo_Praktika_2.Praktika2DataSet4TableAdapters.UserTableTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.unAssignedToolStrip = new System.Windows.Forms.ToolStrip();
            this.unAssignedToolStripButton = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.groupsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.praktika2DataSet4BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.praktika2DataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userTableBindingSource)).BeginInit();
            this.unAssignedToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.groupsBindingSource;
            this.comboBox1.DisplayMember = "GroupName";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(180, 132);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(331, 24);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.ValueMember = "ID";
            // 
            // groupsBindingSource
            // 
            this.groupsBindingSource.DataMember = "Groups";
            this.groupsBindingSource.DataSource = this.praktika2DataSet4BindingSource;
            // 
            // praktika2DataSet4BindingSource
            // 
            this.praktika2DataSet4BindingSource.DataSource = this.praktika2DataSet4;
            this.praktika2DataSet4BindingSource.Position = 0;
            // 
            // praktika2DataSet4
            // 
            this.praktika2DataSet4.DataSetName = "Praktika2DataSet4";
            this.praktika2DataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // comboBox2
            // 
            this.comboBox2.DataSource = this.userTableBindingSource;
            this.comboBox2.DisplayMember = "surname";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(180, 162);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(331, 24);
            this.comboBox2.TabIndex = 1;
            this.comboBox2.ValueMember = "id";
            // 
            // userTableBindingSource
            // 
            this.userTableBindingSource.DataMember = "UserTable";
            this.userTableBindingSource.DataSource = this.praktika2DataSet4BindingSource;
            // 
            // groupsTableAdapter
            // 
            this.groupsTableAdapter.ClearBeforeFill = true;
            // 
            // userTableTableAdapter
            // 
            this.userTableTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(180, 192);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(331, 98);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // unAssignedToolStrip
            // 
            this.unAssignedToolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.unAssignedToolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.unAssignedToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.unAssignedToolStripButton});
            this.unAssignedToolStrip.Location = new System.Drawing.Point(514, 162);
            this.unAssignedToolStrip.Name = "unAssignedToolStrip";
            this.unAssignedToolStrip.Size = new System.Drawing.Size(104, 27);
            this.unAssignedToolStrip.TabIndex = 3;
            this.unAssignedToolStrip.Text = "unAssignedToolStrip";
            // 
            // unAssignedToolStripButton
            // 
            this.unAssignedToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.unAssignedToolStripButton.Name = "unAssignedToolStripButton";
            this.unAssignedToolStripButton.Size = new System.Drawing.Size(91, 24);
            this.unAssignedToolStripButton.Text = "UnAssigned";
            this.unAssignedToolStripButton.Click += new System.EventHandler(this.unAssignedToolStripButton_Click);
            // 
            // GroupAssignment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.unAssignedToolStrip);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Name = "GroupAssignment";
            this.Text = "GroupAssignment";
            this.Load += new System.EventHandler(this.GroupAssignment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.praktika2DataSet4BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.praktika2DataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userTableBindingSource)).EndInit();
            this.unAssignedToolStrip.ResumeLayout(false);
            this.unAssignedToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.BindingSource praktika2DataSet4BindingSource;
        private Praktika2DataSet4 praktika2DataSet4;
        private System.Windows.Forms.BindingSource groupsBindingSource;
        private Praktika2DataSet4TableAdapters.GroupsTableAdapter groupsTableAdapter;
        private System.Windows.Forms.BindingSource userTableBindingSource;
        private Praktika2DataSet4TableAdapters.UserTableTableAdapter userTableTableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStrip unAssignedToolStrip;
        private System.Windows.Forms.ToolStripButton unAssignedToolStripButton;
    }
}