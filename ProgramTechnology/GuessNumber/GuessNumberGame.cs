using System;///подключение основного пространства имен
using System.Collections.Generic;///подключает пространство имен, которое содержит коллекции
using System.Linq;///для выполнения запросов к коллекциям
using System.Text;//для работы с текстом
using System.Threading.Tasks;
//using System.Runtime.CompilerServices;

//класс GuessNumberGame для управления игровым процессом (начало игры, угадывание числа, завершение игры).
namespace GuessNumber
{
    internal class GuessNumberGame : IGame
    {
        //представляет интерфейс для генерации слачайных чисел 
        private INumberGenerator _iNumberGenerator;
        //интерфейс для взаимодействия с пользователем
        private IUserInteraction _iInputAction;
        //конструктор
        public GuessNumberGame(INumberGenerator iNumberGenerator, IUserInteraction iInputAction)
        {
            _iNumberGenerator = iNumberGenerator;
            _iInputAction = iInputAction;
        }
        public void Run()
        {
            while (true)
            {
                int secret = _iNumberGenerator.Value;
                Output("Угадайте число");
                while (true)
                {
                    int user_val = _iInputAction.Input;
                    if (user_val == secret) 
                    {
                        Output("Число угадано! :)");
                        Output("Сыграем еще раз? Введите 1 для продолжения игры.");
                        if (!_iInputAction.Continue)
                            return;
                        break;
                    }
                    else
                    {
                        Output("Вы не угадали. Давайте попробуем еще раз.");
                    }
                }
            }  
        }
        public void Output(string output) 
        {
            Console.WriteLine(output);
        }
    }
}
