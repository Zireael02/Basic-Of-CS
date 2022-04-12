// See https://aka.ms/new-console-template for more information
Console.WriteLine("Эта программа поможет найти фильм, который будет Вам по душе!");

Console.WriteLine("Как Вас зовут?");
String name = Console.ReadLine();

Console.WriteLine("Здравствуйте, " + name);
Console.WriteLine("Фильм какого жанра Вы бы хотели посмотреть: комедия или драма?");
String genre = Console.ReadLine();

Console.WriteLine("В таком случае, рекомендую посмотреть Вам следующие фильмы:");

if (genre == "комедия")
{
    Console.WriteLine("* В джазе только девушки");
    Console.WriteLine("* Копы в юбках");
    Console.WriteLine("* Шпион");
    Console.WriteLine("* Звездуны на льду");
}
else 
{
    Console.WriteLine("* Зелёная миля");
    Console.WriteLine("* Зов предков");
}

Console.ReadLine();