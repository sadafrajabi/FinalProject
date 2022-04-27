namespace FinalProject
{
    partial class frmEditProforma
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
            this.lblSerialNoSearch = new System.Windows.Forms.Label();
            this.txtSerialNoSearch = new System.Windows.Forms.TextBox();
            this.txtCreatorName = new System.Windows.Forms.TextBox();
            this.lblCreatorName = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnEditExit = new System.Windows.Forms.Button();
            this.lblEditProforma = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblSerialNoSearch
            // 
            this.lblSerialNoSearch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSerialNoSearch.AutoSize = true;
            this.lblSerialNoSearch.Location = new System.Drawing.Point(285, 222);
            this.lblSerialNoSearch.Name = "lblSerialNoSearch";
            this.lblSerialNoSearch.Size = new System.Drawing.Size(56, 13);
            this.lblSerialNoSearch.TabIndex = 9;
            this.lblSerialNoSearch.Text = "Serial No :";
            // 
            // txtSerialNoSearch
            // 
            this.txtSerialNoSearch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtSerialNoSearch.Location = new System.Drawing.Point(362, 210);
            this.txtSerialNoSearch.Multiline = true;
            this.txtSerialNoSearch.Name = "txtSerialNoSearch";
            this.txtSerialNoSearch.Size = new System.Drawing.Size(190, 35);
            this.txtSerialNoSearch.TabIndex = 8;
            // 
            // txtCreatorName
            // 
            this.txtCreatorName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCreatorName.Location = new System.Drawing.Point(362, 159);
            this.txtCreatorName.Multiline = true;
            this.txtCreatorName.Name = "txtCreatorName";
            this.txtCreatorName.Size = new System.Drawing.Size(190, 35);
            this.txtCreatorName.TabIndex = 7;
            // 
            // lblCreatorName
            // 
            this.lblCreatorName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCreatorName.AutoSize = true;
            this.lblCreatorName.Location = new System.Drawing.Point(263, 171);
            this.lblCreatorName.Name = "lblCreatorName";
            this.lblCreatorName.Size = new System.Drawing.Size(78, 13);
            this.lblCreatorName.TabIndex = 6;
            this.lblCreatorName.Text = "Creator Name :";
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSearch.Location = new System.Drawing.Point(339, 280);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 5;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // btnEditExit
            // 
            this.btnEditExit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEditExit.Location = new System.Drawing.Point(429, 280);
            this.btnEditExit.Name = "btnEditExit";
            this.btnEditExit.Size = new System.Drawing.Size(75, 23);
            this.btnEditExit.TabIndex = 10;
            this.btnEditExit.Text = "Exit";
            this.btnEditExit.UseVisualStyleBackColor = true;
            this.btnEditExit.Click += new System.EventHandler(this.btnEditExit_Click);
            // 
            // lblEditProforma
            // 
            this.lblEditProforma.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblEditProforma.AutoSize = true;
            this.lblEditProforma.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditProforma.Location = new System.Drawing.Point(333, 27);
            this.lblEditProforma.Name = "lblEditProforma";
            this.lblEditProforma.Size = new System.Drawing.Size(192, 31);
            this.lblEditProforma.TabIndex = 109;
            this.lblEditProforma.Text = "Edit Proforma";
            // 
            // frmEditProforma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 461);
            this.Controls.Add(this.lblEditProforma);
            this.Controls.Add(this.btnEditExit);
            this.Controls.Add(this.lblSerialNoSearch);
            this.Controls.Add(this.txtSerialNoSearch);
            this.Controls.Add(this.txtCreatorName);
            this.Controls.Add(this.lblCreatorName);
            this.Controls.Add(this.btnSearch);
            this.Name = "frmEditProforma";
            this.Text = "Edit Proforma";
            this.Load += new System.EventHandler(this.frmEditProforma_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSerialNoSearch;
        private System.Windows.Forms.TextBox txtSerialNoSearch;
        private System.Windows.Forms.TextBox txtCreatorName;
        private System.Windows.Forms.Label lblCreatorName;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnEditExit;
        private System.Windows.Forms.Label lblEditProforma;
    }
}