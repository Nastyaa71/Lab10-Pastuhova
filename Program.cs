// string subject = "Программирование";
// foreach (char letter in subject)
// {
//     Console.WriteLine(letter);
// }
// Console.WriteLine($"Общее количество букв в слове: {subject.Length}");


// int [] grades = {4,5,3,5,4};
// int sum = 0;
// foreach (int grade in grades)
// {
//     Console.WriteLine(grade);
//     sum = sum + grade;
// }
// Console.WriteLine("Сумма: " + sum);
// Console.WriteLine("Средний балл: " + (double)sum / grades.Length);

// string[] students = {"Аня", "Ярослав", "Вика"};
// int count = 0;
// foreach (string student in students)
// {
//     Console.WriteLine(student);
//     count++;
// }
// Console.WriteLine("Всего учеников: " + count);


// int[] points = {10,20,15};
// for (int i = 0; i < points.Length; i++)
// {
//     point[i] += 5;
//     Console.WriteLine(points[i]);
// }

// string[] students = {"Аня", "Борис", "Вика"};
// int number = 1;
// foreach (string student in students)
// {
//     Console.WriteLine($"{number}. {student}");
//     number++;
// }


string[] days = {"Понедельник", "Вторник", "Среда"};
foreach (string day in days)
{
    Console.WriteLine(day + "!");
}


int[] numbers = {1,2,3,4,5};
int sum = 0;
foreach (int number in numbers)
{
    Console.WriteLine(number);
    sum = sum + number;
}
Console.WriteLine("Сумма: " + sum);


Console.WriteLine("Введите свою фамилию");
string surname = Console.ReadLine()!.Trim();

if (string.IsNullOrEmpty(surname))
{
    Console.WriteLine("Фамилия не введена. Завершение работы.");
    return;
}

Random rnd = new(surname.GetHashCode() + DateTime.Now.DayOfYear);

var assigned = Enumerable.Range(1,10)
    .OrderBy(_ => rnd.Next())
    .Take(2)
    .OrderBy(x => x)
    .ToList();

Console.WriteLine($"Задачи: №{assigned[0]} и №{assigned[1]}");


string[] names = {"Аня", "Ярослав","Вика"};
int count = 1;
foreach (string name in names)
{
    Console.WriteLine(count + ". " + name);
    count++;
}


string word = "Привет";
for(int i = word.Length - 1; i >= 0; i--)
{
    Console.Write(word[i]);
}
