
namespace Programavimo_Praktika_2
{
    partial class LecturerStudentMarks
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.NewMarkButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(652, 159);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // NewMarkButton
            // 
            this.NewMarkButton.Location = new System.Drawing.Point(0, 168);
            this.NewMarkButton.Name = "NewMarkButton";
            this.NewMarkButton.Size = new System.Drawing.Size(104, 23);
            this.NewMarkButton.TabIndex = 1;
            this.NewMarkButton.Text = "New Mark";
            this.NewMarkButton.UseVisualStyleBackColor = true;
            // 
            // LecturerStudentMarks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.NewMarkButton);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "LecturerStudentMarks";
            this.Size = new System.Drawing.Size(654, 194);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button NewMarkButton;
    }
}
