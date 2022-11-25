/*Класс, реализовывающий метод выбора стратегии и вывода на экран.*/
using TestAkelon1.Strategies;

namespace TestAkelon1
{
    internal class Distributer
    {
        private readonly string _filePath;
        private IDistribute _state;
        // В конструктор передаем расположение файла.
        public Distributer(string filePath)
        {
            _filePath = filePath;
        }
        // Метод установки стратегии.
        public void SetState(IDistribute state)
        {
            _state = state;
        }
        //Метод выбора стратегии и распределения сумм.
        public decimal[] DistributeSums()
        {
            // Считываем данные из файла.
            FileReader data = new FileReader(_filePath);
            data.Read();
            // Выбираем стратегию.
            switch (data.state)
            {
                case "PROP": this.SetState(new PropDist()); break;
                case "PERV": this.SetState(new FirstDist()); break;
                case "POSL": this.SetState(new LastDist()); break;
            }
            // Распределяем суммы.
            return _state.Distribute(data.sum, data.sums);

        }
        // Метод вывода результата на экран.
        public void PrintResult(decimal[] result)
        {
            foreach(decimal item in result)
            {
                Console.Write($"{item}");
            }
        }
    }
}
