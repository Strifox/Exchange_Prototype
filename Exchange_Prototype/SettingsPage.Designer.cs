namespace Exchange_Prototype
{
    partial class SettingsPage
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
            this.components = new System.ComponentModel.Container();
            this.LBCommission = new System.Windows.Forms.Label();
            this.TxtBxCommission = new System.Windows.Forms.TextBox();
            this.exchangeControllerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.LBPercentage = new System.Windows.Forms.Label();
            this.BtnSave = new System.Windows.Forms.Button();
            this.BtnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.exchangeControllerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // LBCommission
            // 
            this.LBCommission.AutoSize = true;
            this.LBCommission.Location = new System.Drawing.Point(27, 29);
            this.LBCommission.Name = "LBCommission";
            this.LBCommission.Size = new System.Drawing.Size(62, 13);
            this.LBCommission.TabIndex = 0;
            this.LBCommission.Text = "Kommission";
            // 
            // TxtBxCommission
            // 
            this.TxtBxCommission.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.exchangeControllerBindingSource, "Commission", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "N0"));
            this.TxtBxCommission.Location = new System.Drawing.Point(95, 26);
            this.TxtBxCommission.Name = "TxtBxCommission";
            this.TxtBxCommission.Size = new System.Drawing.Size(31, 20);
            this.TxtBxCommission.TabIndex = 1;
            // 
            // exchangeControllerBindingSource
            // 
            this.exchangeControllerBindingSource.DataSource = typeof(Exchange_Prototype.Controllers.ExchangeController);
            // 
            // LBPercentage
            // 
            this.LBPercentage.AutoSize = true;
            this.LBPercentage.Location = new System.Drawing.Point(132, 29);
            this.LBPercentage.Name = "LBPercentage";
            this.LBPercentage.Size = new System.Drawing.Size(15, 13);
            this.LBPercentage.TabIndex = 2;
            this.LBPercentage.Text = "%";
            // 
            // BtnSave
            // 
            this.BtnSave.Location = new System.Drawing.Point(30, 93);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(124, 22);
            this.BtnSave.TabIndex = 3;
            this.BtnSave.Text = "Spara inställningar";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // BtnCancel
            // 
            this.BtnCancel.Location = new System.Drawing.Point(176, 93);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(124, 22);
            this.BtnCancel.TabIndex = 4;
            this.BtnCancel.Text = "Avbryt";
            this.BtnCancel.UseVisualStyleBackColor = true;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // SettingsPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 332);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.LBPercentage);
            this.Controls.Add(this.TxtBxCommission);
            this.Controls.Add(this.LBCommission);
            this.Name = "SettingsPage";
            this.Text = "Valute Växlare - Inställningar";
            this.Load += new System.EventHandler(this.SettingsPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.exchangeControllerBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox TxtBxCommission;
        private System.Windows.Forms.Label LBPercentage;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.Button BtnCancel;
        public System.Windows.Forms.Label LBCommission;
        private System.Windows.Forms.BindingSource exchangeControllerBindingSource;
    }
}