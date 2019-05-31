using God.Characters.Common.Helper;
using System.Collections.Generic;

namespace God.Characters.Common.Resources.Attributes
{
    public class AttributeRepository
    {
        public IEnumerable<AttributeDto> GetAll()
        {
            return FileHelper.GetFromJson<List<AttributeDto>, AttributeRepository>("Attributes").Translate();
        }
    }
}
