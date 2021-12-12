using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace personality_helper.Classes.Enneagram
{
    public enum EnneagramCategorization
    {
        Body,
        Heart,
        Head
    }
    public interface IEnneagram
    {
        EnneagramCategorization category { get; }
        int representativeNumber { get; }
    }
}
