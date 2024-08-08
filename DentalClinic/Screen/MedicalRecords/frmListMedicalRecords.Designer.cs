namespace DentalClinic.Screen.MedicalRecords
{
    partial class frmListMedicalRecords
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
            this.btnClose = new System.Windows.Forms.Button();
            this.dgvMedicalRecords = new System.Windows.Forms.DataGridView();
            this.txtboxPatientFullname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnDeleteMedicalRecord = new System.Windows.Forms.Button();
            this.btnAddMedicalRecord = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedicalRecords)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label1.Location = new System.Drawing.Point(494, 76);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 26);
            this.label1.TabIndex = 9;
            this.label1.Text = "Medical Records";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(1092, 541);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 27);
            this.btnClose.TabIndex = 7;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // dgvMedicalRecords
            // 
            this.dgvMedicalRecords.BackgroundColor = System.Drawing.Color.White;
            this.dgvMedicalRecords.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMedicalRecords.Location = new System.Drawing.Point(12, 230);
            this.dgvMedicalRecords.Name = "dgvMedicalRecords";
            this.dgvMedicalRecords.RowHeadersWidth = 51;
            this.dgvMedicalRecords.Size = new System.Drawing.Size(1155, 305);
            this.dgvMedicalRecords.TabIndex = 6;
            // 
            // txtboxPatientFullname
            // 
            this.txtboxPatientFullname.Location = new System.Drawing.Point(138, 192);
            this.txtboxPatientFullname.Name = "txtboxPatientFullname";
            this.txtboxPatientFullname.Size = new System.Drawing.Size(126, 20);
            this.txtboxPatientFullname.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(11, 192);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 16);
            this.label2.TabIndex = 13;
            this.label2.Text = "Patient Fullname";
            // 
            // btnSearch
            // 
            this.btnSearch.Image = global::DentalClinic.Properties.Resources.search;
            this.btnSearch.Location = new System.Drawing.Point(270, 179);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(49, 44);
            this.btnSearch.TabIndex = 14;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.UseWaitCursor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnDeleteMedicalRecord
            // 
            this.btnDeleteMedicalRecord.Image = global::DentalClinic.Properties.Resources.trash;
            this.btnDeleteMedicalRecord.Location = new System.Drawing.Point(1067, 178);
            this.btnDeleteMedicalRecord.Name = "btnDeleteMedicalRecord";
            this.btnDeleteMedicalRecord.Size = new System.Drawing.Size(47, 45);
            this.btnDeleteMedicalRecord.TabIndex = 11;
            this.btnDeleteMedicalRecord.UseVisualStyleBackColor = true;
            this.btnDeleteMedicalRecord.UseWaitCursor = true;
            this.btnDeleteMedicalRecord.Click += new System.EventHandler(this.btnDeleteMedicalRecord_Click);
            // 
            // btnAddMedicalRecord
            // 
            this.btnAddMedicalRecord.Image = global::DentalClinic.Properties.Resources.add_friend;
            this.btnAddMedicalRecord.Location = new System.Drawing.Point(1120, 179);
            this.btnAddMedicalRecord.Name = "btnAddMedicalRecord";
            this.btnAddMedicalRecord.Size = new System.Drawing.Size(47, 45);
            this.btnAddMedicalRecord.TabIndex = 10;
            this.btnAddMedicalRecord.UseVisualStyleBackColor = true;
            this.btnAddMedicalRecord.UseWaitCursor = true;
            this.btnAddMedicalRecord.Click += new System.EventHandler(this.btnAddMedicalRecord_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DentalClinic.Properties.Resources.folder;
            this.pictureBox1.Location = new System.Drawing.Point(550, 11);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(54, 63);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // frmListMedicalRecords
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1179, 580);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtboxPatientFullname);
            this.Controls.Add(this.btnDeleteMedicalRecord);
            this.Controls.Add(this.btnAddMedicalRecord);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.dgvMedicalRecords);
            this.Name = "frmListMedicalRecords";
            this.Text = "Medical Records";
            this.Load += new System.EventHandler(this.frmListMedicalRecords_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedicalRecords)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDeleteMedicalRecord;
        private System.Windows.Forms.Button btnAddMedicalRecord;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DataGridView dgvMedicalRecords;
        private System.Windows.Forms.TextBox txtboxPatientFullname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSearch;
    }
}