using Exchange_Prototype.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exchange_Prototype
{
    public partial class ReceiptPage : Form
    {
        private ExchangeController controller = ExchangePage.controller;

        public ReceiptPage()
        {
            InitializeComponent();
        }

        private void ReceiptPage_Load(object sender, EventArgs e)
        {
            //Give all labels in reciept page a value.
            LBDateTime.Text = DateTime.Now.ToString();
            LBAmountPaid.Text = controller.AmountToPay.ToString();
            LBCommissionPaid.Text = controller.PaidCommission.ToString();
            LBAmountToGet.Text = controller.AmountToGet.ToString();
            LBCurrencyRate.Text = $"1 {controller.oldCurrency} = {controller.newExchangeRate * 1} {controller.newCurrency}";
        }

        private void BtnDone_Click(object sender, EventArgs e)
        {
            Owner.Show();
            Close();
        }
    }
}
