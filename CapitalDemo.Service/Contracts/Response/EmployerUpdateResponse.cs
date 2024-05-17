namespace CapitalDemo.Service.Contracts.Response;

public class EmployerUpdateResponse<T> : BaseResponse
{
    public T? Result { get; set; }
}
