using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using PropertyInformationApi.V1.UseCase;
using Microsoft.Extensions.Logging;
using PropertyInformationApi.V1.Boundary.Request;
using PropertyInformationApi.V1.Domain;
using PropertyInformationApi.V1.UseCase.Interfaces;

namespace PropertyInformationApi.V1.Controllers
{
    [ApiController]
    [Route("api/v1/properties")]
    [Produces("application/json")]
    [ApiVersion("1.0")]
    public class GetPropertyInformationController : BaseController
    {
        private readonly IGetPropertyUseCase _getProperty;
        private readonly IGetPropertiesUseCase _getProperties;
        private readonly ILogger<GetPropertyInformationController> _logger;

        public GetPropertyInformationController(
            IGetPropertyUseCase getProperty,
            IGetPropertiesUseCase getProperties,
            ILogger<GetPropertyInformationController> logger)
        {
            _getProperty = getProperty;
            _getProperties = getProperties;
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
            var response = _getProperty.Execute(propertyReference);

            if (response != null) return Ok(response);

            return NotFound();
        }

        /// <summary>
        /// Returns a list of properties for a given address/postcode.
        /// Up to 200 properties can be requested at once
        ///
        /// If no matching properties are found, a 404 is returned.
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Produces("application/json")]
        [ProducesResponseType(typeof(IEnumerable<HousingProperty>), 200)]
        [ProducesResponseType(typeof(BadRequestResult), 400)]
        [ProducesResponseType(typeof(NotFoundResult), 404)]
        public IActionResult GetMultipleByReference([FromQuery] GetPropertiesRequest propertyReferencesRequest)
        {
            _logger.LogInformation("Multiple Property information was requested for " +
                                   propertyReferencesRequest.GetQueryDict());
            try
            {
                var useCaseResponse = _getProperties.Execute(propertyReferencesRequest);
                if (useCaseResponse is null) return NotFound();
                return Ok(useCaseResponse);
            }
            catch (InvalidQueryParameterException exception)
            {
                return BadRequest(exception.Message);
            }
        }
    }
}
