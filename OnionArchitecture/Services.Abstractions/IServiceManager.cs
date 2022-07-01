namespace Services.Abstractions
{
    public interface IServiceManager
    {
        IOwnerService OwnerService { get; set; }

        IAccountService AccountService { get; set; }
    }
}
