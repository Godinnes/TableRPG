using God.Characters.Common.Enums;

namespace God.Characters.Domain.Entities
{
    public class Race
    {
        public RaceTypes RaceType { get; private set; }
        public SizeTypes SizeType { get; private set; }
        public WeightTypes WightType { get; private set; }
        public int Movement { get; private set; }
        public VisionTypes VisionType { get; private set; }
        public Skill[] Skills { get; private set; }
        public Attribute[] Attributes { get; private set; }
        private Race() { }
        public static Race Create(RaceTypes race, SizeTypes size, WeightTypes weight, int movement, VisionTypes vision, Skill[] skills, Attribute[] attributes)
        {
            return new Race()
            {
                RaceType = race,
                SizeType = size,
                WightType = weight,
                Movement = movement,
                VisionType = vision,
                Skills = skills,
                Attributes = attributes
            };
        }
    }
}
