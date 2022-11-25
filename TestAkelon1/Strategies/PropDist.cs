/*Класс, реализовывающий распределение сумм пропорционально.*/

namespace TestAkelon1.Strategies
{
    public class PropDist : IDistribute
    {
        public decimal[] Distribute(decimal sum, decimal[] sums)
        {
            int arrayLength = sums.Length;
            decimal[] resultSums = new decimal[arrayLength];
            // Считаем сумму входных параметров для распределения.
            decimal sumInputSums = 0;
            foreach(decimal item in sums)
            {
                sumInputSums += item;
            }
            // Вычисляем коэффиценты распределения.
            decimal[] coef = new decimal[arrayLength];
            for (int i = 0; i < arrayLength; i++)
            {
                coef[i] = sums[i] / sumInputSums;
            }
            // Вычисляем конечное распределение.
            // Начинаем с конца так как на каждом шаге надо прибавлять остаток от округления к последнему элементу.
            for (int i = arrayLength - 1; i >= 0; i--)
            {
                resultSums[i] = Math.Round(sum * coef[i], 2);
                resultSums[arrayLength - 1] += sum * coef[i] - Math.Round(sum * coef[i], 2);
            }
            //Округляем последний элемент.
            resultSums[arrayLength - 1] = Math.Round(resultSums[arrayLength - 1], 2);
            return resultSums;
        }
    }
}
