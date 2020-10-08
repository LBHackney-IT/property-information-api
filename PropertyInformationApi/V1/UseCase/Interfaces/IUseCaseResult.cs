namespace PropertyInformationApi.V1.UseCase
{
    public interface IUseCaseResult<TRequest, TResponse>
    {
        TResponse Execute(TRequest request);
    }
}
