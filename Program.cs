// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6
Console.WriteLine("Введите число");
int number_1 = int.Parse(Console.ReadLine());
if  (number_1 < 100) {Console.WriteLine("Третьей цифры нет");}
else if (number_1 < 1000 && number_1 > 99) {int number_2 = number_1 % 10; Console.WriteLine(number_2);}
else  if (number_1 > 999) 
            { while (number_1 > 999) {number_1 = number_1 /10;}
            int number_2 = number_1 % 10; 
            Console.WriteLine(number_2);}
            
