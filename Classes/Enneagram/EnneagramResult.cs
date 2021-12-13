using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace personality_helper.Classes.Enneagram
{
    public class EnneagramResult
    {
        public EnneagramResult(IEnneagram dominantType, IEnneagram wing)
        {
            this._dominantType = dominantType;
            int magnitude = Math.Abs(dominantType.representativeNumber - wing.representativeNumber);
            if (magnitude > 1)
                throw new ArgumentException($"{nameof(wing)} can not be more than 1 step away from {nameof(dominantType)}", nameof(wing));
            this._wingType = wing;
        }
        private readonly IEnneagram _dominantType;
        public IEnneagram dominantType { get => this._dominantType; }
        private readonly IEnneagram _wingType;
        public IEnneagram wingType { get => this._wingType; }

    }
}
