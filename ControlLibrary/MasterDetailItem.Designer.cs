namespace ControlLibrary
{
    partial class MasterDetailItem
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pbButton = new System.Windows.Forms.PictureBox();
            this.lblTittle = new System.Windows.Forms.Label();
            this.lblDetail = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbButton)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblDetail);
            this.panel1.Controls.Add(this.lblTittle);
            this.panel1.Controls.Add(this.pbButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(321, 148);
            this.panel1.TabIndex = 0;
            // 
            // pbButton
            // 
            this.pbButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbButton.Location = new System.Drawing.Point(0, 0);
            this.pbButton.Name = "pbButton";
            this.pbButton.Size = new System.Drawing.Size(321, 148);
            this.pbButton.TabIndex = 0;
            this.pbButton.TabStop = false;
            // 
            // lblTittle
            // 
            this.lblTittle.AutoSize = true;
            this.lblTittle.BackColor = System.Drawing.Color.Transparent;
            this.lblTittle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTittle.Location = new System.Drawing.Point(14, 14);
            this.lblTittle.Name = "lblTittle";
            this.lblTittle.Size = new System.Drawing.Size(50, 24);
            this.lblTittle.TabIndex = 1;
            this.lblTittle.Text = "Title";
            // 
            // lblDetail
            // 
            this.lblDetail.AutoSize = true;
            this.lblDetail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetail.Location = new System.Drawing.Point(18, 62);
            this.lblDetail.Name = "lblDetail";
            this.lblDetail.Size = new System.Drawing.Size(83, 16);
            this.lblDetail.TabIndex = 2;
            this.lblDetail.Text = "Some detail.";
            // 
            // MasterDetailItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "MasterDetailItem";
            this.Size = new System.Drawing.Size(321, 148);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbButton)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblDetail;
        private System.Windows.Forms.Label lblTittle;
        private System.Windows.Forms.PictureBox pbButton;
    }
}
