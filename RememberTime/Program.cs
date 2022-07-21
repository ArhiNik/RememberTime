using System;

namespace RememberTime
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Выполненные задания Ника с учебника ссылка: https://goo.su/EIxr
            Console.WriteLine("На данный момент выполненны работы: 1.6.; 1.8.; 1.13.; 1.14.; 1.15.; 1.16.;\n2.1.; 2.2.; 2.3.; 2.4.");
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
                case "1.16.":
                    var sixOutput = new output();
                    sixOutput.tabOutput();
                    break;

                case "2.1.":
                    var oneFrmula = new frmula();
                    oneFrmula.disFrmula();
                    break;
                case "2.2.":
                    var twoFrmula = new frmula();
                    twoFrmula.corFrmula();
                    break;
                case "2.3.":
                    var threeFrmul = new frmula();
                    threeFrmul.sinFrmula();
                    break;
                case "2.4.":
                    var fourFrmul = new frmula();
                    fourFrmul.kvFrmula();
                    break;


                default:
                    Console.WriteLine("Задание не найдено!");
                    break;
            }
            Console.ReadKey();
           
        }
    }
}
