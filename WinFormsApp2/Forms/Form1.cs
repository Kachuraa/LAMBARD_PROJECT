using WinFormsApp2.Forms;
using WinFormsApp2.Models;

namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        private PawnShop pawnShop;

        public Form1()
        {
            InitializeComponent();
            pawnShop = PawnShop.LoadData() ?? new PawnShop();
            UpdateProductList();
            lstProducts.DoubleClick += LstProducts_DoubleClick;
        }

        private void UpdateProductList()
        {
            lstProducts.Items.Clear();
            foreach (var pair in pawnShop.ClientProductPairs)
            {
                lstProducts.Items.Add($"Клієнт: {pair.Client.Name} {pair.Client.Surname}, Товар: {pair.Product.Name}, Сума під заставу: {pair.Product.PawnValue}");
            }
        }

        private void LstProducts_DoubleClick(object sender, EventArgs e)
        {
            if (lstProducts.SelectedItem != null)
            {
                int selectedIndex = lstProducts.SelectedIndex;
                var selectedPair = pawnShop.ClientProductPairs[selectedIndex];

                using (var detailsForm = new ProductDetailsForm(selectedPair))
                {
                    detailsForm.ShowDialog();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var addForm = new AcceptProduct())
            {
                if (addForm.ShowDialog() == DialogResult.OK)
                {
                    pawnShop.AddClientProductPair(addForm.NewClient, addForm.NewProduct);
                    pawnShop.SaveData();
                    UpdateProductList();
                }
            }
        }
    }
}