using OOO_Sportivnye_Tovary.Classes;
using OOO_Sportivnye_Tovary.Entities;
using OOO_Sportivnye_Tovary.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOO_Sportivnye_Tovary
{
    public partial class FormCatalogue : Form
    {
        private List<Product> products;
        public FormCatalogue()
        {
            InitializeComponent();
        }

        private void FormCatalogue_Load(object sender, EventArgs e)
        {
            if (Helper.User == null)
            {
                LabelCatalogueUser.Text = "";
            }
            else
            {
                LabelCatalogueUser.Text = Helper.User.UserSurname + "\n" +
                    Helper.User.UserName + "\n" + Helper.User.UserPatronymic;
            }
            ComboBoxManufacturer.Items.Clear();
            ComboBoxManufacturer.Items.Add("Все производители");

            foreach(Manufacturer manufacturer in Helper.ModelDB.Manufacturer.ToList())
            {
                ComboBoxManufacturer.Items.Add(manufacturer.ManufacturerName);
            }

            ComboBoxCost.SelectedIndex = 
                ComboBoxDiscount.SelectedIndex = 
                ComboBoxManufacturer.SelectedIndex = 0;
            GetFromDB();
        }

        private int GetManufacturerID(string manufacturer)
        {
            var selectedManufacturer = Helper.ModelDB.Manufacturer.Where(m => m.ManufacturerName == manufacturer).First();
            return selectedManufacturer.ManufacturerID;
        }

        private bool IsHaveLetter(string str, string letters)
        {
            if (String.IsNullOrEmpty(str))
                return true;
            return str.Contains(letters);
        }

        private void UpdateGrid()
        {
            int displayedCount = 0;
            DGVCatalogue.Rows.Clear();
            foreach (Product product in products)
            {
                if (!(IsHaveLetter(product.ProductName, TextBoxSearch.Text)))
                    continue;
                int viewID = DGVCatalogue.Rows.Add();
                DGVCatalogue.Rows[viewID].Height = 120;
                if (product.ProductImage != null)
                {
                    MemoryStream ms = new MemoryStream(product.ProductImage);
                    Bitmap bitmap = (Bitmap)Image.FromStream(ms);
                    DGVCatalogue.Rows[viewID].Cells[0].Value = bitmap;
                }
                else
                    DGVCatalogue.Rows[viewID].Cells[0].Value = (Bitmap)Resources.picture;
                DGVCatalogue.Rows[viewID].Cells[0].Tag = product.ProductArticle;
                DGVCatalogue.Rows[viewID].Cells[1].Value += "Наименование товара: " + product.ProductName +
                    Environment.NewLine + "Описание: " + Environment.NewLine + product.ProductDescription +
                    Environment.NewLine + "Производитель: " + product.Manufacturer.ManufacturerName +
                    Environment.NewLine + "Цена: " + product.ProductCost + Environment.NewLine + "Скидка: " +
                    product.ProductMaxDiscount;
                    DGVCatalogue.Rows[viewID].Cells[1].Value += Environment.NewLine + "Цена со скидкой: " +
                    ((double)product.ProductCost - ((double)product.ProductCost *
                    ((double)product.ProductDiscount / 100)));
                DGVCatalogue.Rows[viewID].Cells[2].Value = "На складе: " + product.ProductCountInStock;
                if (product.ProductCountInStock == 0)
                    DGVCatalogue.Rows[viewID].DefaultCellStyle.BackColor = Color.FromArgb(190, 190, 190);
                displayedCount++;
            }
            LabelProductDisplay.Text = $"Показано: {displayedCount} из {Helper.ModelDB.Product.ToList().Count}";
        }

        private void GetFromDB()
        {
            if (ComboBoxManufacturer.SelectedItem is null || ComboBoxCost.SelectedItem == null || ComboBoxDiscount.SelectedItem == null)
                return;
            List<string> parameters = new List<string>();
            String sqlCommand = "SELECT * FROM Product ";
            if (ComboBoxManufacturer.SelectedItem.ToString() != "Все производители")
                parameters.Add("ProductManufacturer = " + GetManufacturerID(ComboBoxManufacturer.SelectedItem.ToString()) + " ");
            if (ComboBoxDiscount.SelectedItem.ToString() != "Все диапазоны")
            {
                switch (ComboBoxDiscount.SelectedItem.ToString())
                {
                    case "0-10%": parameters.Add("ProductMaxDiscount <= 10 "); break;
                    case "11-14%": parameters.Add("ProductMaxDiscount > 10 AND ProductMaxDiscount < 15 "); break;
                    case ">=15%": parameters.Add("ProductMaxDiscount > 14 "); break;
                }
            }
            if (parameters.Count > 0)
            {
                sqlCommand += "WHERE ";
                for (int i = 0; i < parameters.Count; i++)
                {
                    sqlCommand += parameters[i];
                    if (i != parameters.Count - 1)
                        sqlCommand += "AND ";
                }
            }

            switch (ComboBoxCost.SelectedItem.ToString())
            {
                case "По возрастанию": sqlCommand += "ORDER BY ProductCost ASC"; break;
                case "По убыванию": sqlCommand += "ORDER BY ProductCost DESC"; break;
            }

            products = Helper.ModelDB.Product.SqlQuery(sqlCommand).ToList();
            UpdateGrid();
        }

        private void ComboBoxCost_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetFromDB();
        }

        private void TextBoxSearch_TextChanged(object sender, EventArgs e)
        {
            GetFromDB();
        }

        private void ButtonCatalogueExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DGVCatalogue_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
