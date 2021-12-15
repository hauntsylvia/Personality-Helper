using Newtonsoft.Json;
using personality_helper.Classes.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace personality_helper.Classes.Enneagram
{
    public class Enneagram : IValidation
    {
        [JsonConstructor]
        public Enneagram(int dominantType, int wingType, bool forceType = false)
        {
            int magnitude = Math.Abs(dominantType - wingType);
            try
            {
                if ((magnitude > 1) && !((dominantType == 1 && wingType == 9) || dominantType == 9 && wingType == 1) && !forceType)
                    throw new ArgumentException($"{nameof(wingType)} can not be more than 1 step away from {nameof(dominantType)}", nameof(wingType));
                if (dominantType > 9 || dominantType < 1 && !forceType)
                    throw new ArgumentOutOfRangeException(nameof(dominantType));
                if (wingType > 9 || wingType < 1 && !forceType)
                    throw new ArgumentOutOfRangeException(nameof(wingType));
                this._dominantType = dominantType;
                this._wingType = wingType;
            }
            catch
            {
                this._dominantType = -1;
                this._wingType = -1;
                this._isInvalid = true;
            }
        }
        private readonly int _dominantType = -1;
        public int dominantType { get => this._dominantType; }
        private readonly int _wingType = -1;
        public int wingType { get => this._wingType; }

        private readonly bool _isInvalid;
        public bool isInvalid => _isInvalid;

        public static explicit operator Enneagram(string wing) => new(int.Parse(wing.Split('w')[0]), int.Parse(wing.Split('w')[1]));

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
