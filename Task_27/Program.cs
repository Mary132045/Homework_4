//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
//452 -> 11
//82 -> 10
//9012 -> 12 
Console.WriteLine("Введите число: ");
int num = Int32.Parse(Console.ReadLine());
int[] arr = num.ToString().ToCharArray().Select(x => x - '0').ToArray();
int length = arr.Length;
int sum = 0;
for (int i = 0; i < length; i++)
{
    sum = sum + arr[i];
}
Console.WriteLine(sum);
