/*

Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

*/

double k1, b1, k2, b2;

        // Ввод пользователем значений k1, b1, k2 и b2
        Console.WriteLine("Введите значение k1:");
        k1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Введите значение b1:");
        b1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Введите значение k2:");
        k2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Введите значение b2:");
        b2 = Convert.ToDouble(Console.ReadLine());

        // Шаг 2: Нахождение точки пересечения
        double x_intersection = (b2 - b1) / (k1 - k2);
        double y_intersection = k1 * x_intersection + b1;

        // Шаг 3: Вывод результатов
        Console.WriteLine($"Точка пересечения: ({x_intersection}, {y_intersection})");