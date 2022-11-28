using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace try_cath_finally
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try

            {
                int x = int.Parse(Console.ReadLine());//вводим число с клавы
                int y = 1 / x;//присвоеное значение типа int y == 1 b и делим на число введенное с клавы

                Console.WriteLine("y={0}", y);
                Console.WriteLine("блок try выполнился успешно");//при вводе нечислового значения или 0 будет выведено сообщение "возникла ошибка"
            }
            catch 
            {
                Console.WriteLine("возникла какая-то ошибка");
            }
            Console.WriteLine("конец программы");
        }
    }
    
}
