 int number = new Random().Next(100, 1000); // 100-999

 int firstDigit = number % 100; 
 int thirdDigit = number / 10; 
 int result = firstDigit / 10; 
 Console.WriteLine($"{number} -> {result}");