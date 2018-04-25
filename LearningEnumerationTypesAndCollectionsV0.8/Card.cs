using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningEnumerationTypesAndCollectionsV0._8
{
    public enum Types
    {
        Spades,
        Clubs,
        Diamonds,
        Hearts,
    }
    public enum Values
    {
        Ace = 1,
        Two = 2,
        Three = 3,
        Four = 4,
        Five = 5,
        Six = 6,
        Seven = 7,
        Eight = 8,
        Nine = 9,
        Ten = 10,
        Jack = 11,
        Queen = 12,
        King = 13,
    }
    class Card
    {
        public Types Type { get; set; }
        public Values Value { get; set; }
        public string Name
        {
            get
            {
                return Value.ToString() + " of " + Type.ToString();
            }
        }
        public Card(Types type, Values value)
        {
            this.Type = type;
            this.Value = value;
        }
    }
}
