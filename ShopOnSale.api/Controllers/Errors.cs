using Microsoft.AspNetCore.Mvc;

namespace ShopOnSale.api.Controllers
{
    public class Errors : Controller
    {
        public string Error404()
        {
            return "an unexpected error occurred: the specified resource was not found";
        }
    }
}