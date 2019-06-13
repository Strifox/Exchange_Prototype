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
    public partial class SettingsPage : Form
    {
        private ExchangeController controller = ExchangePage.controller;

        public SettingsPage()
        {
            InitializeComponent();
        }

        private void SettingsPage_Load(object sender, EventArgs e)
        {
            TxtBxCommission.Text = controller.Commission.ToString();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            controller.SaveCommission(TxtBxCommission);
            Owner.Show();
            Close();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Owner.Show();
            Close();
        }
    }
}
