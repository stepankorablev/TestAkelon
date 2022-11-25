/*Не смог сделать выбор типа распределения на русском. Ни одна кодировка не считывает.
 Соотвественно на входе английский тип распределения:
ПОСЛ = POSL
ПЕРВ = PERV
ПРОП = PROP
*/

using TestAkelon1;

// Путь к файлу.
const string pathInput = @"D:\training\TestAkelon1\TestAkelon1\Input.txt";

// Создаем новый объект распределяющего класса.
Distributer dst = new Distributer(pathInput);

// Считаем суммы.
decimal[] result = dst.DistributeSums();

// Печатаем суммы на экран.
dst.PrintResult(result);

Console.ReadKey();


