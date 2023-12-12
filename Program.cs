using System;
using static System.Console;
Clear();

WriteLine("Write number: ");
int numA = int.Parse(ReadLine());

if(Math.Abs(numA) < 1 || Math.Abs(numA) > 7 )
{
   WriteLine("такого дня нет");
   return;
}
if(numA >= 1 & numA < 6) WriteLine("Это будний Day");
else WriteLine("Это выходной Day");



// if(numA == 1) WriteLine("Monday");
// if(numA == 2) WriteLine("Tuesday");
// if(numA == 3) WriteLine("Wednesday");
// if(numA == 4) WriteLine("Thursday");
// if(numA == 5) WriteLine("Friday");
// if(numA == 6) WriteLine("Saturday");
// if(numA == 7) WriteLine("Sunday");
