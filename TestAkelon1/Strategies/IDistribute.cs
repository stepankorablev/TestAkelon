/*Интерфейс для просто выбора стратегии*/

namespace TestAkelon1.Strategies
{
    public interface IDistribute
    {
        decimal[] Distribute(decimal sum, decimal[] sums);
    }
}
