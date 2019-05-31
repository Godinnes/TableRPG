using God.Characters.Common.Resources;
using God.Characters.Common.Resources.Attributes;
using System.Collections.Generic;

namespace God.Characters.Common.Helper
{
    public static class TranslateHelper
    {
        public static IEnumerable<AttributeDto> Translate(this IEnumerable<AttributeDto> @this)
        {
            foreach (var attribute in @this)
            {
                attribute.Description = CharactersResource.ResourceManager.GetString(attribute.Type.ToString());
                yield return attribute;
            }
        }
    }
}
