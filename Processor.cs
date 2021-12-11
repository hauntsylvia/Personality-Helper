using myers_briggs_helper.Classes;

namespace myers_briggs_helper
{
    public class Processor
    {
        public static MyersBriggsResult From(string type)
        {
            return new MyersBriggsResult(type);
        }
    }
}