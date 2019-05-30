using God.Characters.Common.Enums;

namespace God.Characters.Domain.Entities
{
    public class Attribute
    {
        public AttributeTypes Type { get; private set; }
        public int Value { get; private set; }
        private Attribute() { }
        public static Attribute Create(AttributeTypes type, int value)
        {
            return new Attribute()
            {
                Type = type,
                Value = value
            };
        }
    }
}
