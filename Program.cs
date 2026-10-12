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

string[] students = {"Аня", "Борис", "Вика"};
int number = 1;
foreach (string student in students)
{
    Console.WriteLine($"{number}. {student}");
    number++;
}
