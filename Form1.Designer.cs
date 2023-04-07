namespace Lenny_s
{
    partial class Form1
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
            this.BasicRadioButton = new System.Windows.Forms.RadioButton();
            this.PremiumRadioButton = new System.Windows.Forms.RadioButton();
            this.UltraRadioButton = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.VacuumCheckBox = new System.Windows.Forms.CheckBox();
            this.TireShineCheckBox = new System.Windows.Forms.CheckBox();
            this.WaxOnCheckBox = new System.Windows.Forms.CheckBox();
            this.AirFreshenerCheckBox = new System.Windows.Forms.CheckBox();
            this.FinalizeSelection = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(48, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(292, 39);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select your Wash:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // BasicRadioButton
            // 
            this.BasicRadioButton.AutoSize = true;
            this.BasicRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BasicRadioButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BasicRadioButton.Location = new System.Drawing.Point(3, 3);
            this.BasicRadioButton.Name = "BasicRadioButton";
            this.BasicRadioButton.Size = new System.Drawing.Size(139, 17);
            this.BasicRadioButton.TabIndex = 2;
            this.BasicRadioButton.TabStop = true;
            this.BasicRadioButton.Text = "Basic Wash($10.00)";
            this.BasicRadioButton.UseVisualStyleBackColor = true;
            this.BasicRadioButton.CheckedChanged += new System.EventHandler(this.BasicRadioButton_CheckedChanged);
            // 
            // PremiumRadioButton
            // 
            this.PremiumRadioButton.AutoSize = true;
            this.PremiumRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PremiumRadioButton.ForeColor = System.Drawing.SystemColors.Window;
            this.PremiumRadioButton.Location = new System.Drawing.Point(3, 37);
            this.PremiumRadioButton.Name = "PremiumRadioButton";
            this.PremiumRadioButton.Size = new System.Drawing.Size(155, 17);
            this.PremiumRadioButton.TabIndex = 3;
            this.PremiumRadioButton.TabStop = true;
            this.PremiumRadioButton.Text = "Premium Wash($15.00)";
            this.PremiumRadioButton.UseVisualStyleBackColor = true;
            this.PremiumRadioButton.CheckedChanged += new System.EventHandler(this.PremiumRadioButton_CheckedChanged);
            // 
            // UltraRadioButton
            // 
            this.UltraRadioButton.AutoSize = true;
            this.UltraRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UltraRadioButton.ForeColor = System.Drawing.SystemColors.Window;
            this.UltraRadioButton.Location = new System.Drawing.Point(3, 80);
            this.UltraRadioButton.Name = "UltraRadioButton";
            this.UltraRadioButton.Size = new System.Drawing.Size(135, 17);
            this.UltraRadioButton.TabIndex = 4;
            this.UltraRadioButton.TabStop = true;
            this.UltraRadioButton.Text = "Ultra Wash($20.00)";
            this.UltraRadioButton.UseVisualStyleBackColor = true;
            this.UltraRadioButton.CheckedChanged += new System.EventHandler(this.UltraRadioButton_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(55)))));
            this.panel1.Controls.Add(this.BasicRadioButton);
            this.panel1.Controls.Add(this.UltraRadioButton);
            this.panel1.Controls.Add(this.PremiumRadioButton);
            this.panel1.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel1.Location = new System.Drawing.Point(55, 142);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(555, 121);
            this.panel1.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Window;
            this.label2.Location = new System.Drawing.Point(51, 269);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(177, 39);
            this.label2.TabIndex = 6;
            this.label2.Text = "Add Ons?:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(55)))));
            this.panel2.Controls.Add(this.VacuumCheckBox);
            this.panel2.Controls.Add(this.TireShineCheckBox);
            this.panel2.Controls.Add(this.WaxOnCheckBox);
            this.panel2.Controls.Add(this.AirFreshenerCheckBox);
            this.panel2.ForeColor = System.Drawing.SystemColors.Window;
            this.panel2.Location = new System.Drawing.Point(55, 311);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(555, 83);
            this.panel2.TabIndex = 7;
            // 
            // VacuumCheckBox
            // 
            this.VacuumCheckBox.AutoSize = true;
            this.VacuumCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VacuumCheckBox.ForeColor = System.Drawing.SystemColors.Window;
            this.VacuumCheckBox.Location = new System.Drawing.Point(189, 48);
            this.VacuumCheckBox.Name = "VacuumCheckBox";
            this.VacuumCheckBox.Size = new System.Drawing.Size(161, 17);
            this.VacuumCheckBox.TabIndex = 3;
            this.VacuumCheckBox.Text = "Vacuum Add-On ($2.00)";
            this.VacuumCheckBox.UseVisualStyleBackColor = true;
            this.VacuumCheckBox.CheckedChanged += new System.EventHandler(this.VacuumCheckBox_CheckedChanged);
            // 
            // TireShineCheckBox
            // 
            this.TireShineCheckBox.AutoSize = true;
            this.TireShineCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TireShineCheckBox.ForeColor = System.Drawing.SystemColors.Window;
            this.TireShineCheckBox.Location = new System.Drawing.Point(189, 14);
            this.TireShineCheckBox.Name = "TireShineCheckBox";
            this.TireShineCheckBox.Size = new System.Drawing.Size(188, 17);
            this.TireShineCheckBox.TabIndex = 2;
            this.TireShineCheckBox.Text = "Wheel Shine Add-On ($5.00)";
            this.TireShineCheckBox.UseVisualStyleBackColor = true;
            this.TireShineCheckBox.CheckedChanged += new System.EventHandler(this.TireShineCheckBox_CheckedChanged);
            // 
            // WaxOnCheckBox
            // 
            this.WaxOnCheckBox.AutoSize = true;
            this.WaxOnCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WaxOnCheckBox.Location = new System.Drawing.Point(3, 48);
            this.WaxOnCheckBox.Name = "WaxOnCheckBox";
            this.WaxOnCheckBox.Size = new System.Drawing.Size(161, 17);
            this.WaxOnCheckBox.TabIndex = 1;
            this.WaxOnCheckBox.Text = "Wax On Add-On ($5.00)";
            this.WaxOnCheckBox.UseVisualStyleBackColor = true;
            this.WaxOnCheckBox.CheckedChanged += new System.EventHandler(this.WaxOnCheckBox_CheckedChanged);
            // 
            // AirFreshenerCheckBox
            // 
            this.AirFreshenerCheckBox.AutoSize = true;
            this.AirFreshenerCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AirFreshenerCheckBox.Location = new System.Drawing.Point(3, 14);
            this.AirFreshenerCheckBox.Name = "AirFreshenerCheckBox";
            this.AirFreshenerCheckBox.Size = new System.Drawing.Size(191, 17);
            this.AirFreshenerCheckBox.TabIndex = 0;
            this.AirFreshenerCheckBox.Text = "Air Freshener Add-On ($2.00)";
            this.AirFreshenerCheckBox.UseVisualStyleBackColor = true;
            this.AirFreshenerCheckBox.CheckedChanged += new System.EventHandler(this.AirFreshenerCheckBox_CheckedChanged);
            // 
            // FinalizeSelection
            // 
            this.FinalizeSelection.AccessibleName = "";
            this.FinalizeSelection.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(153)))), ((int)(((byte)(119)))));
            this.FinalizeSelection.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FinalizeSelection.ForeColor = System.Drawing.SystemColors.Window;
            this.FinalizeSelection.Location = new System.Drawing.Point(204, 430);
            this.FinalizeSelection.Name = "FinalizeSelection";
            this.FinalizeSelection.Size = new System.Drawing.Size(202, 39);
            this.FinalizeSelection.TabIndex = 8;
            this.FinalizeSelection.Text = "Finalize Selections";
            this.FinalizeSelection.UseVisualStyleBackColor = false;
            this.FinalizeSelection.Click += new System.EventHandler(this.FinalizeSelection_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.CadetBlue;
            this.label3.Location = new System.Drawing.Point(45, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(591, 76);
            this.label3.TabIndex = 9;
            this.label3.Text = "Lenny\'s Car Wash";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(33)))));
            this.ClientSize = new System.Drawing.Size(710, 522);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.FinalizeSelection);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton BasicRadioButton;
        private System.Windows.Forms.RadioButton PremiumRadioButton;
        private System.Windows.Forms.RadioButton UltraRadioButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.CheckBox VacuumCheckBox;
        private System.Windows.Forms.CheckBox TireShineCheckBox;
        private System.Windows.Forms.CheckBox WaxOnCheckBox;
        private System.Windows.Forms.CheckBox AirFreshenerCheckBox;
        private System.Windows.Forms.Button FinalizeSelection;
        private System.Windows.Forms.Label label3;
    }
}

