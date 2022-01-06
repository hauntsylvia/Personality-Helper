using personality_helper.Classes.Enneagram;
using personality_helper.Classes.MBTI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace personality_helper.Classes
{
    public class FullPersonality
    {
        public FullPersonality(MyersBriggsResult? mbti, Enneagram.Enneagram? enneagram)
        {
            this._mbti = mbti;
            this._enneagram = enneagram;
        }
        private MyersBriggsResult? _mbti;
        public MyersBriggsResult? mbti { get => this._mbti; set => this._mbti = value; }

        private Enneagram.Enneagram? _enneagram;
        public Enneagram.Enneagram? enneagram { get => this._enneagram; set => this._enneagram = value; }

        public override string ToString()
        {
            return $"━━━━━━━━━✁━━━━━━━━━" +
                    $"\n" +
                    $"{(this.mbti == null || this.mbti.isInvalid ? "XXXX" : this.mbti)} {(this.enneagram == null || this.enneagram.isInvalid ? "xwx" : this.enneagram)}" +
                    $"\n" +
                    $"{(this.mbti == null || this.mbti.isInvalid ? "(no valid functions)" : $"{this.mbti.functions.dominantFunction.name}→{this.mbti.functions.auxFunction.name}→{this.mbti.functions.tertiaryFunction.name}→{this.mbti.functions.inferiorFunction.name}")}" +
                    $"\n━━━━━━━━━✁━━━━━━━━━";
        }
    }
}
