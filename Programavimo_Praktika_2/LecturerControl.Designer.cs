
namespace Programavimo_Praktika_2
{
    partial class LecturerControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.LecturesLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.GroupsLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.StudentsLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.MarksLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // LecturesLayoutPanel1
            // 
            this.LecturesLayoutPanel1.AutoScroll = true;
            this.LecturesLayoutPanel1.Location = new System.Drawing.Point(0, 4);
            this.LecturesLayoutPanel1.Name = "LecturesLayoutPanel1";
            this.LecturesLayoutPanel1.Size = new System.Drawing.Size(154, 381);
            this.LecturesLayoutPanel1.TabIndex = 0;
            // 
            // GroupsLayoutPanel2
            // 
            this.GroupsLayoutPanel2.AutoScroll = true;
            this.GroupsLayoutPanel2.Location = new System.Drawing.Point(161, 4);
            this.GroupsLayoutPanel2.Name = "GroupsLayoutPanel2";
            this.GroupsLayoutPanel2.Size = new System.Drawing.Size(192, 384);
            this.GroupsLayoutPanel2.TabIndex = 1;
            // 
            // StudentsLayoutPanel3
            // 
            this.StudentsLayoutPanel3.AutoScroll = true;
            this.StudentsLayoutPanel3.Location = new System.Drawing.Point(360, 0);
            this.StudentsLayoutPanel3.Name = "StudentsLayoutPanel3";
            this.StudentsLayoutPanel3.Size = new System.Drawing.Size(329, 388);
            this.StudentsLayoutPanel3.TabIndex = 2;
            // 
            // MarksLayoutPanel4
            // 
            this.MarksLayoutPanel4.AutoScroll = true;
            this.MarksLayoutPanel4.Location = new System.Drawing.Point(695, 0);
            this.MarksLayoutPanel4.Name = "MarksLayoutPanel4";
            this.MarksLayoutPanel4.Size = new System.Drawing.Size(169, 385);
            this.MarksLayoutPanel4.TabIndex = 3;
            // 
            // LecturerControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.MarksLayoutPanel4);
            this.Controls.Add(this.StudentsLayoutPanel3);
            this.Controls.Add(this.GroupsLayoutPanel2);
            this.Controls.Add(this.LecturesLayoutPanel1);
            this.Name = "LecturerControl";
            this.Size = new System.Drawing.Size(1042, 388);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel LecturesLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel GroupsLayoutPanel2;
        private System.Windows.Forms.FlowLayoutPanel StudentsLayoutPanel3;
        private System.Windows.Forms.FlowLayoutPanel MarksLayoutPanel4;
    }
}
