using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_12
{
    class Laptop
    {
        public string id { get; set; }
        public string firm { get; set; }
        public string model { get; set; }
        public string cpu { get; set; }
        public string storeID { get; set; }
        public int price { get; set; }
        public int ram { get; set; }

        //public Laptop (string id, string firm, string model, string cpu, string storeID, int price, int ram)
        //{
        //    this.id = id;
        //    this.firm = firm;
        //    this.model = model;
        //    this.cpu = cpu;
        //    this.storeID = storeID;
        //    this.price = price;
        //    this.ram = ram;
        //}

        public override string ToString()
        {
            return string.Format("Код : {0}.\n" +
                "Фирма : {1}.\n" +
                "Модель : {2}.\n" +
                "Процессор : {3}.\n" +
                "Код магазина : {4}.\n" +
                "Цена : {5}.\n" +
                "ОЗУ : {6} гигабайт.",
                id, firm, model, cpu, storeID, price, ram);
        }
    }
}
