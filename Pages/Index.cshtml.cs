using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Data;
using System.Data.SqlClient;

namespace PHPcon_demo.Pages;

public class IndexModel : PageModel
{
    private readonly ILogger<IndexModel> _logger;

    public IndexModel(ILogger<IndexModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {

    }

    public void OnPost()
    {
        string input = Request.Form["text"];
        using (SqlConnection connection = new SqlConnection("aaa"))
        {
            SqlCommand sqlCommand = new SqlCommand()
            {
                CommandText = "SELECT ProductId FROM Products WHERE ProductName = '" + input + "'",
                CommandType = CommandType.Text,
            };
        }
    }
}
