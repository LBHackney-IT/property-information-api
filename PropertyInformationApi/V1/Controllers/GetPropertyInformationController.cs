using Microsoft.AspNetCore.Mvc;
using PropertyInformationApi.V1.UseCase;
using Microsoft.Extensions.Logging;
using PropertyInformationApi.V1.Domain;

namespace PropertyInformationApi.V1.Controllers
{
    [ApiController]
    [Route("api/v1/properties")]
    [Produces("application/json")]
    [ApiVersion("1.0")]
    public class GetPropertyInformationController : BaseController
    {
        private readonly IGetPropertyUseCase _getPropertyUseCase;
        private readonly ILogger<GetPropertyInformationController> _logger;

        public GetPropertyInformationController(IGetPropertyUseCase getPropertyUseCase,
            ILogger<GetPropertyInformationController> logger)
        {
            _getPropertyUseCase = getPropertyUseCase;
            _logger = logger;
        }

        /// <summary>
        /// Returns a property for a given property reference
        /// </summary>
        /// <param name="propertyReference">The property reference for which to provide a property</param>
        /// <returns>A a property</returns>
        [HttpGet]
        [Route("{propertyReference}")]
        [Produces("application/json")]
        [ProducesResponseType(typeof(HousingProperty), 200)]
        [ProducesResponseType(typeof(NotFoundResult), 404)]
        public IActionResult GetByReference(string propertyReference)
        {
            _logger.LogInformation("Property information was requested for " + propertyReference);
            var response = _getPropertyUseCase.Execute(propertyReference);

            if (response != null) return Ok(response);

            return NotFound();
        }
    }
}
