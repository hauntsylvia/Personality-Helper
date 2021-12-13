using personality_helper.Classes.Enneagram;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace personality_helper.Classes
{
    public class FullPersonality
    {
        public FullPersonality(MyersBriggsResult mbti, EnneagramResult enneagram)
        {
            this._mbti = mbti;
            this._enneagram = enneagram;
        }
        private MyersBriggsResult _mbti;
        public MyersBriggsResult mbti { get => _mbti; set => _mbti = value ?? throw new ArgumentNullException(nameof(value)); }

        private EnneagramResult _enneagram;
        public EnneagramResult enneagram { get => _enneagram; set => _enneagram = value ?? throw new ArgumentNullException(nameof(value)); }
    }
}
