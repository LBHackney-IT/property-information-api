using Microsoft.AspNetCore.Mvc;
using PropertyInformationApi.V1.UseCase;
using PropertyInformationApi.V1.UseCase.GetPropertyChildren.Models;

namespace PropertyInformationApi.V1.Controllers
{
    // Deprecated path and endpoint
    [ApiVersion("1")]
    [Route("api/v1/property")]
    [ApiController]
    [Produces("application/json")]
    public class PropertyChildrenController : BaseController
    {
        private readonly IGetPropertyChildrenUseCase _getPropertyChildrenUseCase;

        public PropertyChildrenController(IGetPropertyChildrenUseCase getPropertyChildrenUseCase)
        {
            _getPropertyChildrenUseCase = getPropertyChildrenUseCase;
        }

        [HttpGet]
        [Route("{propertyReference}/children")]
        [Produces("application/json")]
        [ProducesResponseType(typeof(GetPropertyChildrenResponse), 200)]
        [ProducesResponseType(typeof(NotFoundResult), 404)]
        [ApiExplorerSettings(IgnoreApi = true)]
        public IActionResult Get(string propertyReference)
        {
            var getPropertyChildrenRequest = new GetPropertyChildrenRequest
            {
                PropertyReference = propertyReference
            };

            var response = _getPropertyChildrenUseCase.Execute(getPropertyChildrenRequest);
            Response?.Headers?.Add("Warning", "299 This endpoint is deprecated. Please use /properties/{propertyReference}/children instead");
            return Ok(response);
        }
    }
}
