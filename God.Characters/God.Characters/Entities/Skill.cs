using God.Characters.Common.Enums;

namespace God.Characters.Domain.Entities
{
    public class Skill
    {
        public SkillTypes Type { get; private set; }
        public int Value { get; private set; }
        private Skill() { }
        public static Skill Create(SkillTypes type, int value)
        {
            return new Skill()
            {
                Type = type,
                Value = value
            };
        }
    }
}
