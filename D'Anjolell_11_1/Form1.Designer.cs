
namespace D_Anjolell_11_1
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
            this.lblName = new System.Windows.Forms.Label();
            this.lblNum = new System.Windows.Forms.Label();
            this.lblShift = new System.Windows.Forms.Label();
            this.lblPay = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtNum = new System.Windows.Forms.TextBox();
            this.txtShift = new System.Windows.Forms.TextBox();
            this.txtPay = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lblName.Location = new System.Drawing.Point(116, 37);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(137, 31);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Full Name";
            // 
            // lblNum
            // 
            this.lblNum.AutoSize = true;
            this.lblNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lblNum.Location = new System.Drawing.Point(116, 96);
            this.lblNum.Name = "lblNum";
            this.lblNum.Size = new System.Drawing.Size(237, 31);
            this.lblNum.TabIndex = 1;
            this.lblNum.Text = "Employee Number";
            // 
            // lblShift
            // 
            this.lblShift.AutoSize = true;
            this.lblShift.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lblShift.Location = new System.Drawing.Point(116, 159);
            this.lblShift.Name = "lblShift";
            this.lblShift.Size = new System.Drawing.Size(172, 31);
            this.lblShift.TabIndex = 2;
            this.lblShift.Text = "Shift Number";
            // 
            // lblPay
            // 
            this.lblPay.AutoSize = true;
            this.lblPay.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lblPay.Location = new System.Drawing.Point(116, 221);
            this.lblPay.Name = "lblPay";
            this.lblPay.Size = new System.Drawing.Size(126, 31);
            this.lblPay.TabIndex = 3;
            this.lblPay.Text = "Pay Rate";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.txtName.Location = new System.Drawing.Point(382, 34);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(291, 38);
            this.txtName.TabIndex = 4;
            // 
            // txtNum
            // 
            this.txtNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.txtNum.Location = new System.Drawing.Point(382, 93);
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(291, 38);
            this.txtNum.TabIndex = 5;
            // 
            // txtShift
            // 
            this.txtShift.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.txtShift.Location = new System.Drawing.Point(382, 156);
            this.txtShift.Name = "txtShift";
            this.txtShift.Size = new System.Drawing.Size(291, 38);
            this.txtShift.TabIndex = 6;
            // 
            // txtPay
            // 
            this.txtPay.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.txtPay.Location = new System.Drawing.Point(382, 218);
            this.txtPay.Name = "txtPay";
            this.txtPay.Size = new System.Drawing.Size(291, 38);
            this.txtPay.TabIndex = 7;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.btnSubmit.Location = new System.Drawing.Point(311, 283);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(120, 50);
            this.btnSubmit.TabIndex = 8;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 357);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txtPay);
            this.Controls.Add(this.txtShift);
            this.Controls.Add(this.txtNum);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblPay);
            this.Controls.Add(this.lblShift);
            this.Controls.Add(this.lblNum);
            this.Controls.Add(this.lblName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblNum;
        private System.Windows.Forms.Label lblShift;
        private System.Windows.Forms.Label lblPay;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtNum;
        private System.Windows.Forms.TextBox txtShift;
        private System.Windows.Forms.TextBox txtPay;
        private System.Windows.Forms.Button btnSubmit;
    }
}

