namespace ProjectManager
{
    partial class FormLogin
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
            this.signControl = new ControlLibrary.SignupControl();
            this.logControl = new ControlLibrary.LoginControl();
            this.SuspendLayout();
            // 
            // signControl
            // 
            this.signControl.EmailField = true;
            this.signControl.Location = new System.Drawing.Point(72, 418);
            this.signControl.Name = "signControl";
            this.signControl.Size = new System.Drawing.Size(460, 440);
            this.signControl.TabIndex = 1;
            this.signControl.UsernameHint = true;
            this.signControl.WrongPassword = false;
            this.signControl.SignupButtonClick += new System.EventHandler(this.signControl_SignupButtonClick);
            // 
            // logControl
            // 
            this.logControl.Location = new System.Drawing.Point(72, 30);
            this.logControl.Name = "logControl";
            this.logControl.Size = new System.Drawing.Size(460, 440);
            this.logControl.TabIndex = 0;
            this.logControl.LoginButtonClick += new System.EventHandler(this.logControl_LoginButtonClick);
            this.logControl.SignupLinkClick += new System.EventHandler(this.logControl_SignupLinkClick);
            this.logControl.Load += new System.EventHandler(this.logControl_Load);
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 516);
            this.Controls.Add(this.signControl);
            this.Controls.Add(this.logControl);
            this.Name = "FormLogin";
            this.Text = "FormLogin";
            this.Load += new System.EventHandler(this.FormLogin_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private ControlLibrary.LoginControl logControl;
        private ControlLibrary.SignupControl signControl;

    }
}