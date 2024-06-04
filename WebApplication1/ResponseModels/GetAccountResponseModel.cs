namespace WebApplication1.ResponseModels;

public class GetAccountResponseModel
{
    public string first_name { get; set; }
    public string last_name { get; set; }
    public string email { get; set; }
    public string? phone { get; set; }
    public int FK_role { get; set; }
    
    
}