namespace StudentAdministration
{
    partial class StudentForm
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
            this.lstStudents = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAddStudent = new System.Windows.Forms.Button();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.grpStudents = new System.Windows.Forms.GroupBox();
            this.btnEditStudent = new System.Windows.Forms.Button();
            this.btnDeleteStudent = new System.Windows.Forms.Button();
            this.grpGrading = new System.Windows.Forms.GroupBox();
            this.lblGrade = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSetGrade = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.nudAnalysis = new System.Windows.Forms.NumericUpDown();
            this.nudDesign = new System.Windows.Forms.NumericUpDown();
            this.nudCode = new System.Windows.Forms.NumericUpDown();
            this.groupBox1.SuspendLayout();
            this.grpStudents.SuspendLayout();
            this.grpGrading.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAnalysis)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDesign)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCode)).BeginInit();
            this.SuspendLayout();
            // 
            // lstStudents
            // 
            this.lstStudents.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstStudents.FormattingEnabled = true;
            this.lstStudents.Location = new System.Drawing.Point(6, 19);
            this.lstStudents.Name = "lstStudents";
            this.lstStudents.Size = new System.Drawing.Size(298, 95);
            this.lstStudents.TabIndex = 0;
            this.lstStudents.SelectedIndexChanged += new System.EventHandler(this.lstStudents_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAddStudent);
            this.groupBox1.Controls.Add(this.txtEmail);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Location = new System.Drawing.Point(12, 173);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(310, 102);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add new/update student";
            // 
            // btnAddStudent
            // 
            this.btnAddStudent.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddStudent.Location = new System.Drawing.Point(59, 71);
            this.btnAddStudent.Name = "btnAddStudent";
            this.btnAddStudent.Size = new System.Drawing.Size(245, 23);
            this.btnAddStudent.TabIndex = 4;
            this.btnAddStudent.Text = "Add new/update student";
            this.btnAddStudent.UseVisualStyleBackColor = true;
            this.btnAddStudent.Click += new System.EventHandler(this.btnAddStudent_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEmail.Location = new System.Drawing.Point(59, 45);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(245, 20);
            this.txtEmail.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Email:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Name:";
            // 
            // txtName
            // 
            this.txtName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtName.Location = new System.Drawing.Point(59, 19);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(245, 20);
            this.txtName.TabIndex = 2;
            // 
            // grpStudents
            // 
            this.grpStudents.Controls.Add(this.btnEditStudent);
            this.grpStudents.Controls.Add(this.btnDeleteStudent);
            this.grpStudents.Controls.Add(this.lstStudents);
            this.grpStudents.Location = new System.Drawing.Point(12, 12);
            this.grpStudents.Name = "grpStudents";
            this.grpStudents.Size = new System.Drawing.Size(310, 155);
            this.grpStudents.TabIndex = 5;
            this.grpStudents.TabStop = false;
            this.grpStudents.Text = "Students";
            // 
            // btnEditStudent
            // 
            this.btnEditStudent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditStudent.Enabled = false;
            this.btnEditStudent.Location = new System.Drawing.Point(6, 120);
            this.btnEditStudent.Name = "btnEditStudent";
            this.btnEditStudent.Size = new System.Drawing.Size(140, 23);
            this.btnEditStudent.TabIndex = 2;
            this.btnEditStudent.Text = "Edit selected";
            this.btnEditStudent.UseVisualStyleBackColor = true;
            this.btnEditStudent.Click += new System.EventHandler(this.btnEditStudent_Click);
            // 
            // btnDeleteStudent
            // 
            this.btnDeleteStudent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeleteStudent.Enabled = false;
            this.btnDeleteStudent.Location = new System.Drawing.Point(164, 120);
            this.btnDeleteStudent.Name = "btnDeleteStudent";
            this.btnDeleteStudent.Size = new System.Drawing.Size(140, 23);
            this.btnDeleteStudent.TabIndex = 1;
            this.btnDeleteStudent.Text = "Delete selected";
            this.btnDeleteStudent.UseVisualStyleBackColor = true;
            this.btnDeleteStudent.Click += new System.EventHandler(this.btnDeleteStudent_Click);
            // 
            // grpGrading
            // 
            this.grpGrading.Controls.Add(this.nudCode);
            this.grpGrading.Controls.Add(this.nudDesign);
            this.grpGrading.Controls.Add(this.nudAnalysis);
            this.grpGrading.Controls.Add(this.lblGrade);
            this.grpGrading.Controls.Add(this.label5);
            this.grpGrading.Controls.Add(this.btnSetGrade);
            this.grpGrading.Controls.Add(this.label1);
            this.grpGrading.Controls.Add(this.label4);
            this.grpGrading.Enabled = false;
            this.grpGrading.Location = new System.Drawing.Point(12, 281);
            this.grpGrading.Name = "grpGrading";
            this.grpGrading.Size = new System.Drawing.Size(310, 126);
            this.grpGrading.TabIndex = 5;
            this.grpGrading.TabStop = false;
            this.grpGrading.Text = "Grading";
            // 
            // lblGrade
            // 
            this.lblGrade.AutoSize = true;
            this.lblGrade.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGrade.Location = new System.Drawing.Point(200, 19);
            this.lblGrade.Name = "lblGrade";
            this.lblGrade.Size = new System.Drawing.Size(69, 73);
            this.lblGrade.TabIndex = 7;
            this.lblGrade.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Code:";
            // 
            // btnSetGrade
            // 
            this.btnSetGrade.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSetGrade.Location = new System.Drawing.Point(59, 97);
            this.btnSetGrade.Name = "btnSetGrade";
            this.btnSetGrade.Size = new System.Drawing.Size(87, 23);
            this.btnSetGrade.TabIndex = 4;
            this.btnSetGrade.Text = "Set grade";
            this.btnSetGrade.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Design:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Analysis:";
            // 
            // nudAnalysis
            // 
            this.nudAnalysis.DecimalPlaces = 1;
            this.nudAnalysis.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.nudAnalysis.Location = new System.Drawing.Point(60, 20);
            this.nudAnalysis.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudAnalysis.Name = "nudAnalysis";
            this.nudAnalysis.Size = new System.Drawing.Size(86, 20);
            this.nudAnalysis.TabIndex = 8;
            // 
            // nudDesign
            // 
            this.nudDesign.DecimalPlaces = 1;
            this.nudDesign.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.nudDesign.Location = new System.Drawing.Point(60, 46);
            this.nudDesign.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudDesign.Name = "nudDesign";
            this.nudDesign.Size = new System.Drawing.Size(86, 20);
            this.nudDesign.TabIndex = 9;
            // 
            // nudCode
            // 
            this.nudCode.DecimalPlaces = 1;
            this.nudCode.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.nudCode.Location = new System.Drawing.Point(60, 71);
            this.nudCode.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudCode.Name = "nudCode";
            this.nudCode.Size = new System.Drawing.Size(86, 20);
            this.nudCode.TabIndex = 10;
            // 
            // StudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 418);
            this.Controls.Add(this.grpGrading);
            this.Controls.Add(this.grpStudents);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "StudentForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Student Administration";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grpStudents.ResumeLayout(false);
            this.grpGrading.ResumeLayout(false);
            this.grpGrading.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAnalysis)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDesign)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCode)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstStudents;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAddStudent;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.GroupBox grpStudents;
        private System.Windows.Forms.Button btnDeleteStudent;
        private System.Windows.Forms.Button btnEditStudent;
        private System.Windows.Forms.GroupBox grpGrading;
        private System.Windows.Forms.Button btnSetGrade;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblGrade;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown nudCode;
        private System.Windows.Forms.NumericUpDown nudDesign;
        private System.Windows.Forms.NumericUpDown nudAnalysis;
    }
}

