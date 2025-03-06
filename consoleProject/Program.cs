namespace consoleProject
{
    /*
     * ФИО студента: Мухамбетова Алина
     * номер варианта: 9
     * условие задачи (скопировать из листа задания): Реализуйте систему для импорта экспорта данных из различных форматов (CSV, XML, JSON), 
     * используя шаблонный метод для обработкиобщих шагов
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            DataProcessor csvProcessor = new CsvProcessor();
            csvProcessor.Process("data.csv");

            DataProcessor xmlProcessor = new XmlProcessor();
            xmlProcessor.Process("data.xml");

            DataProcessor jsonProcessor = new JsonProcessor();
            jsonProcessor.Process("data.json");
        }
    }
}