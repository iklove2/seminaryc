﻿Console.WriteLine("Введите номер дня недели: ");
int dayweek = Convert.ToInt32(Console.ReadLine());
switch (dayweek)  
{
    case 1:
        {
            Console.WriteLine($"День недели для номера дня {dayweek} понедельник");
            break;
        }
    case 2:
        {
            Console.WriteLine($"День недели для номера дня {dayweek} вторник");
            break;
        }
    case 3:
        {
            Console.WriteLine($"День недели для номера дня {dayweek} среда");
            break;
        }
    case 4:
        {
            Console.WriteLine($"День недели для номера дня {dayweek} четверг");
            break;
        }
    case 5:
        {
            Console.WriteLine($"День недели для номера дня {dayweek} пятница");
            break;
        }
    case 6:
        {
            Console.WriteLine($"День недели для номера дня {dayweek} суббота");
            break;
        }
    case 7:
        {
            Console.WriteLine($"День недели для номера дня {dayweek} воскресенье");
            break;
        }
    default:
        {
            Console.WriteLine($"День недели для номера дня {dayweek} не существует");
            break;
        }

}