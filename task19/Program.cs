// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> da

Console.WriteLine("Ввелите число:");
int a = int.Parse(Console.ReadLine());
int a1,a2,a4,a5;
a1=a%10;
a=a/10;
a2=a%10;
a=a/100;
a4=a%10;
a=a/10;
a5=a%10;
if ((a1==a5)&&(a2==a4)){
    Console.WriteLine("da");
}
else{
    Console.WriteLine("net");
}
