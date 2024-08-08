namespace DentalClinic.Screen.MedicalRecords
{
    partial class frmAddNewMedicalRecord
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddNewMedicalRecord = new System.Windows.Forms.Button();
            this.ctrAddNewPrescription1 = new DentalClinic.Controls.ctrAddNewPrescription();
            this.ctrAddNewMedicalRecord1 = new DentalClinic.Controls.ctrAddNewMedicalRecord();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label1.Location = new System.Drawing.Point(312, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(310, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Add New Medical Record";
            // 
            // btnAddNewMedicalRecord
            // 
            this.btnAddNewMedicalRecord.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNewMedicalRecord.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btnAddNewMedicalRecord.Location = new System.Drawing.Point(387, 502);
            this.btnAddNewMedicalRecord.Name = "btnAddNewMedicalRecord";
            this.btnAddNewMedicalRecord.Size = new System.Drawing.Size(154, 30);
            this.btnAddNewMedicalRecord.TabIndex = 4;
            this.btnAddNewMedicalRecord.Text = "Add";
            this.btnAddNewMedicalRecord.UseVisualStyleBackColor = true;
            this.btnAddNewMedicalRecord.Click += new System.EventHandler(this.btnAddNewMedicalRecord_Click);
            // 
            // ctrAddNewPrescription1
            // 
            this.ctrAddNewPrescription1.BackColor = System.Drawing.Color.White;
            this.ctrAddNewPrescription1.Location = new System.Drawing.Point(12, 279);
            this.ctrAddNewPrescription1.Name = "ctrAddNewPrescription1";
            this.ctrAddNewPrescription1.Size = new System.Drawing.Size(900, 207);
            this.ctrAddNewPrescription1.TabIndex = 3;
            // 
            // ctrAddNewMedicalRecord1
            // 
            this.ctrAddNewMedicalRecord1.BackColor = System.Drawing.Color.White;
            this.ctrAddNewMedicalRecord1.Location = new System.Drawing.Point(10, 41);
            this.ctrAddNewMedicalRecord1.Name = "ctrAddNewMedicalRecord1";
            this.ctrAddNewMedicalRecord1.Size = new System.Drawing.Size(919, 232);
            this.ctrAddNewMedicalRecord1.TabIndex = 2;
            // 
            // frmAddNewMedicalRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(941, 544);
            this.Controls.Add(this.btnAddNewMedicalRecord);
            this.Controls.Add(this.ctrAddNewPrescription1);
            this.Controls.Add(this.ctrAddNewMedicalRecord1);
            this.Controls.Add(this.label1);
            this.Name = "frmAddNewMedicalRecord";
            this.Text = "Add New Medical Record";
            this.Load += new System.EventHandler(this.frmAddNewMedicalRecord_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Controls.ctrAddNewMedicalRecord ctrAddNewMedicalRecord1;
        private Controls.ctrAddNewPrescription ctrAddNewPrescription1;
        private System.Windows.Forms.Button btnAddNewMedicalRecord;
    }
}