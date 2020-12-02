
namespace Programavimo_Praktika_2
{
    partial class AdminControl
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
            this.GroupControlButton = new System.Windows.Forms.Button();
            this.LectureControlButton = new System.Windows.Forms.Button();
            this.AcountControl = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.AssingLecturesbutt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // GroupControlButton
            // 
            this.GroupControlButton.Location = new System.Drawing.Point(3, 3);
            this.GroupControlButton.Name = "GroupControlButton";
            this.GroupControlButton.Size = new System.Drawing.Size(132, 42);
            this.GroupControlButton.TabIndex = 0;
            this.GroupControlButton.Text = "Group Control";
            this.GroupControlButton.UseVisualStyleBackColor = true;
            this.GroupControlButton.Click += new System.EventHandler(this.GroupControlButton_Click);
            // 
            // LectureControlButton
            // 
            this.LectureControlButton.Location = new System.Drawing.Point(3, 51);
            this.LectureControlButton.Name = "LectureControlButton";
            this.LectureControlButton.Size = new System.Drawing.Size(132, 44);
            this.LectureControlButton.TabIndex = 2;
            this.LectureControlButton.Text = "Lectures Control";
            this.LectureControlButton.UseVisualStyleBackColor = true;
            this.LectureControlButton.Click += new System.EventHandler(this.LectureControlButton_Click);
            // 
            // AcountControl
            // 
            this.AcountControl.Location = new System.Drawing.Point(3, 101);
            this.AcountControl.Name = "AcountControl";
            this.AcountControl.Size = new System.Drawing.Size(132, 44);
            this.AcountControl.TabIndex = 3;
            this.AcountControl.Text = "Account Control";
            this.AcountControl.UseVisualStyleBackColor = true;
            this.AcountControl.Click += new System.EventHandler(this.AcountControl_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(3, 201);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(132, 44);
            this.button3.TabIndex = 5;
            this.button3.Text = "Assign Groups";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(160, 4);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(418, 283);
            this.flowLayoutPanel1.TabIndex = 6;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Location = new System.Drawing.Point(584, 4);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(284, 280);
            this.flowLayoutPanel2.TabIndex = 7;
            // 
            // AssingLecturesbutt
            // 
            this.AssingLecturesbutt.Location = new System.Drawing.Point(3, 151);
            this.AssingLecturesbutt.Name = "AssingLecturesbutt";
            this.AssingLecturesbutt.Size = new System.Drawing.Size(132, 44);
            this.AssingLecturesbutt.TabIndex = 8;
            this.AssingLecturesbutt.Text = "Assign Lectures";
            this.AssingLecturesbutt.UseVisualStyleBackColor = true;
            this.AssingLecturesbutt.Click += new System.EventHandler(this.AssingLecturesbutt_Click);
            // 
            // AdminControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.AssingLecturesbutt);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.AcountControl);
            this.Controls.Add(this.LectureControlButton);
            this.Controls.Add(this.GroupControlButton);
            this.Name = "AdminControl";
            this.Size = new System.Drawing.Size(871, 287);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button GroupControlButton;
        private System.Windows.Forms.Button LectureControlButton;
        private System.Windows.Forms.Button AcountControl;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Button AssingLecturesbutt;
    }
}
