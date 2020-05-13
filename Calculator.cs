using System;

namespace lab1 {
    /// <summary>
    /// Класс выполняющий все вычисления 
    /// </summary>
    public class Calculator {
        /// <summary>
        /// Функция вычисляет сумму чисел 
        /// </summary>
        /// <param name="x">Первое слагаемое</param>
        /// <param name="y">Второе слагаемое</param>
        /// <returns>Сумма чисел</returns>
        public double Plus (double x, double y) {
            return x + y;
        }
        /// <summary>
        /// Функция вычисляет разность чисел
        /// </summary>
        /// <param name="x">Уменьшаемое</param>
        /// <param name="y">Вычитаемое</param>
        /// <returns>Разность чисел</returns>
        public double Minus (double x, double y) {
            return x - y;
        }
        /// <summary>
        /// Функция вычисляет произведение чисел 
        /// </summary>
        /// <param name="x">Первый множитель</param>
        /// <param name="y">Второй множитель</param>
        /// <returns>Произведение</returns>
        public double Multiplication (double x, double y) {
            return x * y;
        }
        /// <summary>
        /// Функция деления чисел
        /// </summary>
        /// <param name="x">Делимое </param>
        /// <param name="y">Делитель</param>
        /// <returns>Частное</returns>
        public double Division (double x, double y) {
            return x / y;
        }
        /// <summary>
        /// Функция вычисляет остаток от деления
        /// </summary>
        /// <param name="x">Делимое</param>
        /// <param name="y">Делитель </param>
        /// <returns>Остаток</returns>
        public double Mod (double x, double y) {
            return x % y;
        }
    }
}