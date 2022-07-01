namespace Domain.Repositories
{

    public interface IRepositoryManager
    {

        IOwnerRepository OwnerRepository { get; set; }
        
        IAccountRepository AccountRepository { get; set; }
        
        IUnitOfWork UnitOfWork { get; set; }
    }

}