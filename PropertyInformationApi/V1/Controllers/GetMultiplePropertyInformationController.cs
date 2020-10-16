// using Microsoft.AspNetCore.Mvc;
// using PropertyInformationApi.V1.UseCase;
// using Microsoft.Extensions.Logging;
// using PropertyInformationApi.V1.UseCase.GetMultipleProperties.Boundaries;
// using PropertyInformationApi.V1.UseCase.GetPropertyChildren.Models;
//
// namespace PropertyInformationApi.V1.Controllers
// {
//     [ApiController]
//     [Route("api/v1/properties")]
//     [Produces("application/json")]
//     [ApiVersion("1.0")]
//     public class GetMultiplePropertyInformationController : BaseController
//     {
//         private IGetPropertyUseCase                       _getPropertyUseCase;
//         private ILogger<GetPropertyInformationController> _logger;
//
//         // private IGetPropertyChildrenUseCase _getPropertyChildrenUseCase;
//         // private IGetMultiplePropertiesUseCase _getMultiplePropertiesUseCase;
//         // private GetMultiplePropertiesValidator _getMultiplePropertiesValidator;
//
//         public GetMultiplePropertyInformationController(
//             ILogger<GetPropertyInformationController> logger,
//             IGetMultiplePropertiesUseCase             getMultiplePropertiesUseCase,
//             IGetPropertyChildrenUseCase               getPropertyChildrenUseCase)
//         {
//             _getPropertyUseCase = getPropertyUseCase;
//             _logger             = logger;
//             _getPropertyChildrenUseCase     = getPropertyChildrenUseCase;
//             _getMultiplePropertiesUseCase   = getMultiplePropertiesUseCase;
//             _getMultiplePropertiesValidator = new GetMultiplePropertiesValidator();
//         }
//
//         /// <summary>
//         /// Returns a list of properties for a given property references.
//         /// Up to 200 properties can be requested at once
//         /// If propertyReferences are not found then empty list of properties is returned with 200
//         /// </summary>
//         /// <param name="propertyReferencesRequest"></param>
//         /// <returns></returns>
//         [HttpGet]
//         [Produces("application/json")]
//         [ProducesResponseType(typeof(GetMultiplePropertiesUseCaseResponse), 200)]
//         [ProducesResponseType(typeof(BadRequestResult), 400)]
//         public IActionResult GetMultipleByReference([FromQuery]GetMultiplePropertiesUseCaseRequest propertyReferencesRequest)
//         {
//             _logger.LogInformation("Multiple Property information was requested for " + propertyReferencesRequest.PropertyReferences?.Select(s => s + " ").ToList());
//
//             //var validationResult = _getMultiplePropertiesValidator.Validate(propertyReferencesRequest);
//             if (!validationResult.IsValid)
//             {
//                 return BadRequest(new GetMultiplePropertiesUseCaseResponse(validationResult));
//             }
//
//             var useCaseResponse = _getMultiplePropertiesUseCase.Execute(propertyReferencesRequest);
//             return Ok(useCaseResponse);
//         }
//
//         /// <summary>
//         /// Returns a list of properties whose parent is the requested property
//         /// </summary>
//         /// <returns></returns>
//         /// <param name="propertyReference">Property reference.</param>
//         [HttpGet]
//         [Route("{propertyReference}/children")]
//         [Produces("application/json")]
//         [ProducesResponseType(typeof(GetPropertyChildrenResponse), 200)]
//         [ProducesResponseType(typeof(NotFoundResult), 404)]
//         public IActionResult GetChildenProperties(string propertyReference)
//         {
//             _logger.LogInformation("Childen properties requested for " + propertyReference);
//
//             var getPropertyChildrenRequest = new GetPropertyChildrenRequest
//             {
//                 PropertyReference = propertyReference
//             };
//
//             var response = _getPropertyChildrenUseCase.Execute(getPropertyChildrenRequest);
//             return Ok(response);
//         }
//     }
// }
