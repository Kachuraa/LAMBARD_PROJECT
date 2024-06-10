using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp2.Models;

namespace WinFormsApp2.Forms
{
    public partial class ProductDetailsForm : Form
    {
        private ClientProductPair clientProductPair;

        public ProductDetailsForm(ClientProductPair clientProductPair)
        {
            InitializeComponent();
            this.clientProductPair = clientProductPair;
            DisplayDetails();
        }

        private void DisplayDetails()
        {
            lblClientName.Text = $"{clientProductPair.Client.Name} {clientProductPair.Client.Surname}";
            lblContactInfo.Text = clientProductPair.Client.ContactInfo;
            lblProductName.Text = clientProductPair.Product.Name;
            lblEstimatedValue.Text = clientProductPair.Product.EstimatedValue.ToString();
            lblPawnValue.Text = clientProductPair.Product.PawnValue.ToString();
            lblDateReceived.Text = clientProductPair.Product.DateReceived.ToShortDateString();
            lblStoragePeriod.Text = clientProductPair.Product.StoragePeriod.ToString();
        }
    }
}
