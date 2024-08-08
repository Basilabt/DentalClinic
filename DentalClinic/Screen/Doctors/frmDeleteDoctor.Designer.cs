namespace DentalClinic.Screen.Doctors
{
    partial class frmDeleteDoctor
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtboxDoctorID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.ctrDoctorInfo1 = new DentalClinic.Controls.ctrDoctorInfo();
            this.ctrPersonInfo1 = new DentalClinic.Controls.ctrPersonInfo();
            this.btnDelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label2.Location = new System.Drawing.Point(12, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 9;
            this.label2.Text = "Doctor ID";
            // 
            // txtboxDoctorID
            // 
            this.txtboxDoctorID.Location = new System.Drawing.Point(91, 71);
            this.txtboxDoctorID.Name = "txtboxDoctorID";
            this.txtboxDoctorID.Size = new System.Drawing.Size(147, 20);
            this.txtboxDoctorID.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label1.Location = new System.Drawing.Point(246, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 29);
            this.label1.TabIndex = 7;
            this.label1.Text = "Delete Doctor";
            // 
            // btnSearch
            // 
            this.btnSearch.ForeColor = System.Drawing.Color.Black;
            this.btnSearch.Location = new System.Drawing.Point(244, 69);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 12;
            this.btnSearch.Text = "search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // ctrDoctorInfo1
            // 
            this.ctrDoctorInfo1.BackColor = System.Drawing.Color.White;
            this.ctrDoctorInfo1.Location = new System.Drawing.Point(-2, 332);
            this.ctrDoctorInfo1.Name = "ctrDoctorInfo1";
            this.ctrDoctorInfo1.Size = new System.Drawing.Size(695, 176);
            this.ctrDoctorInfo1.TabIndex = 13;
            // 
            // ctrPersonInfo1
            // 
            this.ctrPersonInfo1.Location = new System.Drawing.Point(12, 121);
            this.ctrPersonInfo1.Name = "ctrPersonInfo1";
            this.ctrPersonInfo1.Size = new System.Drawing.Size(685, 205);
            this.ctrPersonInfo1.TabIndex = 11;
            // 
            // btnDelete
            // 
            this.btnDelete.ForeColor = System.Drawing.Color.Black;
            this.btnDelete.Location = new System.Drawing.Point(244, 505);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(183, 32);
            this.btnDelete.TabIndex = 14;
            this.btnDelete.Text = "delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // frmDeleteDoctor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(705, 549);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.ctrDoctorInfo1);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.ctrPersonInfo1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtboxDoctorID);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "frmDeleteDoctor";
            this.Text = "Delete Doctor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Controls.ctrPersonInfo ctrPersonInfo1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtboxDoctorID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSearch;
        private Controls.ctrDoctorInfo ctrDoctorInfo1;
        private System.Windows.Forms.Button btnDelete;
    }
}