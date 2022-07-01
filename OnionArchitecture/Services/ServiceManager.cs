using Domain.Repositories;
using Services.Abstractions;

namespace Services
{

    public sealed class ServiceManager : IServiceManager
    {

        private readonly Lazy<IOwnerService> _lazyOwnerService;
        private readonly Lazy<IAccountService> _lazyAccountService;

        public ServiceManager(IRepositoryManager repositoryManager)
        {
            _lazyOwnerService = new Lazy<IOwnerService>(() => new OwnerService(repositoryManager));
            _lazyAccountService = new Lazy<IAccountService>(() => new AccountService(repositoryManager));
        }

        public IOwnerService OwnerService
        {
            get => _lazyOwnerService.Value;
            set => throw new NotImplementedException();
        }

        public IAccountService AccountService
        {
            get => _lazyAccountService.Value;
            set => throw new NotImplementedException();
        }
    }
}
