/*Класс, реализовывающий метод распределения сумм с конца*/
namespace TestAkelon1.Strategies
{
    public class LastDist : IDistribute
    {
        public decimal[] Distribute(decimal sum, decimal[] sums)
        {
           decimal[] resultSums = new decimal[sums.Length];
            int i = sums.Length - 1;
            // Цикл по распределению сумм. Работает пока общая сумма не будет равна нулю.
            while (sum > 0)
            {
                // Если оставшаяся от общей сумма позволяет полностью покрыть текущую, то из общей суммы вычитается требуемая.
                if (sum >= sums[i])
                {
                    // В результирующий массив переносится входное значение.
                    resultSums[i] = sums[i];
                    sum -= sums[i];
                    i--;
                }
                //Если остаток от общей суммы не может покрыть текущую, то туда записывается остаток, а общая сумма обнуляется.
                else
                {
                    resultSums[i] = sum;
                    sum = 0;
                    i--;
                    if (i != 0)
                    {
                        // Заполнение оставшихся сумм нулями.
                        for (int j = i; i > 0; i--)
                        {
                            resultSums[i] = 0;
                        }
                    }
                }
            }
            return resultSums;
        }
    }
}
