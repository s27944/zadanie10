using Microsoft.EntityFrameworkCore;
using WebApplication1.Contexts;
using WebApplication1.RequestModels;
using WebApplication1.ResponseModels;
using Zadanie10;

namespace WebApplication1.Services;

public interface IDatabaseService
{
    Task<GetAccountResponseModel> GetAccountByIdAsync(int id);
}

public class DatabaseService : IDatabaseService
{
    
    private readonly DatabaseContext _context;

    public DatabaseService(DatabaseContext context)
    {
        _context = context;
    }
    
    
    public async Task<GetAccountResponseModel> GetAccountByIdAsync(int id)
    {
        var account = await _context.Accounts
            .Include(a => a.Roles)
            .Include(a => a.Shopping_Carts)
            .ThenInclude(sc => sc.Products)
            .FirstOrDefaultAsync(a => a.AccountId == id);

        if (account == null)
        {
            return null;
        }

        return new GetAccountResponseModel
        {
            FirstName = account.FirstName,
            LastName = account.LastName,
            Email = account.Email,
            Phone = account.Phone,
            Role = account.Roles.Name,
            Cart = account.Shopping_Carts.Select(sc => new GetAccountResponseModel.ShoppingCartItem
            {
                ProductId = sc.ProductId,
                ProductName = sc.Products.Name,
                Amount = sc.Amount
            }).ToList()
        };
    }
    
    
    
    public async Task CreateProductAsync(PostProductRequestModel model)
    {
        var validCategoryIds = await _context.Categories
            .Where(c => model.ProductCategories.Contains(c.CategoryID))
            .Select(c => c.CategoryID)
            .ToListAsync();

        if (validCategoryIds.Count != model.ProductCategories.Count)
        {
            throw new KeyNotFoundException("Category ID is invalid.");
        }
        var product = new Products
        {
            Name = model.ProductName,
            Weight = model.ProductWeight,
            Width = model.ProductWidth,
            Height = model.ProductHeight,
            Depth = model.ProductDepth
        };

        _context.Products.Add(product);
        await _context.SaveChangesAsync();

        var productCategories = model.ProductCategories.Select(categoryId => new Products_Categories
        {
            ProductId = product.ProductID,
            CategoryId = categoryId
        }).ToList();

        _context.Products_Categories.AddRange(productCategories);
        await _context.SaveChangesAsync();
    }
}