using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace personality_helper.Classes
{
    public class FullPersonality
    {
        public FullPersonality(MyersBriggsResult mbti)
        {
            this._mbti = mbti;
        }
        private MyersBriggsResult _mbti;
        public MyersBriggsResult mbti { get => _mbti; set => _mbti = value ?? throw new ArgumentNullException(nameof(value)); }
    }
}
