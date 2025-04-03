namespace GuessNumber
{
    internal class Proram
    {
        static void Main(string[] args)
        {
            int min = 0;
            int max = 10;
            INumberGenerator iNumberGenerator = new SimpleNumberGenerator(min, max);
            IUserInteraction iInputAction = new UserInput(min, max);
            IGame game = new GuessNumberGame(iNumberGenerator, iInputAction);
            game.Run();
        }
    }
}
