namespace BudgetCalculation
{
    /// <summary>
    /// Родительский класс покупателя.
    /// </summary>
    abstract class People
    {
        /// <summary>
        /// Свойство для имени.
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Свойство для долга.
        /// </summary>
        public double Debt { get; set; }
        /// <summary>
        /// Свойство для общей стоимости сделанных человеком покупок.
        /// </summary>
        protected double PriceSum { get; set; }
        /// <summary>
        /// Свойство для количества  сделанных человеком покупок.
        /// </summary>
        public int NumberOfPurchses { get; set; }

        /// <summary>
        /// Конструктор, инициалицирующий имя человека и начальное состояние долга.
        /// </summary>
        /// <param name="name">Передающееся из программы имя человека.</param>
        public People(string name)
        {
            Debt = 0;
            Name = name;
        }
    }
}
