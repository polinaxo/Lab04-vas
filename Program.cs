// int age = 15;
// if (age >= 21) {
//     Console.WriteLine("Доступ разрешен");
// }
// Console.WriteLine("Программа продолжает работу");

int age = 15;
if (age >= 18) {
    Console.WriteLine("Доступ разрешен");
} else {
    Console.WriteLine("Доступ запрещен");
    Console.WriteLine($"До соверненнолетия осталось {18 - age} лет");
}