using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Footwear_Shop
{
    public partial class Form1 : Form
    {
        // ----- COLLECTIONS -----
        // Product list
        private List<StockProduct> products = new List<StockProduct>();
        private string stockFile = "stock.txt";

        public Form1()
        {
            InitializeComponent();
            buttonSell.Click += ButtonSell_Click;
            buttonAdd.Click += ButtonAdd_Click;
            buttonLoadData.Click += ButtonLoadData_Click;
            buttonSaveData.Click += ButtonSaveData_Click;

            // Load data from file if it exists
            if (File.Exists(stockFile))
            {
                LoadStock();
            }

            RefreshProductList();
        }

        // Display products in the ListBox
        private void RefreshProductList()
        {
            listBoxProducts.Items.Clear();
            foreach (var product in products)
            {
                listBoxProducts.Items.Add(product.GetDescription());
            }
        }

        // ----- LAMBDA EXPRESSIONS -----
        // Products with low stock
        private List<StockProduct> GetLowStockProducts()
        {
            return products
                .Where(product => product.Quantity < 5)
                .ToList();
        }

        // Sell products
        private void ButtonSell_Click(object sender, EventArgs e)
        {
            if (listBoxProducts.SelectedIndex < 0)
            {
                MessageBox.Show("Please select a product before selling!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (numericQuantity.Value <= 0)
            {
                MessageBox.Show("The stock must be greater than 0!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                products[listBoxProducts.SelectedIndex]
                    .Sell((int)numericQuantity.Value);

                RefreshProductList();
            }
            catch (StockException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Add stock
        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            if (listBoxProducts.SelectedIndex < 0)
            {
                MessageBox.Show("Please select a product before restocking!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (numericQuantity.Value <= 0)
            {
                MessageBox.Show("The stock must be greater than 0!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            products[listBoxProducts.SelectedIndex]
                .Add((int)numericQuantity.Value);

            RefreshProductList();
        }

        // Save products to the text file
        private void ButtonSaveData_Click(object sender, EventArgs e)
        {

            if (!File.Exists(stockFile))
            {
                MessageBox.Show("The stock file doesn't exist!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (StreamWriter writer = new StreamWriter(stockFile))
            {
                foreach (var product in products)
                {
                    // Write each product on a separate line
                    writer.WriteLine($"{product.Name};{product.Brand};{product.Price};{product.Size};{product.Quantity}");
                }
            }
            MessageBox.Show("The product list has been successfully saved!", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Load products from the text file
        private void ButtonLoadData_Click(object sender, EventArgs e)
        {
            if (!File.Exists(stockFile))
            {
                MessageBox.Show("The stock file doesn't exist!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            bool loaded = LoadStock();

            if (loaded)
            {
                RefreshProductList();

                MessageBox.Show("The product list has been successfully loaded!", "Load", MessageBoxButtons.OK, MessageBoxIcon.Information);

                var lowStockProducts = GetLowStockProducts();
                if (lowStockProducts.Count > 0)
                {
                    MessageBox.Show($"Low stock! {lowStockProducts.Count} product(s) have low stock!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        // Load products from the file
        private bool LoadStock()
        {
            products.Clear();

            try
            {
                foreach (var line in File.ReadAllLines(stockFile))
                {
                    if (string.IsNullOrWhiteSpace(line))
                        continue;

                    var parts = line.Split(';');

                    if (parts.Length != 5)
                        throw new Exception("Invalid product format!");

                    string name = parts[0];
                    string brand = parts[1];

                    if (!double.TryParse(parts[2], out double price))
                        throw new Exception("Invalid price in stock file!");

                    if (!int.TryParse(parts[3], out int size))
                        throw new Exception("Invalid size in stock file!");

                    if (!int.TryParse(parts[4], out int quantity))
                        throw new Exception("Invalid quantity in stock file!");

                    if (quantity < 0)
                        throw new Exception("The quantity can't be a negative number!");

                    products.Add(new StockProduct(name, brand, price, size, quantity));
                }
                return true;
            }

            catch (Exception ex)
            {
                products.Clear();
                MessageBox.Show("Error reading the stock file:\n\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return false;
            }
        }

        // ----- EXCEPTION HANDLING -----
        // Custom exception
        public class StockException : Exception
        {
            public StockException(string message) : base(message) { }
        }

        // ----- INTERFACES -----
        public interface IStock
        {
            void Add(int quantity);
            void Sell(int quantity);
        }

        // ----- ABSTRACT CLASS -----
        public abstract class Product
        {
            public string Name { get; set; }
            public string Brand { get; set; }
            public double Price { get; set; }

            protected Product(string name, string brand, double price)
            {
                Name = name;
                Brand = brand;
                Price = price;
            }

            public abstract string GetDescription();
        }

        public class Footwear : Product
        {
            public int Size { get; set; }

            public Footwear(string name, string brand, double price, int size)
                : base(name, brand, price)
            {
                Size = size;
            }

            public override string GetDescription()
            {
                return $"{Name} | {Brand} | {Size} | {Price} RON";
            }
        }

        public class StockProduct : Footwear, IStock
        {
            public int Quantity { get; private set; }

            public StockProduct(string name, string brand, double price, int size, int quantity)
                : base(name, brand, price, size)
            {
                Quantity = quantity;
            }

            public override string GetDescription()
            {
                return $"{Name} | {Brand} | {Size} | {Price} RON | Stock: {Quantity}";
            }

            public void Add(int quantity)
            {
                Quantity += quantity;
            }

            public void Sell(int quantity)
            {
                if (quantity > Quantity)
                    throw new StockException("Insufficient stock!");

                Quantity -= quantity;
            }
        }
    }
}
