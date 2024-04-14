// See https://aka.ms/new-console-template for more information
// C# Control Flow
// Challenge 1
var currentHour = DateTime.Now.Hour;

if (currentHour >= 11 && currentHour <= 14) {
    Console.WriteLine("Time for lunch!");

}
// Challenge 2
for (int i = 1; i <= 10; i++) {
    Console.WriteLine(i);
}
//Bonus
var count = 5;
while (count > 0)
{
    Console.WriteLine(count);

    count -=1;
}
// C# Arrays
// Challenge 1
string[] daysOfWeek = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
for (int i = 0; i < daysOfWeek.Length; i++) {
    Console.WriteLine(daysOfWeek[i]);
}
// OR
//foreach (var day in daysOfWeek)
//{
 //   Console.WriteLine(day);
//}

// Challenge 2  
int[] array = [2, 4, 7, 9, 32];
var sum = 0;
for (int i = 0; i < array.Length; i++){

    sum += array[i];
    Console.WriteLine(sum);
}
// Bonus 
int[,] numbers = { { 1, 4, 2 }, { 3, 6, 8 } };
Console.WriteLine(numbers[0, 1]);
