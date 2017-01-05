namespace ControlLibrary
{
    partial class MasterDetailButtonList
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
            this.tbFilter = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.masterDetailItem1 = new ControlLibrary.MasterDetailItem();
            this.SuspendLayout();
            // 
            // tbFilter
            // 
            this.tbFilter.Location = new System.Drawing.Point(11, 11);
            this.tbFilter.Name = "tbFilter";
            this.tbFilter.Size = new System.Drawing.Size(257, 20);
            this.tbFilter.TabIndex = 0;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(274, 10);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(58, 20);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "Buscar";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // masterDetailItem1
            // 
            this.masterDetailItem1.ButtonDownImage = null;
            this.masterDetailItem1.FullDetail = null;
            this.masterDetailItem1.Id = 0;
            this.masterDetailItem1.Image = null;
            this.masterDetailItem1.Location = new System.Drawing.Point(11, 36);
            this.masterDetailItem1.Name = "masterDetailItem1";
            this.masterDetailItem1.Pressed = false;
            this.masterDetailItem1.ShortDetail = null;
            this.masterDetailItem1.Size = new System.Drawing.Size(321, 148);
            this.masterDetailItem1.TabIndex = 2;
            this.masterDetailItem1.Title = null;
            this.masterDetailItem1.Click += new System.EventHandler(this.masterDetailItem1_Click);
            // 
            // MasterDetailButtonList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.Controls.Add(this.masterDetailItem1);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.tbFilter);
            this.Name = "MasterDetailButtonList";
            this.Size = new System.Drawing.Size(343, 555);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbFilter;
        private System.Windows.Forms.Button btnSearch;
        private MasterDetailItem masterDetailItem1;

    }
}
