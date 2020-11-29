namespace StudentMIS
{
    partial class Login
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
            this.myDefaultBtn = new System.Windows.Forms.Button();
            this.myCancelBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxUsr = new System.Windows.Forms.TextBox();
            this.tbxPwd = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // myDefaultBtn
            // 
            this.myDefaultBtn.Location = new System.Drawing.Point(58, 140);
            this.myDefaultBtn.Name = "myDefaultBtn";
            this.myDefaultBtn.Size = new System.Drawing.Size(75, 23);
            this.myDefaultBtn.TabIndex = 0;
            this.myDefaultBtn.Text = "登录";
            this.myDefaultBtn.UseVisualStyleBackColor = true;
            this.myDefaultBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // myCancelBtn
            // 
            this.myCancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.myCancelBtn.Location = new System.Drawing.Point(170, 140);
            this.myCancelBtn.Name = "myCancelBtn";
            this.myCancelBtn.Size = new System.Drawing.Size(75, 23);
            this.myCancelBtn.TabIndex = 1;
            this.myCancelBtn.Text = "重写";
            this.myCancelBtn.UseVisualStyleBackColor = true;
            this.myCancelBtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(86, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "用户名";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(88, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "密码";
            // 
            // tbxUsr
            // 
            this.tbxUsr.Location = new System.Drawing.Point(145, 42);
            this.tbxUsr.Name = "tbxUsr";
            this.tbxUsr.Size = new System.Drawing.Size(100, 21);
            this.tbxUsr.TabIndex = 4;
            this.tbxUsr.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // tbxPwd
            // 
            this.tbxPwd.Location = new System.Drawing.Point(145, 76);
            this.tbxPwd.Name = "tbxPwd";
            this.tbxPwd.PasswordChar = '*';
            this.tbxPwd.Size = new System.Drawing.Size(100, 21);
            this.tbxPwd.TabIndex = 5;
            this.tbxPwd.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // Login
            // 
            this.AcceptButton = this.myDefaultBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.myCancelBtn;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.tbxPwd);
            this.Controls.Add(this.tbxUsr);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.myCancelBtn);
            this.Controls.Add(this.myDefaultBtn);
            this.Name = "Login";
            this.Text = "登录";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button myDefaultBtn;
        private System.Windows.Forms.Button myCancelBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxUsr;
        private System.Windows.Forms.TextBox tbxPwd;
    }
}