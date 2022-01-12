using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace personality_helper.Classes.MBTI
{
    public class MBTICharacter
    {
        internal static Dictionary<char, string> characterToName = new()
        {
            {'e', "Extraversion"},
            {'i', "Introversion"},

            {'n', "Intuition"},
            {'s', "Sensing"},

            {'t', "Thinking"},
            {'f', "Feeling"},

            {'j', "Judging"},
            {'p', "Perceiving"},
        };
        public MBTICharacter(char letter)
        {
            this.letter = letter;
        }


        public string extendedWord => characterToName[this.letter];


        public char letter { get; set; }
    }
}
