using Microsoft.AspNetCore.Mvc;
using PropertyInformationApi.V1.UseCase;
using Microsoft.Extensions.Logging;
//using PropertyInformationApi.V1.Validation;
using System.Linq;
using PropertyInformationApi.V1.UseCase.GetMultipleProperties.Boundaries;
using PropertyInformationApi.V1.UseCase.GetPropertyChildren.Models;
using PropertyInformationApi.V1.Domain;

namespace PropertyInformationApi.V1.Controllers
{
    [ApiController]
    [Route("api/v1/properties")]
    [Produces("application/json")]
    [ApiVersion("1.0")]
    public class PropertyInformationApiController : BaseController
    {
        private IGetProperty _getPropertyUseCase;
        private ILogger<PropertyInformationApiController> _logger;
        //private IGetMultiplePropertiesUseCase _getMultiplePropertiesUseCase;
        private IGetPropertyChildrenUseCase _getPropertyChildrenUseCase;
        //private GetMultiplePropertiesValidator _getMultiplePropertiesValidator;

        public PropertyInformationApiController(IGetProperty getPropertyUseCase, ILogger<PropertyInformationApiController> logger, /*IGetMultiplePropertiesUseCase getMultiplePropertiesUseCase,*/
                                IGetPropertyChildrenUseCase getPropertyChildrenUseCase)
        {
            _getPropertyUseCase = getPropertyUseCase;
            _getPropertyChildrenUseCase = getPropertyChildrenUseCase;
            _logger = logger;
            //_getMultiplePropertiesUseCase = getMultiplePropertiesUseCase;
            //_getMultiplePropertiesValidator = new GetMultiplePropertiesValidator();
        }

        // GET a property for a given property reference
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

            if (response != null)
                return Ok(response);

            return NotFound();
        }


        /*/// <summary>
        /// Returns a list of properties for a given property references.
        /// Up to 200 properties can be requested at once
        /// If propertyReferences are not found then empty list of properties is returned with 200
        /// </summary>
        /// <param name="propertyReferencesRequest"></param>
        /// <returns></returns>
        [HttpGet]
        [Produces("application/json")]
        [ProducesResponseType(typeof(GetMultiplePropertiesUseCaseResponse), 200)]
        [ProducesResponseType(typeof(BadRequestResult), 400)]
        public IActionResult GetMultipleByReference([FromQuery]GetMultiplePropertiesUseCaseRequest propertyReferencesRequest)
        {
            _logger.LogInformation("Multiple Property information was requested for " + propertyReferencesRequest.PropertyReferences?.Select(s => s + " ").ToList());

            //var validationResult = _getMultiplePropertiesValidator.Validate(propertyReferencesRequest);
            if (!validationResult.IsValid)
            {
                return BadRequest(new GetMultiplePropertiesUseCaseResponse(validationResult));
            }

            var useCaseResponse = _getMultiplePropertiesUseCase.Execute(propertyReferencesRequest);
            return Ok(useCaseResponse);
        }*/

        /*/// <summary>
        /// Returns a list of properties whose parent is the requested property
        /// </summary>
        /// <returns></returns>
        /// <param name="propertyReference">Property reference.</param>
        [HttpGet]
        [Route("{propertyReference}/children")]
        [Produces("application/json")]
        [ProducesResponseType(typeof(GetPropertyChildrenResponse), 200)]
        [ProducesResponseType(typeof(NotFoundResult), 404)]
        public IActionResult GetChildenProperties(string propertyReference)
        {
            _logger.LogInformation("Childen properties requested for " + propertyReference);

            var getPropertyChildrenRequest = new GetPropertyChildrenRequest
            {
                PropertyReference = propertyReference
            };

            var response = _getPropertyChildrenUseCase.Execute(getPropertyChildrenRequest);
            return Ok(response);
        }*/
    }
}
