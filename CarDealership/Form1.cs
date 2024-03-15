namespace CarDealership {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void signInButton_Click(object sender, EventArgs e) {
            //try {
            //    DBmanager.CreateDB();
            //    statusStrip1.Text = "База данных успешно создана.";
            //}
            //catch (Exception ex) {
            //    MessageBox.Show("Ошибка создания базы данных: " + ex.Message);
            //}
            SignIn signIn = new SignIn();
            this.Hide();
            signIn.ShowDialog();
            this.Show();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {

        }

        private void exitButton_Click(object sender, EventArgs e) {
            Close();
        }
    }
}