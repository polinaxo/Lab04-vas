// int age = 15;
// if (age >= 21) {
//     Console.WriteLine("Доступ разрешен");
// }
// Console.WriteLine("Программа продолжает работу");

// int age = 15;
// if (age >= 18) {
//     Console.WriteLine("Доступ разрешен");
// } else {
//     Console.WriteLine("Доступ запрещен");
//     Console.WriteLine($"До соверненнолетия осталось {18 - age} лет");
// }

// int age = 14;
// if (age < 13) {
//     Console.WriteLine("Ребенок");
// } else if (age < 18) {
//     Console.WriteLine("Подросток");
// } else if (age >= 60) {
//     Console.WriteLine("Пенсионер");
// } else {
//     Console.WriteLine("Взрослый");
// }


// int number = 5;
// string result = (number % 2 == 0) ? "четное" : "нечетное";
// Console.WriteLine(result);

// int day = 7;
// string dayName = "Другой день";
// switch (day) {
//     case 1:
//         dayName = "Понедельник";
//         break;
//     case 2:
//         dayName = "Вторник";
//         break;
//     default:
//         dayName = "Другой день";
//         break;
// }
// Console.WriteLine(dayName);

//самост задания А и Б
//задание А
// Console.Write("Введите число: ");
// string input = Console.ReadLine();
// int number = int.Parse(input);

// if (number % 2 == 0)
// {
//     Console.WriteLine("Четное число");
// }
// else
// {
//     Console.WriteLine("Число нечетное");
// }
//задание Б
// Console.Write("Введите оценку: ");
// string input = Console.ReadLine();
// int number = int.Parse(input);

// if (number == 2)
// {
//     Console.WriteLine("Неудовлетворительно");
// }
// else if (number == 3)
// {
//     Console.WriteLine("Удовлетворительно");
// }
// else if (number == 4)
// {
//     Console.WriteLine("Хорошо");
// }
// else if (number == 5)
// {
//     Console.WriteLine("Отлично");
// }
// else
// {
//     Console.WriteLine("Неверная оценка");
// }

//индивидуальный вариант 
//вариант 2
// Console.Write("Введите свой возраст: ");
// string text = Console.ReadLine();
// int age = int.Parse(text);

// if (age >= 18)
// {
//     Console.WriteLine("Доступ разрешен");
// }
// else
// {
//     Console.WriteLine("Доступ запрещен");
// }

Console.Write("Введите количество баллов: ");
string text = Console.ReadLine();
if (!int.TryParse(text, out int number))
{
    Console.WriteLine("Не баллы");
    return;
}

if (number < 0 || number > 100)
{
    Console.WriteLine("Неверное значение");
}
else if (number >= 90 && number <= 100)
{
    Console.WriteLine("Отлично");
}
else if (number >=75 && number <= 89)
{
    Console.WriteLine("Хорошо");
}
else if (number >= 60 && number <= 74)
{
    Console.WriteLine("Удовлетворительно");
}
else
{
    Console.WriteLine("Неудовлетворительно");
}