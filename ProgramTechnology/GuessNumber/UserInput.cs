using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
//класс UserInput для обработки ввода пользователя.
namespace GuessNumber
{
    internal class UserInput : IUserInteraction
    {
        /// <summary>
        /// поля могут быть установлены только в конструкторе и не могут быть изменены после 
        /// </summary>
        private readonly int _min; //поле для хранения минимального значения дипазона 
        private readonly int _max; //поле для хранения максимального значения диапазона 
        //коструктор класса, принимающий 2 параметра
        public UserInput (int minVal, int maxVal)
        {
            _min = minVal;
            _max = maxVal;
        }
        public int Input
        {
            get //определяет метод доступа для получения значения свойства
            {
                while (true)
                {
                    try //блок, в котором выполняется код, который может вызвать исключение 
                    {
                        int val = Convert.ToInt32(Console.ReadLine());//считывает строку из консоли и пытается преобразовать ее в целое число 
                        if (val >= _min && val <= _max)//проверяет находится ли введеное значение в заданном диапазоне 
                            return val;//если значение корректное, оно возвращается 
                        Console.WriteLine($"Число должно находиться в диапазоне от {_min} до {_max}. Попробуйте еще раз."); 
                    }
                    catch //блок который обрабатывает исключения 
                    {
                        Console.WriteLine("Ошибка преобразования введенного параметра в число. Попробуте еще раз");
                    }
                }
            }
        }
        public bool Continue //возвращает логическое значение, указывающее хочет ли пользователь продолжить игру 
        {
            get
            {
                try
                {
                    int answer = Convert.ToInt32(Console.ReadLine());
                    return answer == 1; //если пользователь ввел 1, возвращает true, пользователь хочет продолжить 
                }
                catch //блок исключений 
                {

                }
                return false;
            }
        }  
    }
}
