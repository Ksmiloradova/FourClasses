using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;

namespace BudgetCalculation
{
    class Program
    {
        static void Main(string[] args)
        {
            // Создаю лист участников.
            List<Payer> people = new List<Payer>();
            Console.Write("Укажите имя человека (для завершения ввода участников закупки ввести пустую строку): ");
            string input = Console.ReadLine();
            string inputName;
            while (input != "")
            {
                inputName = input.NameSpelling();
                people.Add(new Payer(inputName));
                Console.Write("Укажите имя человека: ");
                input = Console.ReadLine();
            }

            // Вызов метода расчёта долга для каждого участника.
            foreach (var payer in people)
            {
                payer.SetDebt(people);
            }

            // Запись участников в файл.
            JsonSerializer serializer = new JsonSerializer();
            using (StreamWriter sw = new StreamWriter("Debts.txt"))
            {
                using (JsonWriter writer = new JsonTextWriter(sw))
                {
                    foreach (var payer in people)
                    {
                        serializer.Serialize(writer, payer);
                        sw.WriteLine();
                    }
                }
            }

            Console.WriteLine("Файл с данными всех участников закупки записан. Путь к файлу:");
            Console.WriteLine(Path.Combine(Directory.GetCurrentDirectory(), "Debts.txt"));

            // Запись покупок в файл.
            using (StreamWriter sw = new StreamWriter("Purchases.txt"))
            {
                using (JsonWriter writer = new JsonTextWriter(sw))
                {
                    foreach (var buyer in people)
                    {
                        for (int i = 0; i < buyer.NumberOfPurchses; i++)
                        {
                            serializer.Serialize(writer, buyer[i]);
                            sw.WriteLine();
                        }
                    }
                }
            }

            Console.WriteLine("Файл со предметами закупки записан. Путь к файлу:");
            Console.WriteLine(Path.Combine(Directory.GetCurrentDirectory(), "Purchases.txt"));
            Console.ReadLine();
        }
    }
}