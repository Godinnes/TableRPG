using God.Characters.Domain.ValueObjects;

namespace God.Characters.Application.Services
{
    public class ModifierService
    {
        public int Value(int attribute)
        {
            var modifier = new ModifierValue(attribute).Value;
            return modifier;
        }
    }
}
