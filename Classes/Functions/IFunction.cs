using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace personality_helper.Classes.Grips
{
    public interface IFunction
    {
        string name { get; }

        string extendedName { get; }

        string[] triggers { get; }

        string[] formsOrBehaviors { get; }

        string[] methodsOfEquilibrium { get; }

        string[] betterKnowledge { get; }
    }
}
