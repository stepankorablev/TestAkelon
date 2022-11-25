/*Класс реализующий чтение данных из файла и парсинг этих данных в нужные типы*/

namespace TestAkelon1
{
    public class FileReader
    {
        private readonly string _filePath;
        public string state { get; set; }
        public decimal sum { get; set; }
        public decimal[] sums { get; set; }

        // В конструктор передаем расположение файла.
        public FileReader(string filePath)
        {
            _filePath = filePath;
        }
        // Метод реализующий парсинг.
        public void Read()
        {
            // Временная переменная для последующего разделения
            string tempSumsStr;
            // Читаем данные из файла
            using (StreamReader sr = new StreamReader(_filePath))
            {
                state = sr.ReadLine();

                sum = decimal.Parse(sr.ReadLine());

                tempSumsStr = sr.ReadLine();
            }
            // Разбиваем временную переменную по ;
            string[] sumsStr = tempSumsStr.Split(";");
            // Временный массив для входных сумм нужного типа.
            decimal[] temp = new decimal[sumsStr.Length];
            // Парсинг в нужный тип.
            for(int i = 0; i < sumsStr.Length; i++)
            {
                temp[i] = decimal.Parse(sumsStr[i]);
            }
            // Передача ссылки на готовый массив.
            sums = temp;
        }
    }
}
