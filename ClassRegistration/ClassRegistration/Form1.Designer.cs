namespace ClassRegistration
{
    partial class Form1
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
            this.btnCourse = new System.Windows.Forms.Button();
            this.btnSection = new System.Windows.Forms.Button();
            this.btnAddress = new System.Windows.Forms.Button();
            this.btnStudent = new System.Windows.Forms.Button();
            this.btnInstructor = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCourse
            // 
            this.btnCourse.Location = new System.Drawing.Point(111, 114);
            this.btnCourse.Name = "btnCourse";
            this.btnCourse.Size = new System.Drawing.Size(96, 40);
            this.btnCourse.TabIndex = 0;
            this.btnCourse.Text = "Test Course";
            this.btnCourse.UseVisualStyleBackColor = true;
            this.btnCourse.Click += new System.EventHandler(this.btnCourse_Click);
            // 
            // btnSection
            // 
            this.btnSection.Location = new System.Drawing.Point(241, 114);
            this.btnSection.Name = "btnSection";
            this.btnSection.Size = new System.Drawing.Size(101, 40);
            this.btnSection.TabIndex = 1;
            this.btnSection.Text = "Test Section";
            this.btnSection.UseVisualStyleBackColor = true;
            this.btnSection.Click += new System.EventHandler(this.btnSection_Click);
            // 
            // btnAddress
            // 
            this.btnAddress.Location = new System.Drawing.Point(378, 114);
            this.btnAddress.Name = "btnAddress";
            this.btnAddress.Size = new System.Drawing.Size(107, 40);
            this.btnAddress.TabIndex = 2;
            this.btnAddress.Text = "Test Address";
            this.btnAddress.UseVisualStyleBackColor = true;
            this.btnAddress.Click += new System.EventHandler(this.btnAddress_Click);
            // 
            // btnStudent
            // 
            this.btnStudent.Location = new System.Drawing.Point(177, 208);
            this.btnStudent.Name = "btnStudent";
            this.btnStudent.Size = new System.Drawing.Size(175, 90);
            this.btnStudent.TabIndex = 3;
            this.btnStudent.Text = "Test Student";
            this.btnStudent.UseVisualStyleBackColor = true;
            this.btnStudent.Click += new System.EventHandler(this.btnStudent_Click);
            // 
            // btnInstructor
            // 
            this.btnInstructor.Location = new System.Drawing.Point(433, 208);
            this.btnInstructor.Name = "btnInstructor";
            this.btnInstructor.Size = new System.Drawing.Size(179, 90);
            this.btnInstructor.TabIndex = 4;
            this.btnInstructor.Text = "Test Instructor";
            this.btnInstructor.UseVisualStyleBackColor = true;
            this.btnInstructor.Click += new System.EventHandler(this.btnInstructor_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnInstructor);
            this.Controls.Add(this.btnStudent);
            this.Controls.Add(this.btnAddress);
            this.Controls.Add(this.btnSection);
            this.Controls.Add(this.btnCourse);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCourse;
        private System.Windows.Forms.Button btnSection;
        private System.Windows.Forms.Button btnAddress;
        private System.Windows.Forms.Button btnStudent;
        private System.Windows.Forms.Button btnInstructor;
    }
}

