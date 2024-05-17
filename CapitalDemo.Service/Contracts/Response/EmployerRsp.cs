namespace CapitalDemo.Service.Contracts.Response;

public class EmployerRsp<T> : BaseResponse
{
    public T? Result { get; set; }
}
