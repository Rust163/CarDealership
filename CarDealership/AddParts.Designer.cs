namespace CarDealership {
    partial class AddParts {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            titlePartsTextBox = new TextBox();
            catalogNumberPartsTextBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            typeOfPartsComboBox = new ComboBox();
            purchasePriceTextBox = new TextBox();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            pricePartsTextBox = new TextBox();
            label12 = new Label();
            button1 = new Button();
            button2 = new Button();
            label6 = new Label();
            addPhotoPartsButton = new Button();
            brandCarTextBox = new TextBox();
            extraChargeComboBox = new ComboBox();
            label5 = new Label();
            warehouseComboBox = new ComboBox();
            label7 = new Label();
            label8 = new Label();
            label13 = new Label();
            label14 = new Label();
            quantityInStockTextBox = new TextBox();
            inReserveTextBox = new TextBox();
            minimumBalanceTextBox = new TextBox();
            sparePartsForOrderTextBox = new TextBox();
            openFileDialog1 = new OpenFileDialog();
            photoPartsListBox = new ListBox();
            label15 = new Label();
            addressTextBox = new TextBox();
            SuspendLayout();
            // 
            // titlePartsTextBox
            // 
            titlePartsTextBox.Location = new Point(79, 166);
            titlePartsTextBox.Name = "titlePartsTextBox";
            titlePartsTextBox.Size = new Size(198, 23);
            titlePartsTextBox.TabIndex = 1;
            // 
            // catalogNumberPartsTextBox
            // 
            catalogNumberPartsTextBox.Location = new Point(79, 208);
            catalogNumberPartsTextBox.Name = "catalogNumberPartsTextBox";
            catalogNumberPartsTextBox.Size = new Size(198, 23);
            catalogNumberPartsTextBox.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(79, 60);
            label1.Name = "label1";
            label1.Size = new Size(67, 15);
            label1.TabIndex = 8;
            label1.Text = "Тип товара";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(79, 148);
            label2.Name = "label2";
            label2.Size = new Size(130, 15);
            label2.TabIndex = 9;
            label2.Text = "Наименование товара";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(79, 190);
            label3.Name = "label3";
            label3.Size = new Size(156, 15);
            label3.TabIndex = 10;
            label3.Text = "Каталожный номер товара";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(79, 287);
            label4.Name = "label4";
            label4.Size = new Size(110, 15);
            label4.TabIndex = 11;
            label4.Text = "Бренд автомобиля";
            // 
            // typeOfPartsComboBox
            // 
            typeOfPartsComboBox.FormattingEnabled = true;
            typeOfPartsComboBox.Items.AddRange(new object[] { "Запасные части", "ГСМ", "Аксессуары", "Инструмент" });
            typeOfPartsComboBox.Location = new Point(79, 78);
            typeOfPartsComboBox.Name = "typeOfPartsComboBox";
            typeOfPartsComboBox.Size = new Size(198, 23);
            typeOfPartsComboBox.TabIndex = 16;
            // 
            // purchasePriceTextBox
            // 
            purchasePriceTextBox.Location = new Point(79, 525);
            purchasePriceTextBox.Name = "purchasePriceTextBox";
            purchasePriceTextBox.Size = new Size(198, 23);
            purchasePriceTextBox.TabIndex = 17;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(79, 507);
            label9.Name = "label9";
            label9.Size = new Size(133, 15);
            label9.TabIndex = 20;
            label9.Text = "Закупочная стоимость";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(79, 551);
            label10.Name = "label10";
            label10.Size = new Size(67, 15);
            label10.TabIndex = 22;
            label10.Text = "Наценка %";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(79, 595);
            label11.Name = "label11";
            label11.Size = new Size(67, 15);
            label11.TabIndex = 24;
            label11.Text = "Стоимость";
            // 
            // pricePartsTextBox
            // 
            pricePartsTextBox.Location = new Point(79, 613);
            pricePartsTextBox.Name = "pricePartsTextBox";
            pricePartsTextBox.Size = new Size(198, 23);
            pricePartsTextBox.TabIndex = 23;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label12.Location = new Point(12, 9);
            label12.Name = "label12";
            label12.Size = new Size(350, 37);
            label12.TabIndex = 25;
            label12.Text = "Создание карточки товара";
            label12.TextAlign = ContentAlignment.TopCenter;
            // 
            // button1
            // 
            button1.Location = new Point(12, 700);
            button1.Name = "button1";
            button1.Size = new Size(148, 45);
            button1.TabIndex = 26;
            button1.Text = "Добавить";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(202, 700);
            button2.Name = "button2";
            button2.Size = new Size(154, 45);
            button2.TabIndex = 27;
            button2.Text = "Отмена";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(79, 639);
            label6.Name = "label6";
            label6.Size = new Size(75, 15);
            label6.TabIndex = 28;
            label6.Text = "Фото товара";
            // 
            // addPhotoPartsButton
            // 
            addPhotoPartsButton.Location = new Point(79, 657);
            addPhotoPartsButton.Name = "addPhotoPartsButton";
            addPhotoPartsButton.Size = new Size(81, 23);
            addPhotoPartsButton.TabIndex = 30;
            addPhotoPartsButton.Text = "Загрузить";
            addPhotoPartsButton.UseVisualStyleBackColor = true;
            // 
            // brandCarTextBox
            // 
            brandCarTextBox.Location = new Point(79, 305);
            brandCarTextBox.Name = "brandCarTextBox";
            brandCarTextBox.Size = new Size(198, 23);
            brandCarTextBox.TabIndex = 3;
            // 
            // extraChargeComboBox
            // 
            extraChargeComboBox.FormattingEnabled = true;
            extraChargeComboBox.Items.AddRange(new object[] { "5", "10", "15", "20", "25", "30", "35", "40", "45", "50" });
            extraChargeComboBox.Location = new Point(79, 569);
            extraChargeComboBox.Name = "extraChargeComboBox";
            extraChargeComboBox.Size = new Size(198, 23);
            extraChargeComboBox.TabIndex = 31;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(79, 104);
            label5.Name = "label5";
            label5.Size = new Size(40, 15);
            label5.TabIndex = 32;
            label5.Text = "Склад";
            // 
            // warehouseComboBox
            // 
            warehouseComboBox.FormattingEnabled = true;
            warehouseComboBox.Items.AddRange(new object[] { "Центральный склад", "Кузовной склад", "Витрина", "Инструментальный склад" });
            warehouseComboBox.Location = new Point(79, 122);
            warehouseComboBox.Name = "warehouseComboBox";
            warehouseComboBox.Size = new Size(198, 23);
            warehouseComboBox.TabIndex = 33;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(79, 331);
            label7.Name = "label7";
            label7.Size = new Size(72, 15);
            label7.TabIndex = 34;
            label7.Text = "Количество";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(79, 375);
            label8.Name = "label8";
            label8.Size = new Size(60, 15);
            label8.TabIndex = 35;
            label8.Text = "В резерве";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(79, 419);
            label13.Name = "label13";
            label13.Size = new Size(135, 15);
            label13.TabIndex = 36;
            label13.Text = "Минимальный остаток";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(79, 463);
            label14.Name = "label14";
            label14.Size = new Size(51, 15);
            label14.TabIndex = 37;
            label14.Text = "К заказу";
            // 
            // quantityInStockTextBox
            // 
            quantityInStockTextBox.Location = new Point(79, 349);
            quantityInStockTextBox.Name = "quantityInStockTextBox";
            quantityInStockTextBox.Size = new Size(198, 23);
            quantityInStockTextBox.TabIndex = 38;
            // 
            // inReserveTextBox
            // 
            inReserveTextBox.Location = new Point(79, 393);
            inReserveTextBox.Name = "inReserveTextBox";
            inReserveTextBox.Size = new Size(198, 23);
            inReserveTextBox.TabIndex = 39;
            // 
            // minimumBalanceTextBox
            // 
            minimumBalanceTextBox.Location = new Point(79, 437);
            minimumBalanceTextBox.Name = "minimumBalanceTextBox";
            minimumBalanceTextBox.Size = new Size(198, 23);
            minimumBalanceTextBox.TabIndex = 40;
            // 
            // sparePartsForOrderTextBox
            // 
            sparePartsForOrderTextBox.Location = new Point(79, 481);
            sparePartsForOrderTextBox.Name = "sparePartsForOrderTextBox";
            sparePartsForOrderTextBox.Size = new Size(198, 23);
            sparePartsForOrderTextBox.TabIndex = 41;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // photoPartsListBox
            // 
            photoPartsListBox.FormattingEnabled = true;
            photoPartsListBox.ItemHeight = 15;
            photoPartsListBox.Location = new Point(166, 661);
            photoPartsListBox.Name = "photoPartsListBox";
            photoPartsListBox.Size = new Size(111, 19);
            photoPartsListBox.TabIndex = 42;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(80, 239);
            label15.Name = "label15";
            label15.Size = new Size(95, 15);
            label15.TabIndex = 43;
            label15.Text = "Адрес хранения";
            // 
            // addressTextBox
            // 
            addressTextBox.Location = new Point(79, 257);
            addressTextBox.Name = "addressTextBox";
            addressTextBox.Size = new Size(198, 23);
            addressTextBox.TabIndex = 44;
            // 
            // AddParts
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(368, 781);
            Controls.Add(addressTextBox);
            Controls.Add(label15);
            Controls.Add(photoPartsListBox);
            Controls.Add(sparePartsForOrderTextBox);
            Controls.Add(minimumBalanceTextBox);
            Controls.Add(inReserveTextBox);
            Controls.Add(quantityInStockTextBox);
            Controls.Add(label14);
            Controls.Add(label13);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(warehouseComboBox);
            Controls.Add(label5);
            Controls.Add(extraChargeComboBox);
            Controls.Add(addPhotoPartsButton);
            Controls.Add(label6);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(pricePartsTextBox);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(purchasePriceTextBox);
            Controls.Add(typeOfPartsComboBox);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(brandCarTextBox);
            Controls.Add(catalogNumberPartsTextBox);
            Controls.Add(titlePartsTextBox);
            Name = "AddParts";
            Text = "AddParts";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox titlePartsTextBox;
        private TextBox catalogNumberPartsTextBox;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private ComboBox typeOfPartsComboBox;
        private TextBox purchasePriceTextBox;
        private Label label9;
        private Label label10;
        private Label label11;
        private TextBox pricePartsTextBox;
        private Label label12;
        private Button button1;
        private Button button2;
        private Label label6;
        private Button addPhotoPartsButton;
        private TextBox brandCarTextBox;
        private ComboBox extraChargeComboBox;
        private Label label5;
        private ComboBox warehouseComboBox;
        private Label label7;
        private Label label8;
        private Label label13;
        private Label label14;
        private TextBox quantityInStockTextBox;
        private TextBox inReserveTextBox;
        private TextBox minimumBalanceTextBox;
        private TextBox sparePartsForOrderTextBox;
        private OpenFileDialog openFileDialog1;
        private ListBox photoPartsListBox;
        private Label label15;
        private TextBox addressTextBox;
    }
}