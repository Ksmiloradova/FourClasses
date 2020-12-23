namespace BudgetCalculation
{
    /// <summary>
    /// Класс для метод расширения.
    /// </summary>
    public static class StringExtension
    {
        /// <summary>
        /// Метод, контролирующий написание имени с заглавной буквы.
        /// </summary>
        /// <param name="str">Входное значение имени.</param>
        /// <returns>Имя с заглавной буквы.</returns>
        public static string NameSpelling(this string str)
        {
            string str1 = str.ToUpper();
            string str2 = str.ToLower();
            string strOut = str2.Replace(str2[0], str1[0]);
            return strOut;
        }
    }
}
