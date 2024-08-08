namespace DentalClinic.Screen.Patient
{
    partial class frmDeletePatient
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
            this.btnDelete = new System.Windows.Forms.Button();
            this.ctrPersonInfo1 = new DentalClinic.Controls.ctrPersonInfo();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtboxFirstName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtboxSecondName = new System.Windows.Forms.TextBox();
            this.txtboxThirdName = new System.Windows.Forms.TextBox();
            this.txtboxLastName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(246, 321);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(164, 32);
            this.btnDelete.TabIndex = 12;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // ctrPersonInfo1
            // 
            this.ctrPersonInfo1.Location = new System.Drawing.Point(12, 110);
            this.ctrPersonInfo1.Name = "ctrPersonInfo1";
            this.ctrPersonInfo1.Size = new System.Drawing.Size(680, 205);
            this.ctrPersonInfo1.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(477, 68);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 22);
            this.button1.TabIndex = 10;
            this.button1.Text = "search";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label2.Location = new System.Drawing.Point(12, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 9;
            this.label2.Text = "Fullname";
            // 
            // txtboxFirstName
            // 
            this.txtboxFirstName.Location = new System.Drawing.Point(91, 70);
            this.txtboxFirstName.Name = "txtboxFirstName";
            this.txtboxFirstName.Size = new System.Drawing.Size(80, 20);
            this.txtboxFirstName.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label1.Location = new System.Drawing.Point(266, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 29);
            this.label1.TabIndex = 7;
            this.label1.Text = "Delete Patient";
            // 
            // txtboxSecondName
            // 
            this.txtboxSecondName.Location = new System.Drawing.Point(188, 70);
            this.txtboxSecondName.Name = "txtboxSecondName";
            this.txtboxSecondName.Size = new System.Drawing.Size(80, 20);
            this.txtboxSecondName.TabIndex = 13;
            // 
            // txtboxThirdName
            // 
            this.txtboxThirdName.Location = new System.Drawing.Point(286, 70);
            this.txtboxThirdName.Name = "txtboxThirdName";
            this.txtboxThirdName.Size = new System.Drawing.Size(80, 20);
            this.txtboxThirdName.TabIndex = 14;
            // 
            // txtboxLastName
            // 
            this.txtboxLastName.Location = new System.Drawing.Point(382, 70);
            this.txtboxLastName.Name = "txtboxLastName";
            this.txtboxLastName.Size = new System.Drawing.Size(80, 20);
            this.txtboxLastName.TabIndex = 15;
            // 
            // frmDeletePatient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(695, 364);
            this.Controls.Add(this.txtboxLastName);
            this.Controls.Add(this.txtboxThirdName);
            this.Controls.Add(this.txtboxSecondName);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.ctrPersonInfo1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtboxFirstName);
            this.Controls.Add(this.label1);
            this.Name = "frmDeletePatient";
            this.Text = "Delete Patient";
            this.Load += new System.EventHandler(this.frmDeletePatient_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDelete;
        private Controls.ctrPersonInfo ctrPersonInfo1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtboxFirstName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtboxSecondName;
        private System.Windows.Forms.TextBox txtboxThirdName;
        private System.Windows.Forms.TextBox txtboxLastName;
    }
}