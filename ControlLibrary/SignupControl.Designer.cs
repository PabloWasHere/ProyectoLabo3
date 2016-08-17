namespace ControlLibrary
{
    partial class SignupControl
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
            this.btnSignup = new System.Windows.Forms.Button();
            this.lblSession = new System.Windows.Forms.Label();
            this.htbUser = new ControlLibrary.hintTextBox();
            this.htbPass = new ControlLibrary.hintTextBox();
            this.htbPassRe = new ControlLibrary.hintTextBox();
            this.htbMail = new ControlLibrary.hintTextBox();
            this.lblHint = new System.Windows.Forms.Label();
            this.lblWrongPass = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSignup
            // 
            this.btnSignup.Location = new System.Drawing.Point(106, 315);
            this.btnSignup.Name = "btnSignup";
            this.btnSignup.Size = new System.Drawing.Size(248, 31);
            this.btnSignup.TabIndex = 5;
            this.btnSignup.Text = "Registrarse";
            this.btnSignup.UseVisualStyleBackColor = true;
            this.btnSignup.Click += new System.EventHandler(this.btnSignup_Click);
            // 
            // lblSession
            // 
            this.lblSession.AutoSize = true;
            this.lblSession.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSession.Location = new System.Drawing.Point(165, 94);
            this.lblSession.Name = "lblSession";
            this.lblSession.Size = new System.Drawing.Size(131, 26);
            this.lblSession.TabIndex = 6;
            this.lblSession.Text = "Cuenta nueva";
            // 
            // htbUser
            // 
            this.htbUser.ForeColor = System.Drawing.Color.Gray;
            this.htbUser.Hint = "Hint my filling.";
            this.htbUser.Location = new System.Drawing.Point(106, 143);
            this.htbUser.Name = "htbUser";
            this.htbUser.PasswordTextbox = false;
            this.htbUser.Size = new System.Drawing.Size(248, 20);
            this.htbUser.TabIndex = 1;
            this.htbUser.Text = "Usuario";
            // 
            // htbPass
            // 
            this.htbPass.ForeColor = System.Drawing.Color.Gray;
            this.htbPass.Hint = "Hint my filling.";
            this.htbPass.Location = new System.Drawing.Point(106, 186);
            this.htbPass.Name = "htbPass";
            this.htbPass.PasswordTextbox = true;
            this.htbPass.Size = new System.Drawing.Size(248, 20);
            this.htbPass.TabIndex = 7;
            this.htbPass.Text = "Contraseña";
            // 
            // htbPassRe
            // 
            this.htbPassRe.ForeColor = System.Drawing.Color.Gray;
            this.htbPassRe.Hint = "Hint my filling.";
            this.htbPassRe.Location = new System.Drawing.Point(106, 229);
            this.htbPassRe.Name = "htbPassRe";
            this.htbPassRe.PasswordTextbox = true;
            this.htbPassRe.Size = new System.Drawing.Size(248, 20);
            this.htbPassRe.TabIndex = 8;
            this.htbPassRe.Text = "Repetir contraseña";
            // 
            // htbMail
            // 
            this.htbMail.ForeColor = System.Drawing.Color.Gray;
            this.htbMail.Hint = "Hint my filling.";
            this.htbMail.Location = new System.Drawing.Point(106, 272);
            this.htbMail.Name = "htbMail";
            this.htbMail.PasswordTextbox = false;
            this.htbMail.Size = new System.Drawing.Size(248, 20);
            this.htbMail.TabIndex = 9;
            this.htbMail.Text = "E-mail";
            // 
            // lblHint
            // 
            this.lblHint.AutoSize = true;
            this.lblHint.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblHint.Location = new System.Drawing.Point(104, 168);
            this.lblHint.Name = "lblHint";
            this.lblHint.Size = new System.Drawing.Size(253, 13);
            this.lblHint.TabIndex = 10;
            this.lblHint.Text = "* (Tu nombre publico podra ser cambiado mas tarde)";
            // 
            // lblWrongPass
            // 
            this.lblWrongPass.AutoSize = true;
            this.lblWrongPass.ForeColor = System.Drawing.Color.Red;
            this.lblWrongPass.Location = new System.Drawing.Point(106, 254);
            this.lblWrongPass.Name = "lblWrongPass";
            this.lblWrongPass.Size = new System.Drawing.Size(210, 13);
            this.lblWrongPass.TabIndex = 11;
            this.lblWrongPass.Text = "* Las contraseñas ingresadas no coinciden";
            this.lblWrongPass.Visible = false;
            // 
            // SignupControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblWrongPass);
            this.Controls.Add(this.lblHint);
            this.Controls.Add(this.htbMail);
            this.Controls.Add(this.htbPassRe);
            this.Controls.Add(this.htbPass);
            this.Controls.Add(this.lblSession);
            this.Controls.Add(this.btnSignup);
            this.Controls.Add(this.htbUser);
            this.Name = "SignupControl";
            this.Size = new System.Drawing.Size(460, 440);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private hintTextBox htbUser;
        private System.Windows.Forms.Button btnSignup;
        private System.Windows.Forms.Label lblSession;
        private hintTextBox htbPass;
        private hintTextBox htbPassRe;
        private hintTextBox htbMail;
        private System.Windows.Forms.Label lblHint;
        private System.Windows.Forms.Label lblWrongPass;
    }
}
