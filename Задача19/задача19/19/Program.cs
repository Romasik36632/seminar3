/*Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да*/
Console.Clear();
Console.Write("Введите пятизначное число: ");
int num,a,sum=0,b;
num = Convert.ToInt32(Console.ReadLine());
if(num>9999 && num<100000)
{
for(b=num;num!=0;num=num/10)
{
a=num % 10;
sum=sum*10+a;
}
if(b==sum)
Console.Write($"{b} Является палиндромом.");
else
Console.Write($"{b} Не является палиндромом.");
} else
Console.Write("Вы ввели не пятизначное число! ");


