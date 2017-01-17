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
            this.passwordBox = new ControlLibrary.hintTextBox();
            this.userBox = new ControlLibrary.hintTextBox();
            this.SuspendLayout();
            // 
            // chbRememberMe
            // 
            this.chbRememberMe.AutoSize = true;
            this.chbRememberMe.Location = new System.Drawing.Point(106, 250);
            this.chbRememberMe.Name = "chbRememberMe";
            this.chbRememberMe.Size = new System.Drawing.Size(87, 17);
            this.chbRememberMe.TabIndex = 2;
            this.chbRememberMe.Text = "Recuerdame";
            this.chbRememberMe.UseVisualStyleBackColor = true;
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(264, 245);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(90, 26);
            this.btnLogin.TabIndex = 3;
            this.btnLogin.Text = "Ingresar";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // lnklblSignUp
            // 
            this.lnklblSignUp.AutoSize = true;
            this.lnklblSignUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnklblSignUp.Location = new System.Drawing.Point(144, 331);
            this.lnklblSignUp.Name = "lnklblSignUp";
            this.lnklblSignUp.Size = new System.Drawing.Size(172, 18);
            this.lnklblSignUp.TabIndex = 4;
            this.lnklblSignUp.TabStop = true;
            this.lnklblSignUp.Text = "O crea una nueva cuenta";
            this.lnklblSignUp.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnklblSignUp_LinkClicked);
            // 
            // lblSession
            // 
            this.lblSession.AutoSize = true;
            this.lblSession.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSession.Location = new System.Drawing.Point(158, 92);
            this.lblSession.Name = "lblSession";
            this.lblSession.Size = new System.Drawing.Size(145, 26);
            this.lblSession.TabIndex = 5;
            this.lblSession.Text = "Inicio de sesión";
            // 
            // passwordBox
            // 
            this.passwordBox.ForeColor = System.Drawing.Color.Gray;
            this.passwordBox.Hint = "Contraseña";
            this.passwordBox.Location = new System.Drawing.Point(106, 192);
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.PasswordTextbox = true;
            this.passwordBox.Size = new System.Drawing.Size(248, 20);
            this.passwordBox.TabIndex = 7;
            this.passwordBox.Text = "Contraseña";
            this.passwordBox.TextChanged += new System.EventHandler(this.passwordBox_TextChanged);
            // 
            // userBox
            // 
            this.userBox.ForeColor = System.Drawing.Color.Gray;
            this.userBox.Hint = "Usuario";
            this.userBox.Location = new System.Drawing.Point(106, 145);
            this.userBox.Name = "userBox";
            this.userBox.PasswordTextbox = false;
            this.userBox.Size = new System.Drawing.Size(248, 20);
            this.userBox.TabIndex = 6;
            this.userBox.Text = "Usuario";
            this.userBox.TextChanged += new System.EventHandler(this.userBox_TextChanged);
            // 
            // LoginControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.passwordBox);
            this.Controls.Add(this.userBox);
            this.Controls.Add(this.lnklblSignUp);
            this.Controls.Add(this.lblSession);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.chbRememberMe);
            this.Name = "LoginControl";
            this.Size = new System.Drawing.Size(460, 440);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chbRememberMe;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.LinkLabel lnklblSignUp;
        private System.Windows.Forms.Label lblSession;
        private hintTextBox userBox;
        private hintTextBox passwordBox;
    }
}
