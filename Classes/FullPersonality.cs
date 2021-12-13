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
        public FullPersonality(MyersBriggsResult mbti, Enneagram.Enneagram enneagram)
        {
            this._mbti = mbti;
            this._enneagram = enneagram;
        }
        private MyersBriggsResult _mbti;
        public MyersBriggsResult mbti { get => this._mbti; set => this._mbti = value; }

        private Enneagram.Enneagram _enneagram;
        public Enneagram.Enneagram enneagram { get => this._enneagram; set => this._enneagram = value; }
    }
}
