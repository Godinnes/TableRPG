namespace God.Characters.Domain.Entities
{
    public class Character
    {
        public string Name { get; private set; }
        public int Age { get; private set; }
        public float Height { get; private set; }
        public float Weight { get; private set; }
        public Race Race { get; private set; }
        private Character() { }
        public static Character Create(string name, int age, float height, float weight, Race race)
        {
            return new Character()
            {
                Name = name,
                Age = age,
                Height = height,
                Weight = weight,
                Race = race
            };
        }
    }
}
