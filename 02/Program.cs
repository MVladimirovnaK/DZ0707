// Напишите программу, которая с помощью деления выводит третью цифру 
// заданного числа или сообщает, что третьей цифры нет.


Random num = new Random ();
int number = num.Next();
Console.WriteLine($"Выпало случайное число {number}");

 int ThirdDigit(int number)
        {
            int result = -1;
            if (number >= 100)
            {
                while (number > 999)
                {
                    number = number / 10;
                }
                result = number % 10;
            }
            return result; 
        }

Console.WriteLine(result);