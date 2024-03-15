using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDealership {
    internal class WarehousePartsAndAccessories {
        public int id {  get; set; }
        public string TypeOfProduct { get; set; }//Тип товара, запчасти или аксессуары
        public string WarehouseName { get; set; }//На какой склад поступают товары или с какого склада списываем: центральный либо кузовной
        public string TitlePart { get; set; }//Название товара
        public string CatalogNumber { get; set; }//Каталожный номер товара
        public string Address {  get; set; }//Адрес хранения
        public string ApplicabilityToCars { get; set; }//Применяемость к автомобилям по маркам
        public int QuantityInStock { get; set; }//Остаток на складе
        public int InReserve { get; set; }//В резерве
        public int MinimumBalance { get; set; }//Минимальный остаток, от него отталкиваемся при заказе запчастей
        public int SparePartsForOrder { get; set; }//Расчет количества запчастей к заказу
        public float PurchasePrice { get; set; }//Закупочная цена
        public float ExtraCharge { get; set; }//Наценка
        public float Price { get; set; }//Окончательная цена
        public string? PhotoParts {  get; set; }//Фото товара

        
    }
}
