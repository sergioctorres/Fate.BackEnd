namespace Fate.BackEnd.Infra.UoW
{
    public interface IUnitOfWork
    {
        int Commit();
    }
}
