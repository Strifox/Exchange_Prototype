using Exchange_Prototype.Controllers;
using Models;
using System;
using System.ComponentModel;
using System.Data;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Exchange_Prototype
{
    public partial class ExchangePage : Form
    {
        public static ExchangeController controller = new ExchangeController();

        public ExchangePage()
        {
            InitializeComponent();
        }

        private void ExchangePage_Load(object sender, EventArgs e)
        {
            controller.SetValueOnLoad();

            //Databinding
            exchangeControllerBindingSource.DataSource = controller;
            CBFromValue.DataSource = controller.FromValues;
            CBToValue.DataSource = controller.ToValues;

            CBFromValue.DisplayMember = "Text";
            CBFromValue.ValueMember = "Name";
            CBToValue.DisplayMember = "Text";
            CBToValue.ValueMember = "Name";
        }

        private void BtnPreview_Click(object sender, EventArgs e)
        {
            BtnExchange.Enabled = true;
            string fromValue = CBFromValue.SelectedValue.ToString();
            string toValue = CBToValue.SelectedValue.ToString();

            controller.CalculateAmountToGet(fromValue, toValue);
            TxtBoxAmountToGet.Text = controller.AmountToGet.ToString();
        }

        private void CBFromValue_SelectedValueChanged(object sender, EventArgs e)
        {
            controller.DisableButtonIfSameValue(CBFromValue, CBToValue, BtnPreview, LBSameValue);
        }

        private void CBToValue_SelectedValueChanged(object sender, EventArgs e)
        {
            controller.DisableButtonIfSameValue(CBToValue, CBFromValue, BtnPreview, LBSameValue);
        }

        private void BtnExchange_Click(object sender, EventArgs e)
        {
            BtnExchange.Enabled = false;
            controller.SwitchFromStartPage(this, new ReceiptPage());
        }

        private void inställningarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            controller.SwitchFromStartPage(this, new SettingsPage());
        }
    
        private void TxtBoxAmountToPay_TextChanged(object sender, EventArgs e)
        {
            BtnExchange.Enabled = false;
        }

        private void CBToValue_SelectedIndexChanged(object sender, EventArgs e)
        {
            BtnExchange.Enabled = false;
        }
    }
}
