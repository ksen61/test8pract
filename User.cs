namespace Pract8
{
    public class User
    {
        public string Name;
        public double CharactersPerMinute;
        public double CharactersPerSecond;

        public User(string NameParam, double CharactersPerMinuteParam, double CharactersPerSecondParam)
        {
            Name = NameParam;
            CharactersPerMinute = CharactersPerMinuteParam;
            CharactersPerSecond = CharactersPerSecondParam;
        }
    }
}