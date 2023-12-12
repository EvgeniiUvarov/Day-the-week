using System;
using static System.Console;
Clear();

WriteLine("Write number: ");
int numA = int.Parse(ReadLine());

if(numA < 1 || numA > 7 )
{
   WriteLine("такого дня нет");
   return;
}
if(numA >= 1 & numA < 6) WriteLine("Это будний Day");
else WriteLine("Это выходной Day");

