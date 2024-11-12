namespace FirstWinForm
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
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblPwd = new System.Windows.Forms.Label();
            this.txtPwd = new System.Windows.Forms.TextBox();
            this.btn_Click = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(46, 45);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(57, 13);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "UserName";
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtName.ForeColor = System.Drawing.SystemColors.Highlight;
            this.txtName.Location = new System.Drawing.Point(198, 32);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(185, 20);
            this.txtName.TabIndex = 1;
            this.txtName.Text = "Infinite Ltd.";
            // 
            // lblPwd
            // 
            this.lblPwd.AutoSize = true;
            this.lblPwd.Location = new System.Drawing.Point(46, 104);
            this.lblPwd.Name = "lblPwd";
            this.lblPwd.Size = new System.Drawing.Size(53, 13);
            this.lblPwd.TabIndex = 2;
            this.lblPwd.Text = "Password";
            // 
            // txtPwd
            // 
            this.txtPwd.Location = new System.Drawing.Point(198, 97);
            this.txtPwd.Name = "txtPwd";
            this.txtPwd.Size = new System.Drawing.Size(185, 20);
            this.txtPwd.TabIndex = 3;
            // 
            // btn_Click
            // 
            this.btn_Click.Location = new System.Drawing.Point(181, 187);
            this.btn_Click.Name = "btn_Click";
            this.btn_Click.Size = new System.Drawing.Size(75, 23);
            this.btn_Click.TabIndex = 4;
            this.btn_Click.Text = "Click Me";
            this.btn_Click.UseVisualStyleBackColor = true;
            this.btn_Click.Click += new System.EventHandler(this.btn_Click_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(308, 187);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(184, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Click for Form 2";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(938, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_Click);
            this.Controls.Add(this.txtPwd);
            this.Controls.Add(this.lblPwd);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblPwd;
        private System.Windows.Forms.TextBox txtPwd;
        private System.Windows.Forms.Button btn_Click;
        private System.Windows.Forms.Button button1;
    }
}

