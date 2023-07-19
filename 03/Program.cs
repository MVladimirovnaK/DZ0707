// Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
// и проверяет, является ли этот день выходным.

Console.WriteLine("Введите число от 1 до 7: ");
string input = Console.ReadLine();
int c = Convert.ToInt32(input);

if (c==1|c==2|c==3|c==4|c==5)
{
    Console.WriteLine($"День недели {c} не является выходным");
}
else 
{
    Console.WriteLine($"День недели {c} является выходным");
}