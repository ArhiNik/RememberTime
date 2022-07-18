using System;

namespace RememberTime
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Выполненные задания Ника с учебника ссылка: https://goo.su/EIxr
            Console.WriteLine("На данный момент выполненны работы: 1.6.; 1.8.; 1.13.; 1.14.; 1.15.;");
            Console.Write("Введите номер задачи: ");
            string number = Console.ReadLine();

            switch (number)
            {
                case "1.6.":
                    var oneOutput = new output();
                    oneOutput.piOutput();
                    break;

                case "1.8.":
                    var twoOutput = new output();
                    twoOutput.readOutput();
                    break;

                case "1.13.":
                    var threeOutput = new output();
                    threeOutput.backOutput();
                    break;
                case "1.14.":
                    var fourOutput = new output();
                    fourOutput.splitOutput();
                    break;
                case "1.15.":
                    var fiveOutput = new output();
                    fiveOutput.spOutput();
                    break;

                default:
                    Console.WriteLine("Задание не найдено!");
                    break;
            }
            Console.ReadKey();
           
        }
    }
}
