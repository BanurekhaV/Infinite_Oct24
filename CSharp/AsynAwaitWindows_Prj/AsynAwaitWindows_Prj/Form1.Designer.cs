namespace AsynAwaitWindows_Prj
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
            this.btn_Sync = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btn_Async = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(163, 137);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 0;
            // 
            // btn_Sync
            // 
            this.btn_Sync.Location = new System.Drawing.Point(145, 186);
            this.btn_Sync.Name = "btn_Sync";
            this.btn_Sync.Size = new System.Drawing.Size(178, 23);
            this.btn_Sync.TabIndex = 1;
            this.btn_Sync.Text = "Synchronously";
            this.btn_Sync.UseVisualStyleBackColor = true;
            this.btn_Sync.Click += new System.EventHandler(this.btn_Sync_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(461, 118);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(394, 20);
            this.textBox1.TabIndex = 2;
            // 
            // btn_Async
            // 
            this.btn_Async.Location = new System.Drawing.Point(355, 186);
            this.btn_Async.Name = "btn_Async";
            this.btn_Async.Size = new System.Drawing.Size(189, 23);
            this.btn_Async.TabIndex = 3;
            this.btn_Async.Text = "Asynchronously";
            this.btn_Async.UseVisualStyleBackColor = true;
            this.btn_Async.Click += new System.EventHandler(this.btn_Async_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 450);
            this.Controls.Add(this.btn_Async);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btn_Sync);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Sync;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btn_Async;
    }
}

