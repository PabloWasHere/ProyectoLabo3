namespace ControlLibrary
{
    partial class LoginControl
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
            this.chbRememberMe = new System.Windows.Forms.CheckBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.lnklblSignUp = new System.Windows.Forms.LinkLabel();
            this.lblSession = new System.Windows.Forms.Label();
            this.hintTextBox2 = new ControlLibrary.hintTextBox();
            this.hintTextBox1 = new ControlLibrary.hintTextBox();
            this.SuspendLayout();
            // 
            // chbRememberMe
            // 
            this.chbRememberMe.AutoSize = true;
            this.chbRememberMe.Location = new System.Drawing.Point(101, 230);
            this.chbRememberMe.Name = "chbRememberMe";
            this.chbRememberMe.Size = new System.Drawing.Size(87, 17);
            this.chbRememberMe.TabIndex = 2;
            this.chbRememberMe.Text = "Recuerdame";
            this.chbRememberMe.UseVisualStyleBackColor = true;
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(259, 225);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(90, 26);
            this.btnLogin.TabIndex = 3;
            this.btnLogin.Text = "Ingresa";
            this.btnLogin.UseVisualStyleBackColor = true;
            // 
            // lnklblSignUp
            // 
            this.lnklblSignUp.AutoSize = true;
            this.lnklblSignUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnklblSignUp.Location = new System.Drawing.Point(139, 311);
            this.lnklblSignUp.Name = "lnklblSignUp";
            this.lnklblSignUp.Size = new System.Drawing.Size(172, 18);
            this.lnklblSignUp.TabIndex = 4;
            this.lnklblSignUp.TabStop = true;
            this.lnklblSignUp.Text = "O crea una nueva cuenta";
            // 
            // lblSession
            // 
            this.lblSession.AutoSize = true;
            this.lblSession.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSession.Location = new System.Drawing.Point(153, 72);
            this.lblSession.Name = "lblSession";
            this.lblSession.Size = new System.Drawing.Size(145, 26);
            this.lblSession.TabIndex = 5;
            this.lblSession.Text = "Inicio de sesión";
            this.lblSession.Click += new System.EventHandler(this.label1_Click);
            // 
            // hintTextBox2
            // 
            this.hintTextBox2.ForeColor = System.Drawing.Color.Gray;
            this.hintTextBox2.Hint = "Contraseña";
            this.hintTextBox2.Location = new System.Drawing.Point(101, 172);
            this.hintTextBox2.Name = "hintTextBox2";
            this.hintTextBox2.Size = new System.Drawing.Size(248, 20);
            this.hintTextBox2.TabIndex = 7;
            this.hintTextBox2.Text = "Contraseña";
            // 
            // hintTextBox1
            // 
            this.hintTextBox1.ForeColor = System.Drawing.Color.Gray;
            this.hintTextBox1.Hint = "Usuario";
            this.hintTextBox1.Location = new System.Drawing.Point(101, 125);
            this.hintTextBox1.Name = "hintTextBox1";
            this.hintTextBox1.Size = new System.Drawing.Size(248, 20);
            this.hintTextBox1.TabIndex = 6;
            this.hintTextBox1.Text = "Usuario";
            this.hintTextBox1.Leave += new System.EventHandler(this.hintTextBox1_Leave);
            // 
            // LoginControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.hintTextBox2);
            this.Controls.Add(this.hintTextBox1);
            this.Controls.Add(this.lnklblSignUp);
            this.Controls.Add(this.lblSession);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.chbRememberMe);
            this.Name = "LoginControl";
            this.Size = new System.Drawing.Size(460, 440);
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chbRememberMe;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.LinkLabel lnklblSignUp;
        private System.Windows.Forms.Label lblSession;
        private hintTextBox hintTextBox1;
        private hintTextBox hintTextBox2;
    }
}
