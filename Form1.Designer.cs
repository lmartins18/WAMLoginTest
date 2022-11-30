namespace WAMLoginTest
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.loginBtn = new System.Windows.Forms.Button();
            this.graphLbl = new System.Windows.Forms.Label();
            this.tokenLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // loginBtn
            // 
            this.loginBtn.Location = new System.Drawing.Point(53, 66);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(493, 23);
            this.loginBtn.TabIndex = 0;
            this.loginBtn.Text = "Login";
            this.loginBtn.UseVisualStyleBackColor = true;
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // graphLbl
            // 
            this.graphLbl.AutoSize = true;
            this.graphLbl.Location = new System.Drawing.Point(77, 27);
            this.graphLbl.Name = "graphLbl";
            this.graphLbl.Size = new System.Drawing.Size(0, 15);
            this.graphLbl.TabIndex = 1;
            // 
            // tokenLbl
            // 
            this.tokenLbl.AutoSize = true;
            this.tokenLbl.Location = new System.Drawing.Point(26, 27);
            this.tokenLbl.Name = "tokenLbl";
            this.tokenLbl.Size = new System.Drawing.Size(0, 15);
            this.tokenLbl.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 127);
            this.Controls.Add(this.tokenLbl);
            this.Controls.Add(this.graphLbl);
            this.Controls.Add(this.loginBtn);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button loginBtn;
        private Label graphLbl;
        private Label tokenLbl;
    }
}