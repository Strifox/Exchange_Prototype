namespace Exchange_Prototype
{
    partial class ReceiptPage
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
            this.LBDate = new System.Windows.Forms.Label();
            this.LBAmount = new System.Windows.Forms.Label();
            this.LBCommission = new System.Windows.Forms.Label();
            this.LBPaid = new System.Windows.Forms.Label();
            this.LBAmountToGet = new System.Windows.Forms.Label();
            this.exchangeControllerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.LBCommissionPaid = new System.Windows.Forms.Label();
            this.LBAmountPaid = new System.Windows.Forms.Label();
            this.LBDateTime = new System.Windows.Forms.Label();
            this.LBCurrencyRate = new System.Windows.Forms.Label();
            this.BtnDone = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.exchangeControllerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // LBDate
            // 
            this.LBDate.AutoSize = true;
            this.LBDate.Location = new System.Drawing.Point(41, 32);
            this.LBDate.Name = "LBDate";
            this.LBDate.Size = new System.Drawing.Size(41, 13);
            this.LBDate.TabIndex = 0;
            this.LBDate.Text = "Datum:";
            // 
            // LBAmount
            // 
            this.LBAmount.AutoSize = true;
            this.LBAmount.Location = new System.Drawing.Point(41, 54);
            this.LBAmount.Name = "LBAmount";
            this.LBAmount.Size = new System.Drawing.Size(40, 13);
            this.LBAmount.TabIndex = 1;
            this.LBAmount.Text = "Belopp";
            // 
            // LBCommission
            // 
            this.LBCommission.AutoSize = true;
            this.LBCommission.Location = new System.Drawing.Point(41, 77);
            this.LBCommission.Name = "LBCommission";
            this.LBCommission.Size = new System.Drawing.Size(65, 13);
            this.LBCommission.TabIndex = 2;
            this.LBCommission.Text = "Kommission:";
            // 
            // LBPaid
            // 
            this.LBPaid.AutoSize = true;
            this.LBPaid.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBPaid.Location = new System.Drawing.Point(41, 110);
            this.LBPaid.Name = "LBPaid";
            this.LBPaid.Size = new System.Drawing.Size(75, 13);
            this.LBPaid.TabIndex = 3;
            this.LBPaid.Text = "UTBETALT:";
            // 
            // LBAmountToGet
            // 
            this.LBAmountToGet.AutoSize = true;
            this.LBAmountToGet.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.exchangeControllerBindingSource, "AmountToGet", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "N0"));
            this.LBAmountToGet.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBAmountToGet.Location = new System.Drawing.Point(164, 110);
            this.LBAmountToGet.Name = "LBAmountToGet";
            this.LBAmountToGet.Size = new System.Drawing.Size(0, 13);
            this.LBAmountToGet.TabIndex = 7;
            // 
            // exchangeControllerBindingSource
            // 
            this.exchangeControllerBindingSource.DataSource = typeof(Exchange_Prototype.Controllers.ExchangeController);
            // 
            // LBCommissionPaid
            // 
            this.LBCommissionPaid.AutoSize = true;
            this.LBCommissionPaid.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.exchangeControllerBindingSource, "PaidCommission", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "N0"));
            this.LBCommissionPaid.Location = new System.Drawing.Point(164, 77);
            this.LBCommissionPaid.Name = "LBCommissionPaid";
            this.LBCommissionPaid.Size = new System.Drawing.Size(0, 13);
            this.LBCommissionPaid.TabIndex = 6;
            // 
            // LBAmountPaid
            // 
            this.LBAmountPaid.AutoSize = true;
            this.LBAmountPaid.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.exchangeControllerBindingSource, "AmountToPay", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "N0"));
            this.LBAmountPaid.Location = new System.Drawing.Point(164, 54);
            this.LBAmountPaid.Name = "LBAmountPaid";
            this.LBAmountPaid.Size = new System.Drawing.Size(0, 13);
            this.LBAmountPaid.TabIndex = 5;
            // 
            // LBDateTime
            // 
            this.LBDateTime.AutoSize = true;
            this.LBDateTime.Location = new System.Drawing.Point(164, 32);
            this.LBDateTime.Name = "LBDateTime";
            this.LBDateTime.Size = new System.Drawing.Size(0, 13);
            this.LBDateTime.TabIndex = 4;
            // 
            // LBCurrencyRate
            // 
            this.LBCurrencyRate.AutoSize = true;
            this.LBCurrencyRate.Location = new System.Drawing.Point(44, 158);
            this.LBCurrencyRate.Name = "LBCurrencyRate";
            this.LBCurrencyRate.Size = new System.Drawing.Size(0, 13);
            this.LBCurrencyRate.TabIndex = 8;
            // 
            // BtnDone
            // 
            this.BtnDone.Location = new System.Drawing.Point(227, 187);
            this.BtnDone.Name = "BtnDone";
            this.BtnDone.Size = new System.Drawing.Size(86, 25);
            this.BtnDone.TabIndex = 9;
            this.BtnDone.Text = "Klart";
            this.BtnDone.UseVisualStyleBackColor = true;
            this.BtnDone.Click += new System.EventHandler(this.BtnDone_Click);
            // 
            // ReceiptPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 332);
            this.Controls.Add(this.BtnDone);
            this.Controls.Add(this.LBCurrencyRate);
            this.Controls.Add(this.LBAmountToGet);
            this.Controls.Add(this.LBCommissionPaid);
            this.Controls.Add(this.LBAmountPaid);
            this.Controls.Add(this.LBDateTime);
            this.Controls.Add(this.LBPaid);
            this.Controls.Add(this.LBCommission);
            this.Controls.Add(this.LBAmount);
            this.Controls.Add(this.LBDate);
            this.Name = "ReceiptPage";
            this.Text = "Valute Växlare - Kvitto";
            this.Load += new System.EventHandler(this.ReceiptPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.exchangeControllerBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LBDate;
        private System.Windows.Forms.Label LBAmount;
        private System.Windows.Forms.Label LBCommission;
        private System.Windows.Forms.Label LBPaid;
        private System.Windows.Forms.Label LBAmountToGet;
        private System.Windows.Forms.Label LBCommissionPaid;
        private System.Windows.Forms.Label LBAmountPaid;
        private System.Windows.Forms.Label LBDateTime;
        private System.Windows.Forms.Label LBCurrencyRate;
        private System.Windows.Forms.Button BtnDone;
        private System.Windows.Forms.BindingSource exchangeControllerBindingSource;
    }
}