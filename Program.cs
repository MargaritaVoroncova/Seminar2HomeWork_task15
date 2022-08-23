//Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

int dayNumber = new int();

Console.WriteLine("Введите номер дня недели: ");
dayNumber = Convert.ToInt32(Console.ReadLine());

if( dayNumber ==1 )
{
    Console.WriteLine(" Понедельник - рабочий день");
}
else if( dayNumber ==2 )  
{
  Console.WriteLine(" Вторник - рабочий день");
}
else if( dayNumber ==3 )
{
    Console.WriteLine(" Среда - рабочий день");
}
else if( dayNumber ==4 )  
{
  Console.WriteLine(" Четверг- рабочий день");
}
else if( dayNumber == 5 )
{
    Console.WriteLine(" Пятница - рабочий день");
}
else if( dayNumber == 6 )
{
    Console.WriteLine(" Суббота - выходной день");
}
else if( dayNumber == 7 )  
{
  Console.WriteLine(" Воскресенье - выходной день");
}
else 
{
  Console.WriteLine("Это не день недели ");
}