namespace Exchange_Prototype
{
    partial class ExchangePage
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
            this.LBFromValue = new System.Windows.Forms.Label();
            this.CBFromValue = new System.Windows.Forms.ComboBox();
            this.LBToValue = new System.Windows.Forms.Label();
            this.CBToValue = new System.Windows.Forms.ComboBox();
            this.TxtBoxAmountToPay = new System.Windows.Forms.TextBox();
            this.exchangeControllerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.TxtBoxAmountToGet = new System.Windows.Forms.TextBox();
            this.LBAmount = new System.Windows.Forms.Label();
            this.LBExchanged = new System.Windows.Forms.Label();
            this.BtnPreview = new System.Windows.Forms.Button();
            this.BtnExchange = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.inställningarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LBSameValue = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.exchangeControllerBindingSource)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LBFromValue
            // 
            this.LBFromValue.AutoSize = true;
            this.LBFromValue.Location = new System.Drawing.Point(12, 63);
            this.LBFromValue.Name = "LBFromValue";
            this.LBFromValue.Size = new System.Drawing.Size(61, 13);
            this.LBFromValue.TabIndex = 1;
            this.LBFromValue.Text = "Från Valuta";
            // 
            // CBFromValue
            // 
            this.CBFromValue.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBFromValue.DropDownWidth = 163;
            this.CBFromValue.FormattingEnabled = true;
            this.CBFromValue.Location = new System.Drawing.Point(15, 79);
            this.CBFromValue.Name = "CBFromValue";
            this.CBFromValue.Size = new System.Drawing.Size(163, 21);
            this.CBFromValue.TabIndex = 3;
            this.CBFromValue.SelectedIndexChanged += new System.EventHandler(this.CBFromValue_SelectedValueChanged);
            // 
            // LBToValue
            // 
            this.LBToValue.AutoSize = true;
            this.LBToValue.Location = new System.Drawing.Point(207, 63);
            this.LBToValue.Name = "LBToValue";
            this.LBToValue.Size = new System.Drawing.Size(53, 13);
            this.LBToValue.TabIndex = 4;
            this.LBToValue.Text = "Till Valuta";
            // 
            // CBToValue
            // 
            this.CBToValue.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBToValue.DropDownWidth = 163;
            this.CBToValue.FormattingEnabled = true;
            this.CBToValue.Location = new System.Drawing.Point(210, 79);
            this.CBToValue.Name = "CBToValue";
            this.CBToValue.Size = new System.Drawing.Size(163, 21);
            this.CBToValue.TabIndex = 5;
            this.CBToValue.SelectedIndexChanged += new System.EventHandler(this.CBToValue_SelectedIndexChanged);
            this.CBToValue.SelectedValueChanged += new System.EventHandler(this.CBToValue_SelectedValueChanged);
            // 
            // TxtBoxAmountToPay
            // 
            this.TxtBoxAmountToPay.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.exchangeControllerBindingSource, "AmountToPay", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, null, "N0"));
            this.TxtBoxAmountToPay.Location = new System.Drawing.Point(15, 171);
            this.TxtBoxAmountToPay.Name = "TxtBoxAmountToPay";
            this.TxtBoxAmountToPay.Size = new System.Drawing.Size(163, 20);
            this.TxtBoxAmountToPay.TabIndex = 6;
            this.TxtBoxAmountToPay.TextChanged += new System.EventHandler(this.TxtBoxAmountToPay_TextChanged);
            // 
            // exchangeControllerBindingSource
            // 
            this.exchangeControllerBindingSource.DataSource = typeof(Exchange_Prototype.Controllers.ExchangeController);
            // 
            // TxtBoxAmountToGet
            // 
            this.TxtBoxAmountToGet.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.exchangeControllerBindingSource, "AmountToGet", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, null, "N0"));
            this.TxtBoxAmountToGet.Location = new System.Drawing.Point(15, 239);
            this.TxtBoxAmountToGet.Name = "TxtBoxAmountToGet";
            this.TxtBoxAmountToGet.ReadOnly = true;
            this.TxtBoxAmountToGet.Size = new System.Drawing.Size(163, 20);
            this.TxtBoxAmountToGet.TabIndex = 7;
            // 
            // LBAmount
            // 
            this.LBAmount.AutoSize = true;
            this.LBAmount.Location = new System.Drawing.Point(12, 155);
            this.LBAmount.Name = "LBAmount";
            this.LBAmount.Size = new System.Drawing.Size(40, 13);
            this.LBAmount.TabIndex = 8;
            this.LBAmount.Text = "Belopp";
            // 
            // LBExchanged
            // 
            this.LBExchanged.AutoSize = true;
            this.LBExchanged.Location = new System.Drawing.Point(12, 223);
            this.LBExchanged.Name = "LBExchanged";
            this.LBExchanged.Size = new System.Drawing.Size(61, 13);
            this.LBExchanged.TabIndex = 9;
            this.LBExchanged.Text = "Att utbetala";
            // 
            // BtnPreview
            // 
            this.BtnPreview.Location = new System.Drawing.Point(210, 168);
            this.BtnPreview.Name = "BtnPreview";
            this.BtnPreview.Size = new System.Drawing.Size(163, 23);
            this.BtnPreview.TabIndex = 10;
            this.BtnPreview.Text = "Förhandsgranska";
            this.BtnPreview.UseVisualStyleBackColor = true;
            this.BtnPreview.Click += new System.EventHandler(this.BtnPreview_Click);
            // 
            // BtnExchange
            // 
            this.BtnExchange.Enabled = false;
            this.BtnExchange.Location = new System.Drawing.Point(210, 239);
            this.BtnExchange.Name = "BtnExchange";
            this.BtnExchange.Size = new System.Drawing.Size(163, 23);
            this.BtnExchange.TabIndex = 11;
            this.BtnExchange.Text = "Växla";
            this.BtnExchange.UseVisualStyleBackColor = true;
            this.BtnExchange.Click += new System.EventHandler(this.BtnExchange_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inställningarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip1.Size = new System.Drawing.Size(564, 24);
            this.menuStrip1.TabIndex = 13;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // inställningarToolStripMenuItem
            // 
            this.inställningarToolStripMenuItem.Name = "inställningarToolStripMenuItem";
            this.inställningarToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
            this.inställningarToolStripMenuItem.Text = "Inställningar";
            this.inställningarToolStripMenuItem.Click += new System.EventHandler(this.inställningarToolStripMenuItem_Click);
            // 
            // LBSameValue
            // 
            this.LBSameValue.AutoSize = true;
            this.LBSameValue.ForeColor = System.Drawing.Color.Red;
            this.LBSameValue.Location = new System.Drawing.Point(15, 122);
            this.LBSameValue.Name = "LBSameValue";
            this.LBSameValue.Size = new System.Drawing.Size(0, 13);
            this.LBSameValue.TabIndex = 14;
            this.LBSameValue.Visible = false;
            // 
            // ExchangePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 332);
            this.Controls.Add(this.LBSameValue);
            this.Controls.Add(this.BtnExchange);
            this.Controls.Add(this.BtnPreview);
            this.Controls.Add(this.LBExchanged);
            this.Controls.Add(this.LBAmount);
            this.Controls.Add(this.TxtBoxAmountToGet);
            this.Controls.Add(this.TxtBoxAmountToPay);
            this.Controls.Add(this.CBToValue);
            this.Controls.Add(this.LBToValue);
            this.Controls.Add(this.CBFromValue);
            this.Controls.Add(this.LBFromValue);
            this.Controls.Add(this.menuStrip1);
            this.Name = "ExchangePage";
            this.Text = "Valuta Växlare";
            this.Load += new System.EventHandler(this.ExchangePage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.exchangeControllerBindingSource)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label LBFromValue;
        private System.Windows.Forms.ComboBox CBFromValue;
        private System.Windows.Forms.Label LBToValue;
        private System.Windows.Forms.ComboBox CBToValue;
        private System.Windows.Forms.TextBox TxtBoxAmountToPay;
        private System.Windows.Forms.TextBox TxtBoxAmountToGet;
        private System.Windows.Forms.Label LBAmount;
        private System.Windows.Forms.Label LBExchanged;
        private System.Windows.Forms.Button BtnPreview;
        private System.Windows.Forms.Button BtnExchange;
        private System.Windows.Forms.BindingSource exchangeControllerBindingSource;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem inställningarToolStripMenuItem;
        private System.Windows.Forms.Label LBSameValue;
    }
}

