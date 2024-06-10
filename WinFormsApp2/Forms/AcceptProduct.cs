using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.Pkcs;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using WinFormsApp2.Models;

namespace WinFormsApp2.Forms
{
    public partial class AcceptProduct : Form
    {
        public Client NewClient { get; private set; }
        public Product NewProduct { get; private set; }

        public AcceptProduct()
        {
            InitializeComponent();
            textBoxName.TextChanged += new EventHandler(textBox_TextChanged);
            textBoxSurname.TextChanged += new EventHandler(textBox_TextChanged);
            textBoxContactInfo.TextChanged += new EventHandler(textBox_TextChanged);
            textBoxProductName.TextChanged += new EventHandler(textBox_TextChanged);
            textBoxEstimatedValue.TextChanged += new EventHandler(textBox_TextChanged);
            textBoxPawnValue.TextChanged += new EventHandler(textBox_TextChanged);
            textBoxDateReceived.TextChanged += new EventHandler(textBox_TextChanged);
            textBoxStoragePeriod.TextChanged += new EventHandler(textBox_TextChanged);
            btnAdd.Enabled = false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            NewClient = new Client(textBoxName.Text, textBoxSurname.Text, textBoxContactInfo.Text);
            NewProduct = new Product(textBoxProductName.Text,
                                      decimal.Parse(textBoxEstimatedValue.Text),
                                      decimal.Parse(textBoxPawnValue.Text),
                                      DateTime.Parse(textBoxDateReceived.Text),
                                      int.Parse(textBoxStoragePeriod.Text));
            DialogResult = DialogResult.OK;
            Close();
        }

        private bool IsFormValid()
        {
            if (!string.IsNullOrWhiteSpace(textBoxName.Text) &&
                !string.IsNullOrWhiteSpace(textBoxSurname.Text) &&
                !string.IsNullOrWhiteSpace(textBoxContactInfo.Text) &&
                !string.IsNullOrWhiteSpace(textBoxProductName.Text) &&
                decimal.TryParse(textBoxEstimatedValue.Text, out _) &&
                decimal.TryParse(textBoxPawnValue.Text, out _) &&
                DateTime.TryParse(textBoxDateReceived.Text, out _) &&
                int.TryParse(textBoxStoragePeriod.Text, out _))
            {
                return true;
            }

            return false;
        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {
            ValidateInputFields();
        }

        private void ValidateInputFields()
        {
            btnAdd.Enabled = IsFormValid();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}