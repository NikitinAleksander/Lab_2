using System;

namespace lab1 {
    /// <summary>
    /// Основной класс, в котором находится main
    /// </summary>
    class Program {
        /// <summary>
        /// Точка начала программы, в которой запускается функция старт класса worker
        /// </summary>
        static void Main () {
            Worker worker = new Worker ();
            worker.Start ();
        }
    }
}