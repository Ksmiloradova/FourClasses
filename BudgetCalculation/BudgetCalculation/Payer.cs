using System;
using System.Collections.Generic;

namespace BudgetCalculation
{
    /// <summary>
    /// Класс участника покупки.
    /// </summary>
    class Payer : Buyer
    {
        /// <summary>
        /// Общее число покупок в закупке.
        /// </summary>
        public static int TotalNumberOfPurchases { get; set; }
        /// <summary>
        /// Общая стоимость всех покупок в закупке.
        /// </summary>
        public static double TotalCost { get; set; }
        /// <summary>
        /// Констуктор участника закупки.
        /// </summary>
        /// <param name="name">Имя участника.</param>
        public Payer(string name) : base(name)
        {
            TotalNumberOfPurchases += n;
            TotalCost += PriceSum;
        }

        /// <summary>
        /// Метод, присваивающий долгу участника окончательное значение.
        /// </summary>
        /// <param name="buyers"></param>
        public void SetDebt(List<Payer> buyers)
        {
            foreach (var byuer in buyers)
            {
                if (!IsEquals(byuer))
                {
                    Debt += byuer.PriceSum;
                }
            }
            Debt = Math.Round(Debt / buyers.Count, 2);
        }

        /// <summary>
        /// Метод, проверяющий равенство двух участников.
        /// </summary>
        /// <param name="obj">Участник, с которым сравнивается данный.</param>
        /// <returns></returns>
        public bool IsEquals(object obj) =>
        obj is Payer && (obj as Payer).Name == Name && (obj as Payer).PriceSum == PriceSum;
    }
}