using personality_helper.Classes;

namespace personality_helper
{
    public class PersonalityProcessor
    {
        public static MyersBriggsResult From(string type)
        {
            return new MyersBriggsResult(type);
        }
    }
}