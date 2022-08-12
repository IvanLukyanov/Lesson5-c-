//Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
//[3,21 7,04 22,93 -2,71 78,24] -> 75,53

double[] arrayRealNumbers = new double[5];
for (int i = 0; i < arrayRealNumbers.Length; i++)
{
    arrayRealNumbers[i] = new Random().Next(1, 5);
    Console.WriteLine(arrayRealNumbers[i] + "");
}

double maxNumber = arrayRealNumbers[0];
double minNumber = arrayRealNumbers[0];
for (int i = 1; i <arrayRealNumbers.Length; i++)
{
   if (maxNumber < arrayRealNumbers[i])
   {
    maxNumber = arrayRealNumbers[i];
   }
   if (minNumber > arrayRealNumbers[i])
   {
    minNumber = arrayRealNumbers[i];
   }
}
double decision = maxNumber - minNumber;
Console.WriteLine($"\n разница между максимальным ({maxNumber}) и минимальным ({minNumber}) элементами массива: {decision}");
