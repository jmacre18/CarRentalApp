
namespace CarRentalApp
{
    partial class AddEditVehicle
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tbLicenseNum = new System.Windows.Forms.TextBox();
            this.tbYear = new System.Windows.Forms.TextBox();
            this.tbVIN = new System.Windows.Forms.TextBox();
            this.tbModel = new System.Windows.Forms.TextBox();
            this.VINLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.makeLabel = new System.Windows.Forms.Label();
            this.yearLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbMake = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.titleLabel = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.tbLicenseNum, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.tbYear, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.tbVIN, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.tbModel, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.VINLabel, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.makeLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.yearLabel, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.tbMake, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 123);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(687, 264);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tbLicenseNum
            // 
            this.tbLicenseNum.Location = new System.Drawing.Point(346, 211);
            this.tbLicenseNum.Name = "tbLicenseNum";
            this.tbLicenseNum.Size = new System.Drawing.Size(210, 20);
            this.tbLicenseNum.TabIndex = 9;
            // 
            // tbYear
            // 
            this.tbYear.Location = new System.Drawing.Point(346, 159);
            this.tbYear.Name = "tbYear";
            this.tbYear.Size = new System.Drawing.Size(210, 20);
            this.tbYear.TabIndex = 8;
            // 
            // tbVIN
            // 
            this.tbVIN.Location = new System.Drawing.Point(346, 107);
            this.tbVIN.Name = "tbVIN";
            this.tbVIN.Size = new System.Drawing.Size(210, 20);
            this.tbVIN.TabIndex = 7;
            // 
            // tbModel
            // 
            this.tbModel.Location = new System.Drawing.Point(346, 55);
            this.tbModel.Name = "tbModel";
            this.tbModel.Size = new System.Drawing.Size(210, 20);
            this.tbModel.TabIndex = 6;
            // 
            // VINLabel
            // 
            this.VINLabel.AutoSize = true;
            this.VINLabel.Location = new System.Drawing.Point(3, 104);
            this.VINLabel.Name = "VINLabel";
            this.VINLabel.Size = new System.Drawing.Size(25, 13);
            this.VINLabel.TabIndex = 4;
            this.VINLabel.Text = "VIN";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Model";
            // 
            // makeLabel
            // 
            this.makeLabel.AutoSize = true;
            this.makeLabel.Location = new System.Drawing.Point(3, 0);
            this.makeLabel.Name = "makeLabel";
            this.makeLabel.Size = new System.Drawing.Size(34, 13);
            this.makeLabel.TabIndex = 0;
            this.makeLabel.Text = "Make";
            // 
            // yearLabel
            // 
            this.yearLabel.AutoSize = true;
            this.yearLabel.Location = new System.Drawing.Point(3, 156);
            this.yearLabel.Name = "yearLabel";
            this.yearLabel.Size = new System.Drawing.Size(29, 13);
            this.yearLabel.TabIndex = 3;
            this.yearLabel.Text = "Year";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 208);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "License Plate Number";
            // 
            // tbMake
            // 
            this.tbMake.Location = new System.Drawing.Point(346, 3);
            this.tbMake.Name = "tbMake";
            this.tbMake.Size = new System.Drawing.Size(210, 20);
            this.tbMake.TabIndex = 5;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(12, 396);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(311, 45);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Save Changes";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(388, 396);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(311, 45);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Monotype Corsiva", 36F, System.Drawing.FontStyle.Italic);
            this.titleLabel.Location = new System.Drawing.Point(203, 31);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(348, 57);
            this.titleLabel.TabIndex = 3;
            this.titleLabel.Text = "Add Rental Record";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(643, 52);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(0, 13);
            this.lblId.TabIndex = 4;
            this.lblId.Visible = false;
            // 
            // AddEditVehicle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(711, 453);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "AddEditVehicle";
            this.Text = "AddEditVehicle";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.TextBox tbLicenseNum;
        private System.Windows.Forms.TextBox tbYear;
        private System.Windows.Forms.TextBox tbVIN;
        private System.Windows.Forms.TextBox tbModel;
        private System.Windows.Forms.Label VINLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label makeLabel;
        private System.Windows.Forms.Label yearLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbMake;
        private System.Windows.Forms.Label lblId;
    }
}