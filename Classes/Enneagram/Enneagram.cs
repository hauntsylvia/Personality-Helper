using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace personality_helper.Classes.Enneagram
{
    public class Enneagram
    {
        public Enneagram(int dominantType, int wingType)
        {
            int magnitude = Math.Abs(dominantType - wingType);
            if ((magnitude > 1) && !((dominantType == 1 && wingType == 9) || dominantType == 9 && wingType == 1))
                throw new ArgumentException($"{nameof(wingType)} can not be more than 1 step away from {nameof(dominantType)}", nameof(wingType));
            if (dominantType > 9 || dominantType < 1)
                throw new ArgumentOutOfRangeException(nameof(dominantType));
            if (wingType > 9 || wingType < 1)
                throw new ArgumentOutOfRangeException(nameof(wingType));
            this._dominantType = dominantType;
            this._wingType = wingType;
        }
        private readonly int _dominantType = -1;
        public int dominantType { get => this._dominantType; }
        private readonly int _wingType = -1;
        public int wingType { get => this._wingType; }

        public override string ToString()
        {
            if (this.dominantType != -1 && this.wingType != -1)
            {
                return $"{this.dominantType}w{this.wingType}";
            }
            else
                return string.Empty;
        }
    }
}
