// 9. Напишите программу, которая выводит
// случайное число из отрезка [10, 99] и показывает
// наибольшую цифру числа.
// 78 -> 8
// 12-> 2
// 85 -> 8

Console.Clear();
int number = new Random().Next(10, 100);


// if (firstDigit > secondDigit) { 
// Console.Write($"Наибольшая цифра числа {number} -> {firstDigit}");
// }
// else{
//     Console.Write($"Наибольшая цифра числа {number} -> {secondDigit}");
// }    

// if (firstDigit == secondDigit) Console.Write("Цифры равны");
// else{
//     int max = firstDigit > secondDigit ? firstDigit : secondDigit;
//     Console.Write($"Наибольшая цифра числа {number} -> {max}");
// }

int MaxDigit(int num)
{
    int firstDigit = num / 10;
    int secondDigit = num % 10;
    if (firstDigit == secondDigit) return 0;
    return firstDigit > secondDigit ? firstDigit : secondDigit;
}

int maxDigit = MaxDigit(number);
string result = maxDigit > 0 ? maxDigit.ToString() : "Цифры равны";
Console.Write($"Наибольшая цифра числа {number} -> {result}");