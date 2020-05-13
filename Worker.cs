using System;

namespace lab1 {
    /// <summary>
    /// Класс делающий всю работу, с помощью класса для вычисления и класса для работы с данными 
    /// </summary>
    public class Worker {
        private Calculator calculator;
        private Writer writer;
        /// <summary>
        /// Создаем  экземпляры наших классов
        /// </summary>
        public Worker () {
            calculator = new Calculator ();
            writer = new Writer ();
        }
        /// <summary>
        /// Функция запуска работы класса
        /// </summary>
        public void Start () {
            System.Console.WriteLine ("Hello!");
            writer.Info ();
            Action_Recognized ();
        }
        /// <summary>
        /// Функция выбора действия и последующего его выполнения 
        /// </summary>
        public void Action_Recognized () {
            string action = Console.ReadLine ();
            while (action != "0") {
                switch (action) {
                    case "1":
                        writer.Write (calculator.Plus (writer.input_first (), writer.input_second ()));
                        break;
                    case "2":
                        writer.Write (calculator.Minus (writer.input_first (), writer.input_second ()));
                        break;
                    case "3":
                        writer.Write (calculator.Multiplication (writer.input_first (), writer.input_second ()));
                        break;
                    case "4":
                        writer.Write (calculator.Division (writer.input_first (), writer.input_second ()));
                        break;
                    case "5":
                        writer.Write (calculator.Mod (writer.input_first (), writer.input_second ()));
                        break;
                    case "6":
                        writer.Info ();
                        break;
                    default:
                        System.Console.WriteLine ("Unknown action. Please try again");
                        writer.Info ();
                        break;
                }
                action = Console.ReadLine ();
            }
            System.Console.WriteLine ("Bye");
        }
    }
}