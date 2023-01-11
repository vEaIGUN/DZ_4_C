//Задача1.
System.Console.Write("Введите число А:");
int num1 = Convert.ToInt32(Console.ReadLine());

System.Console.Write("Введите число B:");
int num2 = Convert.ToInt32(Console.ReadLine());
int result = 1;
for (int i = 1; i<=num2; i++)
{
    result = result * num1;
}
System.Console.WriteLine(result);


//Задача2.

int Sum(int num)
{
int result = 0;
 while(num>0)
 {
   result= result+num%10;
    num = num/10;
 }
 return result;
}
System.Console.Write("Введите число:");
int num = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine(Sum(num));

//Задача3.

int[] array = new int[8];
for(int i = 0; i < array.Length; i++)
{
   array[i] = new Random().Next();
   System.Console.WriteLine($"{array[i]} \n");
}