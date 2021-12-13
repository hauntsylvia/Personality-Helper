using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace personality_helper.Classes.Enneagram
{
    public class EnneagramResult
    {
        public EnneagramResult(int dominantNumber, int wingNumber)
        {
            int magnitude = Math.Abs(dominantNumber - wingNumber);
            if ((magnitude > 1) && !((dominantNumber == 1 && wingNumber == 9) || dominantNumber == 9 && wingNumber == 1))
                throw new ArgumentException($"{nameof(wingNumber)} can not be more than 1 step away from {nameof(dominantNumber)}", nameof(wingNumber));
            if (dominantNumber > 9 || dominantNumber < 1)
                throw new ArgumentOutOfRangeException(nameof(dominantNumber));
            if (wingNumber > 9 || wingNumber < 1)
                throw new ArgumentOutOfRangeException(nameof(wingNumber));
            this._dominantType = dominantNumber;
            this._wingType = wingNumber;
        }
        private readonly int _dominantType;
        public int dominantType { get => this._dominantType; }
        private readonly int _wingType;
        public int wingType { get => this._wingType; }

    }
}
