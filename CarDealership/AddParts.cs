using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace CarDealership {
    public partial class AddParts : Form {
        //List<string> images;
        public AddParts() {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            //NewDir();
            //images = new List<string>();
            //LoadPhoto();
        }

        private void button1_Click(object sender, EventArgs e) {
            WarehousePartsAndAccessories partsAndAccessories = new WarehousePartsAndAccessories();
            partsAndAccessories.TypeOfProduct = typeOfPartsComboBox.Text;
            partsAndAccessories.WarehouseName = warehouseComboBox.Text;
            partsAndAccessories.TitlePart = titlePartsTextBox.Text;
            partsAndAccessories.CatalogNumber = catalogNumberPartsTextBox.Text;
            partsAndAccessories.Address = addressTextBox.Text;
            partsAndAccessories.ApplicabilityToCars = brandCarTextBox.Text;
            partsAndAccessories.QuantityInStock = Convert.ToInt32(quantityInStockTextBox.Text);
            partsAndAccessories.InReserve = Convert.ToInt32(inReserveTextBox.Text);
            partsAndAccessories.MinimumBalance = Convert.ToInt32(minimumBalanceTextBox.Text);
            partsAndAccessories.SparePartsForOrder = Convert.ToInt32(sparePartsForOrderTextBox.Text);
            partsAndAccessories.PurchasePrice = float.Parse(purchasePriceTextBox.Text);
            partsAndAccessories.ExtraCharge = Convert.ToInt32(extraChargeComboBox.Text);
            float totalPrise = (float)(partsAndAccessories.PurchasePrice * (1 + (partsAndAccessories.ExtraCharge / 100))) * partsAndAccessories.QuantityInStock;
            partsAndAccessories.Price = totalPrise;
            //partsAndAccessories.PhotoParts = photoPartsListBox.Text;
            pricePartsTextBox.Text = partsAndAccessories.Price.ToString();
            try {
                DBmanager.InsertParts(partsAndAccessories);
            }
            catch (Exception ex) {
                MessageBox.Show($"Ошибка при попытке создания карточки товара: {ex.Message}");
            }
        }

        private void button2_Click(object sender, EventArgs e) {
            Close();
        }

        /*private void LoadPhoto() {
            images.Clear();
            images = Directory.GetFiles("PartsPhotos").ToList();
            photoPartsListBox.DataSource = images;
        }

        private void NewDir() {
            if (!Directory.Exists(Directory.GetCurrentDirectory() + "PartsPhotos")) {
                Directory.CreateDirectory("PartsPhotos");
            }
        }

        private void addPhotoPartsButton_Click(object sender, EventArgs e) {
            openFileDialog1.Filter = "Изображения|*.jpg;*.gif;*.png";
            if (openFileDialog1.ShowDialog() == DialogResult.OK) {
                foreach (var fileName in openFileDialog1.FileNames) {
                    CopyPhotoToDir(fileName);
                }
            }
            photoPartsListBox.Text = openFileDialog1.FileName;
        }
        private void CopyPhotoToDir(string fileName) {
            var path = fileName.Split('\\');
            long currentTime = DateTimeOffset.Now.ToUnixTimeSeconds();
            File.Copy(fileName, "PartsPhotos\\" + currentTime.ToString() + "_" + path[path.Length - 1]);
            LoadPhoto();
        }*/
    }
}
