using Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace Exchange_Prototype.Controllers
{
    public class ExchangeController
    {
        public double lastExchangeRate;
        public double newExchangeRate;
        public string oldCurrency;
        public string newCurrency;
        public double AmountToPay { get; set; }
        public double AmountToGet { get; set; }
        public double PaidCommission { get; set; }
        public double Commission { get; set; } = 1; //Default value is 1.

        //Using two different lists to work around a problem so only one combobox will be changed at a time.
        public List<Value> FromValues = new List<Value>();
        public List<Value> ToValues = new List<Value>();
        private List<JToken> Rates = new List<JToken>();

        public string Uri(string value)
        {
            return $"https://api.exchangeratesapi.io/latest?base={value}";
        }

        public void GetLatestExchangeRate(string fromExchangeValue, string toExchangeValue)
        {
            if (string.IsNullOrEmpty(fromExchangeValue))
                return;
            if (oldCurrency == fromExchangeValue)
                return;

            oldCurrency = fromExchangeValue;
            newCurrency = toExchangeValue;
            try
            {
                using (var client = new HttpClient())
                {
                    var response = client.GetAsync(Uri(fromExchangeValue));
                    var result = response.Result.Content.ReadAsStringAsync();

                    JObject jObjectResult = JObject.Parse(result.Result);
                    //Gets the object within the json called rates.
                    JToken rates = jObjectResult["rates"];
                    Rates.Add(rates);
                }
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
            }
        }

        //Calculates new value with new rate and rounds the new value to 2 decimals.
        public void CalculateAmountToGet(string fromExchangeValue, string toExchangeValue)
        {
            GetLatestExchangeRate(fromExchangeValue, toExchangeValue);

            var getRate = Rates[0];
            
            //Gets the rates for specified currencies.
            JToken currentValueRate = getRate[$"{fromExchangeValue}"];
            JToken newValueRate = getRate[$"{toExchangeValue}"];

            lastExchangeRate = Convert.ToDouble(currentValueRate);
            newExchangeRate = Convert.ToDouble(newValueRate);

            double amountToGet = AmountToPay - (Commission / 100);
            PaidCommission = Math.Round(AmountToPay * (Commission / 100));
            AmountToGet = Math.Round(amountToGet * newExchangeRate);
        }

        public void SetValues(List<Value> values)
        {
            values.AddRange(new List<Value>
            {
                new Value ("SEK", "SEK - Svenska Kronor"),
                new Value ("GBP", "GBP - Brittiska Pund"),
                new Value ("USD", "USD - Amerikanska Dollar"),
                new Value ("CNY", "CNY - Kinesiska Ytan"),
            });
        }
        public void SetValueOnLoad()
        {
            SetValues(FromValues);
            SetValues(ToValues);
        }

        /// <summary>
        /// Use this method to disable button if the selected items in the comboboxes have same value
        /// </summary>
        /// <param name="currency1">Selected item from combobox 1</param>
        /// <param name="currency2">Selected item from combobox 2</param>
        /// <param name="btn"></param>
        public void DisableButtonIfSameValue(ComboBox currency1, ComboBox currency2, Button btn, Label label)
        {
            if (currency1.SelectedIndex != -1)
            {
                if (currency1.SelectedValue == currency2.SelectedValue)
                {
                    btn.Enabled = false;
                    label.Text = "Du kan inte välja samma valuta";
                    label.Visible = true;
                }
                else
                {
                    btn.Enabled = true;
                    label.Visible = false;
                }
            }
        }

        public void SaveCommission(TextBox txtBoxValue)
        {
            Commission = Convert.ToInt32(txtBoxValue.Text);
        }

        /// <summary>
        /// Switch from Exchangepage
        /// </summary>
        /// <param name="oldPage">Sets the owner of the new page to this page.</param>
        /// <param name="newPage">Shows the new page.</param>
        public void SwitchFromStartPage(Form oldPage, Form newPage)
        {
            newPage.Owner = oldPage;
            newPage.Show();
            oldPage.Hide();
        }
    }
}
