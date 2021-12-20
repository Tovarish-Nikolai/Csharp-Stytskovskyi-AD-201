using System;
using System.Linq;
//using System.Linq;
using System.Xml.Linq;
using System.Xml.XPath;

namespace Lab_13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Лабораторная работа 2 (13) Вариант 8";

            XDocument xmlDoc = XDocument.Load("C:\\Users\\USER\\source\\repos\\Csharp-Stytskovskyi-AD-201\\Lab 13\\XMLFile1.xml");

            curedList(xmlDoc);
            byLength(xmlDoc);
            bySex(xmlDoc);
            contactList(xmlDoc);

            static void curedList(XDocument doc)
            {
                Console.WriteLine("1. Даты обращений и болезни с результатом лечения «Вылечено» : ");

                var list = from patient in doc.Descendants("пациент")
                           where patient.Element("история_болезни").Element("результат").Value == "вылечено"
                           select patient;

                foreach (var r in list)
                {
                    Console.WriteLine("Дата : {0}, Название {1}", r.Element("история_болезни").Element("начало").Value, r.Element("история_болезни").Element("название").Value);
                }
            }

            static void byLength(XDocument doc)
            {
                Console.Write("\n2. Число обращений с продолжит. болезни от 2 до 3 недель : ");
                int c = 0;
                var count = from patient in doc.Descendants("пациент")
                            where (int)patient.Element("история_болезни").Element("продолжительность") >= 2 && (int)patient.Element("история_болезни").Element("продолжительность") <= 3
                            select patient;
                foreach (var r in count)
                    c++;
                Console.WriteLine(c);
            }

            static void bySex(XDocument doc)
            {
                Console.WriteLine("\n3. ФИО пациентов мужского полa, сгруппированные по врачам: ");

                var list = from patient in doc.Descendants("пациент")
                           from doctor in patient.Elements("история_болезни")
                           where patient.Element("пол").Value == "М"
                           group patient by doctor.Element("врач").Value;

                foreach (var group in list)
                {
                    Console.WriteLine("\nПациенты врача - " + group.Key);

                    foreach (var elem in group)
                    {
                        Console.WriteLine("{0}",elem.Element("фио_пациента").Value);
                    }
                }
            }

            static void contactList(XDocument doc)
            {
                Console.WriteLine("\n4. Пациенты, которые сделали более 2 обращений (XPath) : ");

                var result = doc.XPathSelectElements("//пациент[количество_обращений>2]/фио_пациента");

                foreach (var r in result)
                {
                    Console.WriteLine(" " + r.Value);
                }
            }
        }
    }
}
