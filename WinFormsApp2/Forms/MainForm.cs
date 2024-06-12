using WinFormsApp2.Forms;
using WinFormsApp2.Models;

namespace WinFormsApp2
{
    public partial class MainForm : Form
    {
        private PawnShop pawnShop;

        public MainForm()
        {
            InitializeComponent();
            btnOpenReturnProduct.Click += btnOpenReturnProduct_Click;
            pawnShop = PawnShop.LoadData() ?? new PawnShop();
            UpdateProductList();
            lstProducts.DoubleClick += LstProducts_DoubleClick;
        }

        internal void UpdateProductList()
        {
            lstProducts.Items.Clear();
            foreach (var pair in pawnShop.ClientProductPairs)
            {
                lstProducts.Items.Add($"Клієнт: {pair.Client.Name} {pair.Client.Surname}, Товар: {pair.Product.Name}, Сума під заставу: {pair.Product.PawnValue}, Термін: {pair.Product.StoragePeriod}");
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

        private void btnAdd_Click(object sender, EventArgs e)
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

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        internal IEnumerable<Product> GetAvailableProductsForReturn()
        {
            return pawnShop.ClientProductPairs.Select(pair => pair.Product);
        }



        private void btnOpenReturnProduct_Click(object sender, EventArgs e)
        {
            if (lstProducts.SelectedItems.Count == 0)
            {
                MessageBox.Show("Виберіть товари для видалення.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var selectedItems = lstProducts.SelectedItems.Cast<object>().ToArray();

            foreach (var selectedItem in selectedItems)
            {
                var selectedPair = pawnShop.ClientProductPairs.FirstOrDefault(pair => pair.ToString() == selectedItem.ToString());
                if (selectedPair != null)
                {
                    pawnShop.RemoveClientProductPair(selectedPair.Product);
                    pawnShop.SaveData();
                }
            }

            DeleteSelectedItemsFromList();

            MessageBox.Show("Вибрані товари були успішно видалені.", "Видалення товарів", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void DeleteSelectedItemsFromList()
        {
            for (int i = lstProducts.SelectedItems.Count - 1; i >= 0; i--)
            {
                lstProducts.Items.Remove(lstProducts.SelectedItems[i]);
            }
            lstProducts.Refresh();
        }


        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnAdd_Click(sender, e);
        }

        private void returnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnOpenReturnProduct_Click(sender, e);

        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string selectedText = lstProducts.SelectedItem?.ToString();

            if (!string.IsNullOrEmpty(selectedText))
            {
                Clipboard.SetText(selectedText);
            }
        }

        private void searchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string searchQuery = Microsoft.VisualBasic.Interaction.InputBox("Введіть текст для пошуку:", "Пошук", "");

            if (!string.IsNullOrEmpty(searchQuery))
            {
                for (int i = 0; i < lstProducts.Items.Count; i++)
                {
                    string itemText = lstProducts.Items[i].ToString();

                    if (itemText.Contains(searchQuery))
                    {
                        lstProducts.SelectedIndex = i;

                        MessageBox.Show($"Знайдено: \"{searchQuery}\"", "Результат пошуку", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        return;
                    }
                }

                MessageBox.Show($"Текст \"{searchQuery}\" не знайдено.", "Результат пошуку", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
