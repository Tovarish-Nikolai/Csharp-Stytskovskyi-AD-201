using System;

using System.Xml.Linq;
using System.Linq;

namespace Lab_12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Лабораторная работа 1 (12) Вариант 8";

            Laptop[] inStock = new[]
            {
                new Laptop { id = "42", firm = "ROG", model = "XW3413", cpu = "I7 5600", storeID = "02", price = 2900, ram = 16000 },
                new Laptop{ id = "31", firm = "NVIDIA", model = "ZK4300", cpu = "I5 9400k", storeID = "04", price = 2700, ram = 16000},
                new Laptop{ id = "09", firm = "XIAOMI", model = "MiBook 9", cpu = "I7 5600", storeID = "12", price = 2500, ram = 12000},
                new Laptop{ id = "15", firm = "ROG", model = "Zephyrus", cpu = "I9 9000", storeID = "02", price = 3600, ram = 32000},
                new Laptop{ id = "24", firm = "NVIDIA", model = "KZ3400", cpu = "I9 9000k", storeID = "04", price = 3700, ram = 32000}
            };

            byModel(inStock);
            byFirm(inStock);
            priceRange(inStock);
            byRAM(inStock);
            averagePrice(inStock);
            byStoreID(inStock);
            laptopStoreJoin(inStock);

            GenerXML(inStock);

            static void byModel (Laptop[] laptops)
            {
                Console.WriteLine("\n1. Данные по всем ноутбукам с процессором I7 5600 : ");

                var result = from l in laptops
                             where l.cpu == "I7 5600"
                             select l;
                foreach (var laptop in result)
                { Console.WriteLine(laptop.ToString() + "\n"); }

            }

            static void byFirm(Laptop[] laptops)
            {
                Console.WriteLine("\n2. Модели ноутбуков фирмы NVIDIA : ");

                var result = from l in laptops
                             where l.firm == "NVIDIA"
                             select l;
                foreach (var laptop in result)
                { Console.WriteLine(laptop.ToString() + "\n"); }

            }

            static void priceRange(Laptop[] laptops)
            {
                Console.Write("\n3. Число моделей с ценой от 2500 до 3000 : ");
                int count = 0;

                var result = from l in laptops
                             where l.price > 2500 && l.price < 3000 
                             select l;
                foreach (var laptop in result)
                { count++; }

                Console.WriteLine(count);
            }

            static void byRAM(Laptop[] laptops)
            {
                Console.WriteLine("\n4. Модель и производитель ноутбуков с объемом памяти более 16 гигабайт");

                var result = from l in laptops
                             where l.price > 2500 && l.price < 3000
                             select l;
                foreach (var laptop in result)
                { Console.WriteLine(laptop.model + " фирмы "+ laptop.firm); }
            }

            static void averagePrice(Laptop[] laptops)
            {
                Console.Write("\n5. Средняя цена ноутбуков фирмы «ROG» : ");

                var avPrice = from l in laptops
                              where l.firm == "ROG"
                              select l.price;
                Console.WriteLine(avPrice.Average() + " $");
            }

            static void byStoreID(Laptop[] laptops)
            {
                Console.Write("\n6. Все ноутбуки, сгруппированные по коду магазина : ");

                var groups = from l in laptops
                             group l by l.storeID;

                foreach (var group in groups)
                {
                    Console.WriteLine("Товар магазина {0} : " , group.Key);

                    foreach (var elem in group)
                    {
                        Console.WriteLine(" - " + elem.model + " фирмы " + elem.firm);
                    }
                }
            }

            static void laptopStoreJoin(Laptop[] laptops)
            {
                Shop[] shops = new[]
                {
                    new Shop { id = "02" , address = "Some st. 89", name = "ROG Shop" },
                    new Shop { id = "04", address = "That st. 36", name = "NVIDIA Hardware"},
                    new Shop { id = "12", address = "Chinchong st. 69", name = "ChinaTown"}
                };

                Console.WriteLine("\n7. Модель и цена ноутбуков с указанием названия и адреса магазина :");

                var result = from l in laptops
                             join s in shops on l.storeID equals s.id
                             select new
                             {
                                 model = l.model,
                                 price = l.price,
                                 name = s.name,
                                 address = s.address
                             };
                foreach (var r in result)
                {
                    Console.WriteLine("{0} -- {1} -- {2} -- {3}", r.model, r.price, r.price, r.address);
                }
            }

            static void GenerXML(Laptop[] laptops)
            {
                var xmlData = from l in laptops
                              select new XElement("ноутбук",
                                     new XAttribute("id", l.id),
                                     new XElement("фирма", l.firm),
                                     new XElement("модель", l.model),
                                     new XElement("процессор", l.cpu),
                                     new XElement("объем_ОЗУ", l.ram),
                                     new XElement("цена", l.price),
                                     new XElement("код_магазина", l.storeID));

                XElement rootElem = new XElement("inStock", xmlData);
                XDocument xmlDoc = new XDocument();
                xmlDoc.Add(rootElem);
                xmlDoc.Save("laptops.xml");
            }
        }
    }
}
