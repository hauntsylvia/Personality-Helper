using Newtonsoft.Json;
using personality_helper.Classes.Functions;
using personality_helper.Classes.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace personality_helper.Classes.MBTI
{
    public class MyersBriggsResult : IValidation
    {
        [JsonConstructor]
        public MyersBriggsResult(string name, bool forceType = false)
        {
            name = name.ToUpper();
            char ei = name[0];
            char sn = name[1];
            char tf = name[2];
            char jp = name[3];
            if (!((ei == 'E' || ei == 'I') && (sn == 'S' || sn == 'N') && (tf == 'T' || tf == 'F') && (jp == 'J' || jp == 'P')))
            {
                if(!forceType)
                    throw new ArgumentException("Invalid mbti format.");
                this._isInvalid = true;
            }
            this._name = new string(new char[] { ei, sn, tf, jp });
            if (!this.isInvalid)
            {
                List<IMBTICharacter> allMBTICharacters = new();
                foreach (Type t in Assembly.GetExecutingAssembly().GetTypes())
                    if (t.GetInterfaces().Contains(typeof(IMBTICharacter)))
                    {
                        object? instance = Activator.CreateInstance(t);
                        if (instance != null)
                            allMBTICharacters.Add((IMBTICharacter)instance);
                    }
                IMBTICharacter[] characters = new IMBTICharacter[4];
                characters[0] = allMBTICharacters.First(x => x.letter == ei);
                characters[1] = allMBTICharacters.First(x => x.letter == sn);
                characters[2] = allMBTICharacters.First(x => x.letter == tf);
                characters[3] = allMBTICharacters.First(x => x.letter == jp);

                this._types = characters;
                this._functions = new FunctionResult(this._name);
            }
        }
        private readonly string _name;
        public string name => this._name;
        private readonly IMBTICharacter[]? _types;
        public IMBTICharacter[] types => this._types ?? throw new ArgumentNullException(nameof(this._name), "This result was forced, with no matching broken down characters.");

        private readonly FunctionResult? _functions;
        public FunctionResult functions => this._functions ?? throw new ArgumentNullException(nameof(this._name), "This result was forced, with no matching functions.");

        private readonly bool _isInvalid;
        public bool isInvalid => _isInvalid;

        public static explicit operator MyersBriggsResult(string t) => new(t);
        public override string ToString()
        {
            return this.name.ToUpper();
        }
    }
}
