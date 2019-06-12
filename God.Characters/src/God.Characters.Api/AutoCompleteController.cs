using God.Characters.Application.Services;
using God.Characters.Common.Resources.Attributes;
using Microsoft.AspNetCore.Mvc;

namespace God.Characters.Api
{
    [Route("api/")]
    [ApiController]
    public class AutoCompleteController : Controller
    {
        private readonly AttributeRepository _attributeRepository;
        private readonly ModifierService _modifierService;
        public AutoCompleteController(AttributeRepository attributeRepository, ModifierService modifierService)
        {
            _attributeRepository = attributeRepository;
            _modifierService = modifierService;
        }
        [HttpGet("attributes/all")]
        public IActionResult GetAllAttributes()
        {
            var attributes = _attributeRepository.GetAll();
            return Ok(attributes);
        }
        [HttpGet("modifier/{value}")]
        public IActionResult SearchModifier(int value)
        {
            var modifier = _modifierService.Value(value);
            return Ok(modifier);
        }


    }
}
