using God.Characters.Common.Helper;
using System.Collections.Generic;
using System.Linq;

namespace God.Characters.Common.Resources.Modifier
{
    public class ModifierRepository
    {
        public IEnumerable<ModifierDto> GetAll()
        {
            return FileHelper.GetFromJson<List<ModifierDto>, ModifierRepository>("Modifiers");
        }
        public IEnumerable<ModifierDto> Search(int value)
        {
            return GetAll().Where(a => a.RangeValue.Contains(value));
        }
    }
}
