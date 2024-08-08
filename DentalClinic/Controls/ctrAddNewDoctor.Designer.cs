namespace DentalClinic.Controls
{
    partial class ctrAddNewDoctor
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
            this.groupboxAddNewDoctor = new System.Windows.Forms.GroupBox();
            this.txtboxSpecialization = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupboxAddNewDoctor.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupboxAddNewDoctor
            // 
            this.groupboxAddNewDoctor.Controls.Add(this.txtboxSpecialization);
            this.groupboxAddNewDoctor.Controls.Add(this.label1);
            this.groupboxAddNewDoctor.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupboxAddNewDoctor.ForeColor = System.Drawing.Color.DodgerBlue;
            this.groupboxAddNewDoctor.Location = new System.Drawing.Point(13, 14);
            this.groupboxAddNewDoctor.Name = "groupboxAddNewDoctor";
            this.groupboxAddNewDoctor.Size = new System.Drawing.Size(964, 111);
            this.groupboxAddNewDoctor.TabIndex = 0;
            this.groupboxAddNewDoctor.TabStop = false;
            this.groupboxAddNewDoctor.Text = "Add New Doctor";
            // 
            // txtboxSpecialization
            // 
            this.txtboxSpecialization.Location = new System.Drawing.Point(128, 50);
            this.txtboxSpecialization.Margin = new System.Windows.Forms.Padding(4);
            this.txtboxSpecialization.Name = "txtboxSpecialization";
            this.txtboxSpecialization.Size = new System.Drawing.Size(165, 34);
            this.txtboxSpecialization.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkGray;
            this.label1.Location = new System.Drawing.Point(7, 61);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 18);
            this.label1.TabIndex = 10;
            this.label1.Text = "Specialization";
            // 
            // ctrAddNewDoctor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.groupboxAddNewDoctor);
            this.Name = "ctrAddNewDoctor";
            this.Size = new System.Drawing.Size(994, 138);
            this.groupboxAddNewDoctor.ResumeLayout(false);
            this.groupboxAddNewDoctor.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupboxAddNewDoctor;
        private System.Windows.Forms.TextBox txtboxSpecialization;
        private System.Windows.Forms.Label label1;
    }
}
