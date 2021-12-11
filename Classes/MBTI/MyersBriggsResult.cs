using personality_helper.Classes.Functions;
using personality_helper.Classes.Grips;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace personality_helper.Classes
{
    public class MyersBriggsResult
    {
        public MyersBriggsResult(string name)
        {
            name = name.ToUpper();
            char ei = name[0];
            char sn = name[1];
            char tf = name[2];
            char jp = name[3];
            if (!((ei == 'E' || ei == 'I') && (sn == 'S' || sn == 'N') && (tf == 'T' || tf == 'F') && (jp == 'J' || jp == 'P')))
                throw new ArgumentException("Invalid myers briggs type format.");

            List<IMBTICharacter> allMBTICharacters = new();
            foreach (Type t in Assembly.GetExecutingAssembly().GetTypes())
                if (t.GetInterfaces().Contains(typeof(IMBTICharacter)))
                {
                    object? instance = Activator.CreateInstance(t);
                    if(instance != null)
                        allMBTICharacters.Add((IMBTICharacter)instance);
                }
            IMBTICharacter[] characters = new IMBTICharacter[4];
            characters[0] = allMBTICharacters.First(x => x.letter == ei);
            characters[1] = allMBTICharacters.First(x => x.letter == sn);
            characters[2] = allMBTICharacters.First(x => x.letter == tf);
            characters[3] = allMBTICharacters.First(x => x.letter == jp);

            this._types = characters;
            this._name = new string(new char[] { ei, sn, tf, jp });
            this._functions = new FunctionResult(this._name);
        }
        private readonly string _name;
        public string name => _name;
        private readonly IMBTICharacter[] _types;
        public IMBTICharacter[] types => _types;

        private readonly FunctionResult _functions;
        public FunctionResult functions => _functions;

        public override string ToString()
        {
            return this.name.ToUpper();
        }
    }
}
