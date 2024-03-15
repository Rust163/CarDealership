using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using static Google.Protobuf.Reflection.UninterpretedOption.Types;

namespace CarDealership {

    public partial class Warehouse : Form {

        public Warehouse() {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void nomeclatureToolStripMenuItem_Click_1(object sender, EventArgs e) {
            DataGridView dataGridView1 = new DataGridView();
            TabPage nomenclatureTabPage = new TabPage();
            nomenclatureTabPage.Text = "Номенклатура";
            reportsTabControl.TabPages.Add(nomenclatureTabPage);
            nomenclatureTabPage.Controls.Add(dataGridView1);
            dataGridView1.Dock = DockStyle.Fill;
            renameColumns(dataGridView1);
            showAllPartsDGV(dataGridView1);
        }

        private void clientsJournalToolStripMenuItem_Click(object sender, EventArgs e) {
            DataGridView clientsDGV = new DataGridView();
            TabPage clientsTabPage = new TabPage();
            clientsTabPage.Text = "Клиенты";
            reportsTabControl.TabPages.Add(clientsTabPage);
            clientsTabPage.Controls.Add(clientsDGV);
            clientsDGV.Dock = DockStyle.Fill;
            renameColumnsTableClients(clientsDGV);
            showAllClientsDGV(clientsDGV);
        }

        private void avtoJournalToolStripMenuItem_Click(object sender, EventArgs e) {
            DataGridView clientsCarDGV = new DataGridView();
            TabPage carTabPage = new TabPage();
            carTabPage.Text = "Автомобили клиентов";
            reportsTabControl.TabPages.Add(carTabPage);
            carTabPage.Controls.Add(clientsCarDGV);
            clientsCarDGV.Dock = DockStyle.Fill;
            renameColumnsTableClientsCar(clientsCarDGV);
            showAllClientsCarDGV(clientsCarDGV);
        }

        private void renameColumns(DataGridView dataGridView1) {
            dataGridView1.Columns.Add("id", "Id");
            dataGridView1.Columns.Add("typeOfProduct", "Тип продукта");
            dataGridView1.Columns.Add("warehouseName", "Склад");
            dataGridView1.Columns.Add("titlePart", "Наименование товара");
            dataGridView1.Columns.Add("CatalogNumber", "Каталожный номер");
            dataGridView1.Columns.Add("Address", "Адрес хранения");
            dataGridView1.Columns.Add("ApplicabilityToCars", "Применяемость по моделям");
            dataGridView1.Columns.Add("QuantityInStock", "Остаток на складе");
            dataGridView1.Columns.Add("InReserve", "В резерве");
            dataGridView1.Columns.Add("MinimumBalance", "Минимальный остаток");
            dataGridView1.Columns.Add("SparePartsForOrder", "Количество товара к заказу");
            dataGridView1.Columns.Add("PurchasePrice", "Закупочная цена");
            dataGridView1.Columns.Add("ExtraCharge", "Наценка %");
            dataGridView1.Columns.Add("Price", "Общая стоимость");
        }

        private void renameColumnsTableClients(DataGridView clientsDGV) {
            clientsDGV.Columns.Add("Id", "Id");
            clientsDGV.Columns.Add("FirstName", "Имя");
            clientsDGV.Columns.Add("LastName", "Фамилия");
            clientsDGV.Columns.Add("MiddleName", "Отчество");
            clientsDGV.Columns.Add("Birthday", "Дата рождения");
            clientsDGV.Columns.Add("PassportNumber", "Серия и номер паспорта");
            clientsDGV.Columns.Add("PassportOtherData", "Иные данные паспорта");
            clientsDGV.Columns.Add("ResidenceAddress", "Адрес прописки");
            clientsDGV.Columns.Add("ResidentialAddress", "Адрес проживания");
            clientsDGV.Columns.Add("PhoneNumber", "Номер телефона");
            clientsDGV.Columns.Add("Email", "Электронная почта");
        }

        private void renameColumnsTableClientsCar(DataGridView clientsCarDGV) {
            clientsCarDGV.Columns.Add("Id", "Id");
            clientsCarDGV.Columns.Add("Brand", "Бранд");
            clientsCarDGV.Columns.Add("Model", "Модель");
            clientsCarDGV.Columns.Add("RegistrationNumber", "Регистрационный номер");
            clientsCarDGV.Columns.Add("VinNumber", "VIN номер");
            clientsCarDGV.Columns.Add("Mileage", "Пробег");
            clientsCarDGV.Columns.Add("NumberSTS", "Номер СТС");
        }

        private void readSingleRow(DataGridView dataGridView1, IDataRecord record) {
            dataGridView1.Rows.Add(
                record.GetInt32(0),
                record.GetString(1),
                record.GetString(2),
                record.GetString(3),
                record.GetString(4),
                record.GetString(5),
                record.GetString(6),
                record.GetInt32(7),
                record.GetInt32(8),
                record.GetInt32(9),
                record.GetInt32(10),
                record.GetInt32(11),
                record.GetInt32(12),
                record.GetInt32(13)
                );
        }

        private void readSingleRowClientsDGV(DataGridView clientsDGV, IDataRecord record) {
            clientsDGV.Rows.Add(
                record.GetInt32(0),
                record.GetString(1),
                record.GetString(2),
                record.GetString(3),
                record.GetString(4),
                record.GetString(5),
                record.GetString(6),
                record.GetString(7),
                record.GetString(8),
                record.GetString(9),
                record.GetString(10)
                );
        }

        private void readSingleRowClientsCarDGV(DataGridView clientsCarDGV, IDataRecord record) {
            clientsCarDGV.Rows.Add(
                record.GetInt32(0),
                record.GetString(1),
                record.GetString(2),
                record.GetString(3),
                record.GetString(4),
                record.GetInt32(5),
                record.GetString(6)
                );
        }

        private void showAllPartsDGV(DataGridView dataGridView1) {
            using (MySqlConnection con = new MySqlConnection(DBmanager.connectionString)) {
                con.Open();
                string querySelect = "SELECT * FROM WarehousePartsAndAccessories";
                MySqlCommand cmdSelect = new MySqlCommand(querySelect, con);
                using (MySqlDataReader reader = cmdSelect.ExecuteReader()) {
                    while (reader.Read()) {
                        readSingleRow(dataGridView1, reader);
                    }
                }
            }
        }

        private void showAllClientsDGV(DataGridView clientsDGV) {
            using (MySqlConnection con = new MySqlConnection(DBmanager.connectionString)) {
                con.Open();
                string querySelectClients = "SELECT * FROM Clients";
                MySqlCommand cmdSelectClients = new MySqlCommand(querySelectClients, con);
                using (MySqlDataReader reader = cmdSelectClients.ExecuteReader()) {
                    while (reader.Read()) {
                        readSingleRowClientsDGV(clientsDGV, reader);
                    }
                }
            }
        }

        private void showAllClientsCarDGV(DataGridView clientsCarDGV) {
            using (MySqlConnection con = new MySqlConnection(DBmanager.connectionString)) {
                con.Open();
                string querySelectClientsCar = "SELECT * FROM ClientsCar";
                MySqlCommand cmdSelectCar = new MySqlCommand(querySelectClientsCar, con);
                using (MySqlDataReader reader = cmdSelectCar.ExecuteReader()) {
                    while (reader.Read()) {
                        readSingleRowClientsCarDGV(clientsCarDGV, reader);
                    }
                }
            }
        }

        private void addNewCartPartToolStripMenuItem_Click(object sender, EventArgs e) {
            AddParts addParts = new AddParts();
            this.Hide();
            addParts.ShowDialog();
            this.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e) {
            Close();
        }

        private void linkLabel5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            nomeclatureToolStripMenuItem_Click_1(sender, e);
        }

        private void создатьКарточкуКлиентаToolStripMenuItem_Click(object sender, EventArgs e) {
            AddClientInfo clientInfo = new AddClientInfo();
            this.Hide();
            clientInfo.ShowDialog();
            this.Show();
        }
    }
}
