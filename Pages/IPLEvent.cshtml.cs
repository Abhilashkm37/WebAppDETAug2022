

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebAppDETAug2022.Models;

namespace WebAppDETAug2022.Pages
{
    public class IPLEventsModel:PageModel
    {
        public List<Ticket>Ticket{get;set;}
        public void OnGet()
        {
            Ticket=new List<Ticket>{
            new Ticket{Id=6,Name="ghf",Price=200000},
            new Ticket{Id=8,Name="guy",Price=300000},
            new Ticket{Id=4,Name="vhj",Price=500000},
            new Ticket{Id=1,Name="hgh",Price=500000},
            new Ticket{Id=2,Name="Abhilash",Price=100000}
        };
        }
    }
}

