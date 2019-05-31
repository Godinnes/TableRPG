using God.Characters.Common.Resources.Attributes;
using God.Characters.Common.Resources.Modifier;
using Microsoft.AspNetCore.Mvc;

namespace God.Characters.Api
{
    [Route("api/[controller]")]
    [ApiController]
    public class AutoCompleteController : Controller
    {
        private readonly AttributeRepository _attributeRepository;
        private readonly ModifierRepository _modifierRepository;
        public AutoCompleteController(AttributeRepository attributeRepository, ModifierRepository modifierRepository)
        {
            _attributeRepository = attributeRepository;
            _modifierRepository = modifierRepository;
        }
        [HttpGet("attributes")]
        public IActionResult GetAllAttributes()
        {
            var attributes = _attributeRepository.GetAll();
            return Ok(attributes);
        }
        [HttpGet("modifier/{value}")]
        public IActionResult SearchModifier(int value)
        {
            var modifier = _modifierRepository.Search(value);
            return Ok(modifier);
        }
    }
}
