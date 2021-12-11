using personality_helper.Classes.Functions.Extended;
using personality_helper.Classes.Grips;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace personality_helper.Classes.Functions
{
    public class FunctionResult
    {
        private static readonly Dictionary<string, IFunction[]> typeToFunctions = new()
        {
            { "INTP", new IFunction[] { new Ti(), new Ne(), new Si(), new Fe() } },
            { "ISTP", new IFunction[] { new Ti(), new Se(), new Ni(), new Fe() } },
            { "ENTP", new IFunction[] { new Ne(), new Ti(), new Fe(), new Si() } },
            { "ENFP", new IFunction[] { new Ne(), new Fi(), new Te(), new Si() } },
            { "ISFP", new IFunction[] { new Fi(), new Se(), new Ni(), new Te() } },
            { "INFP", new IFunction[] { new Fi(), new Ne(), new Si(), new Te() } },
            { "INTJ", new IFunction[] { new Ni(), new Te(), new Fi(), new Se() } },
            { "INFJ", new IFunction[] { new Ni(), new Fe(), new Ti(), new Se() } },
            { "ESTJ", new IFunction[] { new Te(), new Si(), new Ne(), new Fi() } },
            { "ENTJ", new IFunction[] { new Te(), new Ni(), new Se(), new Fi() } },
            { "ESFJ", new IFunction[] { new Fe(), new Si(), new Ne(), new Ti() } },
            { "ENFJ", new IFunction[] { new Fe(), new Ni(), new Se(), new Ti() } },
            { "ISTJ", new IFunction[] { new Si(), new Te(), new Fi(), new Ne() } },
            { "ISFJ", new IFunction[] { new Si(), new Fe(), new Ti(), new Ne() } },
            { "ESTP", new IFunction[] { new Se(), new Ti(), new Fe(), new Ni() } },
            { "ESFP", new IFunction[] { new Se(), new Fi(), new Te(), new Ni() } },
        };
        public FunctionResult(string t)
        {
            IFunction[] functions   = typeToFunctions[t];

            this._dominantFunction  = functions[0];
            this._auxFunction       = functions[1];
            this._tertiaryFunction  = functions[2];
            this._inferiorFunction  = functions[3];
        }
        public FunctionResult()
        { 
        }

        private readonly IFunction _dominantFunction;
        public IFunction dominantFunction => _dominantFunction;

        private readonly IFunction _auxFunction;
        public IFunction auxFunction => _auxFunction;

        private readonly IFunction _tertiaryFunction;
        public IFunction tertiaryFunction => _tertiaryFunction;

        private readonly IFunction _inferiorFunction;
        public IFunction inferiorFunction => _inferiorFunction;
    }
}
