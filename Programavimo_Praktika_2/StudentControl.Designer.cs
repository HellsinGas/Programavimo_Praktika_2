
namespace Programavimo_Praktika_2
{
    partial class StudentControl
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
            this.LecturesflowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.MarksflowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // LecturesflowLayoutPanel1
            // 
            this.LecturesflowLayoutPanel1.AutoScroll = true;
            this.LecturesflowLayoutPanel1.Location = new System.Drawing.Point(4, 4);
            this.LecturesflowLayoutPanel1.Name = "LecturesflowLayoutPanel1";
            this.LecturesflowLayoutPanel1.Size = new System.Drawing.Size(194, 276);
            this.LecturesflowLayoutPanel1.TabIndex = 0;
            // 
            // MarksflowLayoutPanel2
            // 
            this.MarksflowLayoutPanel2.AutoScroll = true;
            this.MarksflowLayoutPanel2.Location = new System.Drawing.Point(204, 4);
            this.MarksflowLayoutPanel2.Name = "MarksflowLayoutPanel2";
            this.MarksflowLayoutPanel2.Size = new System.Drawing.Size(492, 273);
            this.MarksflowLayoutPanel2.TabIndex = 1;
            // 
            // StudentControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.MarksflowLayoutPanel2);
            this.Controls.Add(this.LecturesflowLayoutPanel1);
            this.Name = "StudentControl";
            this.Size = new System.Drawing.Size(699, 280);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel LecturesflowLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel MarksflowLayoutPanel2;
    }
}
