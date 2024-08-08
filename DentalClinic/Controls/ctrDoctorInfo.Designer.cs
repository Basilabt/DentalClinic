namespace DentalClinic.Controls
{
    partial class ctrDoctorInfo
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
            this.groupboxDoctorInfo = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblDoctorName = new System.Windows.Forms.Label();
            this.lblSpecialization = new System.Windows.Forms.Label();
            this.groupboxDoctorInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupboxDoctorInfo
            // 
            this.groupboxDoctorInfo.Controls.Add(this.lblSpecialization);
            this.groupboxDoctorInfo.Controls.Add(this.lblDoctorName);
            this.groupboxDoctorInfo.Controls.Add(this.label2);
            this.groupboxDoctorInfo.Controls.Add(this.label1);
            this.groupboxDoctorInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupboxDoctorInfo.ForeColor = System.Drawing.Color.DodgerBlue;
            this.groupboxDoctorInfo.Location = new System.Drawing.Point(19, 14);
            this.groupboxDoctorInfo.Name = "groupboxDoctorInfo";
            this.groupboxDoctorInfo.Size = new System.Drawing.Size(670, 140);
            this.groupboxDoctorInfo.TabIndex = 0;
            this.groupboxDoctorInfo.TabStop = false;
            this.groupboxDoctorInfo.Text = "Doctor Info";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkGray;
            this.label1.Location = new System.Drawing.Point(6, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Doctor Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkGray;
            this.label2.Location = new System.Drawing.Point(6, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Specialization";
            // 
            // lblDoctorName
            // 
            this.lblDoctorName.AutoSize = true;
            this.lblDoctorName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDoctorName.ForeColor = System.Drawing.Color.Black;
            this.lblDoctorName.Location = new System.Drawing.Point(128, 43);
            this.lblDoctorName.Name = "lblDoctorName";
            this.lblDoctorName.Size = new System.Drawing.Size(77, 15);
            this.lblDoctorName.TabIndex = 6;
            this.lblDoctorName.Text = "First Name";
            // 
            // lblSpecialization
            // 
            this.lblSpecialization.AutoSize = true;
            this.lblSpecialization.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSpecialization.ForeColor = System.Drawing.Color.Black;
            this.lblSpecialization.Location = new System.Drawing.Point(128, 94);
            this.lblSpecialization.Name = "lblSpecialization";
            this.lblSpecialization.Size = new System.Drawing.Size(77, 15);
            this.lblSpecialization.TabIndex = 7;
            this.lblSpecialization.Text = "First Name";
            // 
            // ctrDoctorInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.groupboxDoctorInfo);
            this.Name = "ctrDoctorInfo";
            this.Size = new System.Drawing.Size(705, 176);
            this.groupboxDoctorInfo.ResumeLayout(false);
            this.groupboxDoctorInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupboxDoctorInfo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblSpecialization;
        private System.Windows.Forms.Label lblDoctorName;
    }
}
