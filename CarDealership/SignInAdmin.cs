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
    public partial class SignIn : Form {
        public SignIn() {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void signinFormButton_Click(object sender, EventArgs e) {
            Warehouse warehouse = new Warehouse();
            if (loginTextBox.Text == "admin" && passwordTextBox.Text == "admin") {
                try {
                    this.Hide();
                    DBmanager.CreateTableWarehouse();
                    warehouse.ShowDialog();
                    //this.Show();
                } catch (Exception ex) {
                    MessageBox.Show("Ошибка создания таблицы" + ex.Message);
                }
            }
        }

        private void backButton_Click(object sender, EventArgs e) {
            Close();
        }

        private void passwordTextBox_Enter(object sender, EventArgs e) {
            if (passwordTextBox.Text == "Пароль") {
                passwordTextBox.Text = "";
            }
        }

        private void passwordTextBox_Leave(object sender, EventArgs e) {
            if (passwordTextBox.Text == "") {
                passwordTextBox.Text = "Пароль";
            }
        }

        private void loginTextBox_Enter(object sender, EventArgs e) {
            if (loginTextBox.Text == "Логин") {
                loginTextBox.Text = "";
            }
        }

        private void loginTextBox_Leave(object sender, EventArgs e) {
            if (loginTextBox.Text == "") {
                loginTextBox.Text = "Логин";
            }
        }
    }
}
