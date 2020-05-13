using System;

namespace lab1 {
    public class Writer {
        public void Info () {
            System.Console.WriteLine ("I can :\n" +
                "1.Plus\n" +
                "2.Minus\n" +
                "3.Multiplication\n" +
                "4.Division\n" +
                "5.Mod\n" +
                "6.Info\n" +
                "0.Exit\n" +
                "What to do?\n");
        }

        public double input_first () {
            double x = 0;
            System.Console.WriteLine ("Write first number");
            while (!double.TryParse (Console.ReadLine (), out x)) {
                System.Console.WriteLine ("Please write correct number");
            }

            return x;
        }

        public double input_second () {
            System.Console.WriteLine ("Write second number");
            double y = 0;
            while (!double.TryParse (Console.ReadLine (), out y)) {
                System.Console.WriteLine ("Please write correct number");
            }
            return y;
        }

        public void Write (double result) {
            System.Console.WriteLine ("Your resalt " + result.ToString ());
        }
    }
}