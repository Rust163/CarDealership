using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarDealership {
    public partial class AddClientInfo : Form {

        public AddClientInfo() {
            InitializeComponent();
        }

        private void AddClientInfo_Load(object sender, EventArgs e) {
            try {
                DBmanager.CreateTableClients();
            }
            catch (Exception ex) {
                MessageBox.Show($"Ошибка создания таблицы{ex.Message}");
            }
        }

        private void naturalPersonRadioButton_CheckedChanged(object sender, EventArgs e) {
            if (naturalPersonRadioButton.Checked == true) {
                legalPersonGroupBox.Visible = false;
                naturalPersonGroupBox.Visible = true;
            }
        }

        private void legalPersonRadioButton_CheckedChanged(object sender, EventArgs e) {
            if (naturalPersonRadioButton.Checked == false) {
                legalPersonGroupBox.Visible = true;
                naturalPersonGroupBox.Visible = false;
            }
        }

        private void addClientButton_Click(object sender, EventArgs e) {
            Client client = new Client();
            ClientCars clientCars = new ClientCars();
            client.FirstName = fNameTextBox.Text;
            client.LastName = lNameTextBox.Text;
            client.MiddleName = mNameTextBox.Text;
            client.Birthday = birthdayDateTimePicker.Value;
            client.PassportNumber = seriesPassportTextBox.Text + " " + numberPassportTextBox.Text;
            client.PassportOtherData = otherInfoOfPassportTextBox.Text;
            client.ResidenceAddress = address1TextBox.Text;
            client.ResidentialAddress = address2TextBox.Text;
            client.PhoneNumber = phoneNumberMaskedTextBox.Text;
            client.Email = email1TextBox.Text + email2ComboBox.Text;
            clientCars.Brand = brandCarTextBox.Text;
            clientCars.Model = modelCarTextBox.Text;
            clientCars.RegistrationNumber = regNumberTextBox.Text;
            clientCars.VinNumber = vinNumberTextBox.Text;
            clientCars.Mileage = Convert.ToInt32(milageTextBox.Text);
            clientCars.NumberSTS = numberSTSTextBox.Text;
            try {
                DBmanager.InsertClientInfo(client);
                DBmanager.InsertClientCarInfo(clientCars);
            }
            catch (Exception ex) {
                MessageBox.Show("Ошибка добавления данных: " + ex.Message);
            }
        }

    }
}
