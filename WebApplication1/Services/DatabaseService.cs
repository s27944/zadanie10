using WebApplication1.ResponseModels;

namespace WebApplication1.Services;

public interface IDatabaseService
{
    Task<GetAccountResponseModel> GetAccountByIdAsync(int id);
}

public class DatabaseService : IDatabaseService
{
    public Task<GetAccountResponseModel> GetAccountByIdAsync(int id)
    {
        throw new NotImplementedException();
    }
}