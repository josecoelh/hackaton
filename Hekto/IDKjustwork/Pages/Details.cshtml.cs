using Microsoft.AspNetCore.Mvc;
using IDKjustwork.Model;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace IDKjustwork.Pages
{
    public class DetailsModel : PageModel
    {
        //new Model
        public  string Sku { get; set; }
        public void OnGet(string sku)
        {
            Sku = sku;
        }
    }
}
