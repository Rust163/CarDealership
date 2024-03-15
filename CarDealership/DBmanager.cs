using MySql.Data.MySqlClient;
using MySqlX.XDevAPI;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDealership {
    internal class DBmanager {
        public static string host = "127.0.0.1";
        public static string database = "Dealership";
        public static string user = "root";
        public static string password = "root";
        public static string connectionString = "Database=" + database + ";Server=" + host + ";User=" + user + ";Password=" + password;
        //public static string connectionString = ConfigurationManager.ConnectionStrings["ConnStringCar"].ConnectionString;

        public static void CreateDB() {
            if (!File.Exists("Dealership.db")) {
                using (MySqlConnection conn = new MySqlConnection(connectionString)) {
                    conn.Open();
                    string queryCreate = "CREATE DATABASE Dealership";
                    MySqlCommand cmd = new MySqlCommand(queryCreate, conn);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public static void CreateTableWarehouse() {
            if (File.Exists("Dealership.db")) {
                using (MySqlConnection conn = new MySqlConnection(connectionString)) {
                    conn.Open();
                    string queryCreateTable = "CREATE TABLE WarehousePartsAndAccessories(" +
                        "id INTEGER PRIMARY KEY AUTO_INCREMENT," +
                        "typeOfProduct VARCHAR(50) NOT NULL," +
                        "warehouseName VARCHAR(50) NOT NULL," +
                        "titlePart VARCHAR(50) NOT NULL," +
                        "CatalogNumber VARCHAR(50) NOT NULL," +
                        "Address VARCHAR(50) NOT NULL," +
                        "ApplicabilityToCars VARCHAR(50) NOT NULL," +
                        "QuantityInStock INT NOT NULL," +
                        "InReserve INT NOT NULL," +
                        "MinimumBalance INT NOT NULL," +
                        "SparePartsForOrder INT NOT NULL," +
                        "PurchasePrice FLOAT NOT NULL," +
                        "ExtraCharge FLOAT NOT NULL," +
                        "Price FLOAT NOT NULL);";
                    MySqlCommand createTable = new MySqlCommand(queryCreateTable, conn);
                    createTable.ExecuteNonQuery();
                }
            }
        }
        public static void InsertParts(WarehousePartsAndAccessories partsAndAccessories) {
            using(MySqlConnection conn = new MySqlConnection(connectionString)) {
                conn.Open();
                string queryInsertParts = "INSERT INTO WarehousePartsAndAccessories(" +
                    "typeOfProduct, " +
                    "warehouseName, " +
                    "titlePart, " +
                    "CatalogNumber, " +
                    "Address, " +
                    "ApplicabilityToCars, " +
                    "QuantityInStock, " +
                    "InReserve, " +
                    "MinimumBalance, " +
                    "SparePartsForOrder," +
                    "PurchasePrice, " +
                    "ExtraCharge, " +
                    "Price) VALUES (" +
                    "@_typeOfProduct, " +
                    "@_warehouseName, " +
                    "@_titlePart, " +
                    "@_CatalogNumber, " +
                    "@_Address, " +
                    "@_ApplicabilityToCars, " +
                    "@_QuantityInStock, " + 
                    "@_InReserve, " +
                    "@_MinimumBalance, " +
                    "@_SparePartsForOrder, " +
                    "@_PurchasePrice, " +
                    "@_ExtraCharge, " +
                    "@_Price)";
                MySqlCommand com = new MySqlCommand(queryInsertParts, conn);
                MySqlParameter typeOfProductParam = new MySqlParameter("@_typeOfProduct", partsAndAccessories.TypeOfProduct);
                com.Parameters.Add(typeOfProductParam);
                MySqlParameter warehouseNameParam = new MySqlParameter("@_warehouseName", partsAndAccessories.WarehouseName);
                com.Parameters.Add(warehouseNameParam);
                MySqlParameter titlePartsParam = new MySqlParameter("@_titlePart", partsAndAccessories.TitlePart);
                com.Parameters.Add(titlePartsParam);
                MySqlParameter catalogNumberParam = new MySqlParameter("@_CatalogNumber", partsAndAccessories.CatalogNumber);
                com.Parameters.Add(catalogNumberParam);
                MySqlParameter addressParam = new MySqlParameter("@_Address", partsAndAccessories.Address);
                com.Parameters.Add(addressParam);
                MySqlParameter applicabilityToCarsParam = new MySqlParameter("@_ApplicabilityToCars", partsAndAccessories.ApplicabilityToCars);
                com.Parameters.Add(applicabilityToCarsParam);
                MySqlParameter quantityInStockParam = new MySqlParameter("@_QuantityInStock", partsAndAccessories.QuantityInStock);
                com.Parameters.Add(quantityInStockParam);
                MySqlParameter inReserveParam = new MySqlParameter("@_InReserve", partsAndAccessories.InReserve);
                com.Parameters.Add(inReserveParam);
                MySqlParameter minimumBalanceParam = new MySqlParameter("@_MinimumBalance", partsAndAccessories.MinimumBalance);
                com.Parameters.Add(minimumBalanceParam);
                MySqlParameter sparePartsForOrderParam = new MySqlParameter("@_SparePartsForOrder", partsAndAccessories.SparePartsForOrder);
                com.Parameters.Add(sparePartsForOrderParam);
                MySqlParameter purchasePriceParam = new MySqlParameter("@_PurchasePrice", partsAndAccessories.PurchasePrice);
                com.Parameters.Add(purchasePriceParam);
                MySqlParameter extraChargeParam = new MySqlParameter("@_ExtraCharge", partsAndAccessories.ExtraCharge);
                com.Parameters.Add(extraChargeParam);
                MySqlParameter priceParam = new MySqlParameter("@_Price", partsAndAccessories.Price);
                com.Parameters.Add(priceParam);
                MySqlCommand insertParts = new MySqlCommand(queryInsertParts ,conn);
                com.ExecuteNonQuery();
            }
        }
        
        public static void CreateTableClients() {
            if (File.Exists("Dealership.db")) {
                using (MySqlConnection conn = new MySqlConnection(connectionString)) {
                    conn.Open();
                    string queryCreateTableClientsCar = "CREATE TABLE ClientsCar(" +
                        "Id INTEGER PRIMARY KEY AUTO_INCREMENT," +
                        "Brand VARCHAR(50) NOT NULL," +
                        "Model VARCHAR(50) NOT NULL," +
                        "RegistrationNumber VARCHAR(50) NOT NULL," +
                        "VinNumber VARCHAR(50) NOT NULL," +
                        "Mileage INTEGER NOT NULL," +
                        "NumberSTS VARCHAR(50) NOT NULL);";
                    string queryCreateClientsTable = "CREATE TABLE Clients(" +
                        "Id INTEGER PRIMARY KEY AUTO_INCREMENT," +
                        "FirstName VARCHAR(50) NOT NULL," +
                        "LastName VARCHAR(50) NOT NULL," +
                        "MiddleName VARCHAR(50) NOT NULL," +
                        "Birthday DATE NOT NULL," +
                        "PassportNumber VARCHAR(50) NOT NULL," +
                        "PassportOtherData VARCHAR(1024) NOT NULL," +
                        "ResidenceAddress VARCHAR(1024) NOT NULL," +
                        "ResidentialAddress VARCHAR(1024) NOT NULL," +
                        "PhoneNumber VARCHAR(50) NOT NULL," +
                        "Email VARCHAR(50) NOT NULL);";
                    MySqlCommand CreateTableClientsCar = new MySqlCommand(queryCreateTableClientsCar, conn);
                    MySqlCommand CreateClientsTable = new MySqlCommand(queryCreateClientsTable, conn);
                    CreateTableClientsCar.ExecuteNonQuery();
                    CreateClientsTable.ExecuteNonQuery();
                }
            }
        }

        public static void InsertClientInfo(Client client) {
            using(MySqlConnection conn = new MySqlConnection(connectionString)) {
                conn.Open();
                string queryInsertClientInfo = "INSERT INTO Clients(" +
                    "FirstName, " +
                    "LastName, " +
                    "MiddleName, " +
                    "Birthday, " +
                    "PassportNumber, " +
                    "PassportOtherData, " +
                    "ResidenceAddress, " +
                    "ResidentialAddress, " +
                    "PhoneNumber, " +
                    "Email) VALUES (" +
                    "@_FirstName, " +
                    "@_LastName, " +
                    "@_MiddleName, " +
                    "@_Birthday, " +
                    "@_PassportNumber, " +
                    "@_PassportOtherData, " +
                    "@_ResidenceAddress, " +
                    "@_ResidentialAddress, " +
                    "@_PhoneNumber, " +
                    "@_Email)";
                MySqlCommand ClientInfo = new MySqlCommand(queryInsertClientInfo, conn);
                MySqlParameter FirstNameParam = new MySqlParameter("@_FirstName", client.FirstName);
                ClientInfo.Parameters.Add(FirstNameParam);
                MySqlParameter LastNameNameParam = new MySqlParameter("@_LastName", client.LastName);
                ClientInfo.Parameters.Add(LastNameNameParam);
                MySqlParameter MiddleNameParam = new MySqlParameter("@_MiddleName", client.MiddleName);
                ClientInfo.Parameters.Add(MiddleNameParam);
                MySqlParameter BirthdayParam = new MySqlParameter("@_Birthday", client.Birthday);
                ClientInfo.Parameters.Add(BirthdayParam);
                MySqlParameter PassportNumberParam = new MySqlParameter("@_PassportNumber", client.PassportNumber);
                ClientInfo.Parameters.Add(PassportNumberParam);
                MySqlParameter PassportOtherDataParam = new MySqlParameter("@_PassportOtherData", client.PassportOtherData);
                ClientInfo.Parameters.Add(PassportOtherDataParam);
                MySqlParameter ResidenceAddressParam = new MySqlParameter("@_ResidenceAddress", client.ResidenceAddress);
                ClientInfo.Parameters.Add(ResidenceAddressParam);
                MySqlParameter ResidentialAddressParam = new MySqlParameter("@_ResidentialAddress", client.ResidentialAddress);
                ClientInfo.Parameters.Add(ResidentialAddressParam);
                MySqlParameter PhoneNumberParam = new MySqlParameter("@_PhoneNumber", client.PhoneNumber);
                ClientInfo.Parameters.Add(PhoneNumberParam);
                MySqlParameter EmailParam = new MySqlParameter("@_Email", client.Email);
                ClientInfo.Parameters.Add(EmailParam);
                ClientInfo.ExecuteNonQuery();
            }
        }

        public static void InsertClientCarInfo(ClientCars clientCars) {
            using(MySqlConnection conn = new MySqlConnection(connectionString)) {
                conn.Open();
                string queryClientCarInsert = "INSERT INTO ClientsCar(" +
                    "Brand, " +
                    "Model, " +
                    "RegistrationNumber, " +
                    "VinNumber, " +
                    "Mileage, " +
                    "NumberSTS) VALUES(" +
                    "@_brand, " +
                    "@_model, " +
                    "@_registrationNumber, " +
                    "@_vinNumber, " +
                    "@_mileage, " +
                    "@_numberSTS)";
                MySqlCommand clientCarInsert = new MySqlCommand(queryClientCarInsert, conn);
                MySqlParameter BrandParam = new MySqlParameter("@_brand", clientCars.Brand);
                clientCarInsert.Parameters.Add(BrandParam);
                MySqlParameter ModelParam = new MySqlParameter("@_model", clientCars.Model);
                clientCarInsert.Parameters.Add(ModelParam);
                MySqlParameter RegistrationNumberParam = new MySqlParameter("@_registrationNumber", clientCars.RegistrationNumber);
                clientCarInsert.Parameters.Add(RegistrationNumberParam);
                MySqlParameter VinNumberParam = new MySqlParameter("@_vinNumber", clientCars.VinNumber);
                clientCarInsert.Parameters.Add(VinNumberParam);
                MySqlParameter MileageParam = new MySqlParameter("@_mileage", clientCars.Mileage);
                clientCarInsert.Parameters.Add(MileageParam);
                MySqlParameter NumberSTSParam = new MySqlParameter("@_numberSTS", clientCars.NumberSTS);
                clientCarInsert.Parameters.Add(NumberSTSParam);
                clientCarInsert.ExecuteNonQuery();
            }
        }
    }
}
