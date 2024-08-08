namespace DentalClinic.Controls
{
    partial class ctrAddNewAppointmnet
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.listboxSpecialization = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtboxLastName = new System.Windows.Forms.TextBox();
            this.txtboxThirdName = new System.Windows.Forms.TextBox();
            this.txtboxSecondName = new System.Windows.Forms.TextBox();
            this.txtboxFirstName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.appointmentDateTime = new System.Windows.Forms.DateTimePicker();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.appointmentDateTime);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.listboxSpecialization);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtboxLastName);
            this.groupBox1.Controls.Add(this.txtboxThirdName);
            this.groupBox1.Controls.Add(this.txtboxSecondName);
            this.groupBox1.Controls.Add(this.txtboxFirstName);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(874, 218);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add New Appointment";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkGray;
            this.label3.Location = new System.Drawing.Point(7, 133);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 18);
            this.label3.TabIndex = 33;
            this.label3.Text = "Date";
            // 
            // listboxSpecialization
            // 
            this.listboxSpecialization.FormattingEnabled = true;
            this.listboxSpecialization.ItemHeight = 16;
            this.listboxSpecialization.Items.AddRange(new object[] {
            "Periodontics",
            "Endodontics"});
            this.listboxSpecialization.Location = new System.Drawing.Point(145, 84);
            this.listboxSpecialization.Name = "listboxSpecialization";
            this.listboxSpecialization.Size = new System.Drawing.Size(112, 20);
            this.listboxSpecialization.TabIndex = 32;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkGray;
            this.label2.Location = new System.Drawing.Point(7, 84);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 18);
            this.label2.TabIndex = 31;
            this.label2.Text = "Specialization";
            // 
            // txtboxLastName
            // 
            this.txtboxLastName.Location = new System.Drawing.Point(583, 33);
            this.txtboxLastName.Margin = new System.Windows.Forms.Padding(4);
            this.txtboxLastName.Name = "txtboxLastName";
            this.txtboxLastName.Size = new System.Drawing.Size(129, 22);
            this.txtboxLastName.TabIndex = 30;
            this.txtboxLastName.Validating += new System.ComponentModel.CancelEventHandler(this.txtboxLastName_Validating);
            // 
            // txtboxThirdName
            // 
            this.txtboxThirdName.Location = new System.Drawing.Point(428, 33);
            this.txtboxThirdName.Margin = new System.Windows.Forms.Padding(4);
            this.txtboxThirdName.Name = "txtboxThirdName";
            this.txtboxThirdName.Size = new System.Drawing.Size(117, 22);
            this.txtboxThirdName.TabIndex = 29;
            this.txtboxThirdName.Validating += new System.ComponentModel.CancelEventHandler(this.txtboxThirdName_Validating);
            // 
            // txtboxSecondName
            // 
            this.txtboxSecondName.Location = new System.Drawing.Point(286, 33);
            this.txtboxSecondName.Margin = new System.Windows.Forms.Padding(4);
            this.txtboxSecondName.Name = "txtboxSecondName";
            this.txtboxSecondName.Size = new System.Drawing.Size(111, 22);
            this.txtboxSecondName.TabIndex = 28;
            this.txtboxSecondName.Validating += new System.ComponentModel.CancelEventHandler(this.txtboxSecondName_Validating);
            // 
            // txtboxFirstName
            // 
            this.txtboxFirstName.Location = new System.Drawing.Point(145, 33);
            this.txtboxFirstName.Margin = new System.Windows.Forms.Padding(4);
            this.txtboxFirstName.Name = "txtboxFirstName";
            this.txtboxFirstName.Size = new System.Drawing.Size(112, 22);
            this.txtboxFirstName.TabIndex = 27;
            this.txtboxFirstName.Validating += new System.ComponentModel.CancelEventHandler(this.txtboxFirstName_Validating);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DarkGray;
            this.label5.Location = new System.Drawing.Point(7, 37);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 18);
            this.label5.TabIndex = 26;
            this.label5.Text = "Fullname";
            // 
            // appointmentDateTime
            // 
            this.appointmentDateTime.Location = new System.Drawing.Point(145, 133);
            this.appointmentDateTime.Name = "appointmentDateTime";
            this.appointmentDateTime.Size = new System.Drawing.Size(252, 22);
            this.appointmentDateTime.TabIndex = 34;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // ctrAddNewAppointmnet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.groupBox1);
            this.Name = "ctrAddNewAppointmnet";
            this.Size = new System.Drawing.Size(909, 247);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker appointmentDateTime;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox listboxSpecialization;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtboxLastName;
        private System.Windows.Forms.TextBox txtboxThirdName;
        private System.Windows.Forms.TextBox txtboxSecondName;
        private System.Windows.Forms.TextBox txtboxFirstName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}
