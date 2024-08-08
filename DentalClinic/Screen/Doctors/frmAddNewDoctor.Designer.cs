namespace DentalClinic.Screen.Doctors
{
    partial class frmAddNewDoctor
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
            this.ctrAddNewDoctor1 = new DentalClinic.Controls.ctrAddNewDoctor();
            this.ctrAddNewPerson1 = new DentalClinic.Controls.ctrAddNewPerson();
            this.btnAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label1.Location = new System.Drawing.Point(375, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(248, 36);
            this.label1.TabIndex = 1;
            this.label1.Text = "Add New Doctor";
            // 
            // ctrAddNewDoctor1
            // 
            this.ctrAddNewDoctor1.BackColor = System.Drawing.Color.White;
            this.ctrAddNewDoctor1.Location = new System.Drawing.Point(12, 415);
            this.ctrAddNewDoctor1.Name = "ctrAddNewDoctor1";
            this.ctrAddNewDoctor1.Size = new System.Drawing.Size(979, 138);
            this.ctrAddNewDoctor1.TabIndex = 3;
            // 
            // ctrAddNewPerson1
            // 
            this.ctrAddNewPerson1.BackColor = System.Drawing.Color.White;
            this.ctrAddNewPerson1.Location = new System.Drawing.Point(-1, 49);
            this.ctrAddNewPerson1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ctrAddNewPerson1.Name = "ctrAddNewPerson1";
            this.ctrAddNewPerson1.Size = new System.Drawing.Size(1021, 359);
            this.ctrAddNewPerson1.TabIndex = 2;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(290, 573);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(456, 46);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // frmAddNewDoctor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1021, 630);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.ctrAddNewDoctor1);
            this.Controls.Add(this.ctrAddNewPerson1);
            this.Controls.Add(this.label1);
            this.Name = "frmAddNewDoctor";
            this.Text = "Add New Doctor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Controls.ctrAddNewPerson ctrAddNewPerson1;
        private Controls.ctrAddNewDoctor ctrAddNewDoctor1;
        private System.Windows.Forms.Button btnAdd;
    }
}