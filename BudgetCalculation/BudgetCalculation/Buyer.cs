using System;

namespace BudgetCalculation
{
    /// <summary>
    /// Класс людей как покупателей.
    /// </summary>
    class Buyer : People
    {
        /// <summary>
        /// Поле покупок для индексатора.
        /// </summary>
        private Purchase[] purchases;
        /// <summary>
        /// Поле для количества покупок.
        /// </summary>
        protected int n;

        /// <summary>
        /// Конструктор покупателя.
        /// </summary>
        /// <param name="name">Имя покупателя.</param>
        public Buyer(string name) : base(name)
        {
            Console.Write($"Укажите, сколько покупок совершил(а) {name} (при участии в закупке без совершения покупок введите ноль):");
            PurchaseNumberSet();

            NumberOfPurchses = n;
            purchases = new Purchase[n];
            PurchaseSet();
        }

        /// <summary>
        /// Метод, заполнящий индексатор покупками и считающий их суммарную стоимость.
        /// </summary>
        private void PurchaseSet()
        {
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Покупка {i + 1}");
                this[i] = new Purchase();
            }
            for (int i = 0; i < n; i++)
            {
                PriceSum += this[i].Price;
            }
        }

        /// <summary>
        /// Метод, обрабатывающих введённое пользователем количество покупок.
        /// </summary>
        private void PurchaseNumberSet()
        {
            while (!int.TryParse(Console.ReadLine(), out n) && n >= 0)
            {
                Console.Write("Количество покупок - это целое неотрицательное число! Введите количество покупок заново: ");
            }
        }

        /// <summary>
        /// Индексатор для покупок.
        /// </summary>
        /// <param name="i">Номер покупки.</param>
        /// <returns>Покупка с соответсвующим номером.</returns>
        public Purchase this[int i]
        {
            get => purchases[i];
            set => purchases[i] = value;
        }
    }
}