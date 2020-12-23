using System;

namespace BudgetCalculation
{
    class Purchase
    {
        /// <summary>
        /// Свойтво для названия покупки.
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Свойство для цены покупки.
        /// </summary>
        public double Price { get; set; }

        /// <summary>
        /// Поле для цены покупки.
        /// </summary>
        private double price;

        /// <summary>
        /// Конструктор покупки.
        /// </summary>
        public Purchase()
        {
            Console.Write("Введите название покупки: ");
            Title = Console.ReadLine();
            Console.Write("Введите стоимость покупки: ");
            SetPrice();
            Price = price;
        }

        /// <summary>
        /// Метод, проверяющий вводимое пользователем значение цены покупки.
        /// </summary>
        private void SetPrice()
        {
            while (!double.TryParse(Console.ReadLine(), out price) && price >= 0)
            {
                Console.Write("Цена - это положительное число! Введите цену заново: ");
            }
        }
    }
}
