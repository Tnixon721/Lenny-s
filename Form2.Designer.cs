namespace Lenny_s
{
    partial class Form2
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.totalCost = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ReceiptTextBlockA = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ReceiptTextBlockW = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(55)))));
            this.panel1.Controls.Add(this.totalCost);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.ReceiptTextBlockA);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.ReceiptTextBlockW);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(203, 90);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(472, 229);
            this.panel1.TabIndex = 2;
            // 
            // totalCost
            // 
            this.totalCost.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(66)))));
            this.totalCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalCost.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.totalCost.Location = new System.Drawing.Point(165, 206);
            this.totalCost.Multiline = true;
            this.totalCost.Name = "totalCost";
            this.totalCost.Size = new System.Drawing.Size(155, 20);
            this.totalCost.TabIndex = 6;
            this.totalCost.TextChanged += new System.EventHandler(this.totalCost_TextChanged);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(66)))));
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.label4.Location = new System.Drawing.Point(-3, 198);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(472, 31);
            this.label4.TabIndex = 5;
            this.label4.Text = "Total Cost:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // ReceiptTextBlockA
            // 
            this.ReceiptTextBlockA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(55)))));
            this.ReceiptTextBlockA.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReceiptTextBlockA.Location = new System.Drawing.Point(220, 143);
            this.ReceiptTextBlockA.Multiline = true;
            this.ReceiptTextBlockA.Name = "ReceiptTextBlockA";
            this.ReceiptTextBlockA.Size = new System.Drawing.Size(100, 14);
            this.ReceiptTextBlockA.TabIndex = 4;
            this.ReceiptTextBlockA.TextChanged += new System.EventHandler(this.ReceiptTextBlockA_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Window;
            this.label3.Location = new System.Drawing.Point(-4, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(282, 31);
            this.label3.TabIndex = 3;
            this.label3.Text = "Add Ons Purchased:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Window;
            this.label2.Location = new System.Drawing.Point(-4, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(218, 31);
            this.label2.TabIndex = 2;
            this.label2.Text = "Wash Selected:";
            // 
            // ReceiptTextBlockW
            // 
            this.ReceiptTextBlockW.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(55)))));
            this.ReceiptTextBlockW.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReceiptTextBlockW.ForeColor = System.Drawing.SystemColors.Window;
            this.ReceiptTextBlockW.Location = new System.Drawing.Point(220, 58);
            this.ReceiptTextBlockW.Multiline = true;
            this.ReceiptTextBlockW.Name = "ReceiptTextBlockW";
            this.ReceiptTextBlockW.Size = new System.Drawing.Size(100, 17);
            this.ReceiptTextBlockW.TabIndex = 1;
            this.ReceiptTextBlockW.TextChanged += new System.EventHandler(this.ReceiptTextBlockW_TextChanged);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(66)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(472, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Receipt";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(99)))), ((int)(((byte)(77)))));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.Window;
            this.button1.Location = new System.Drawing.Point(338, 356);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(146, 39);
            this.button1.TabIndex = 3;
            this.button1.Text = "New Order";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.CadetBlue;
            this.label5.Location = new System.Drawing.Point(172, -3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(591, 76);
            this.label5.TabIndex = 4;
            this.label5.Text = "Lenny\'s Car Wash";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(33)))));
            this.ClientSize = new System.Drawing.Size(924, 519);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox totalCost;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ReceiptTextBlockA;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ReceiptTextBlockW;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
    }
}