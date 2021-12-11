using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myers_briggs_helper.Classes
{
    public interface IMBTICharacter
    {
        string extendedWord { get; }
        char letter { get; }
    }
}
