using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebAppDETAug2022.Pages
{
    public class HelloWebModel : PageModel
    {
        public string Message { get; set; }
      
        public string Discount{ get; set; }


        public void OnGet()
        {
            Message = "ASP.Net Core is Rocking!!";
            Discount = "save upto 225 Rs";
        }
    }
}
