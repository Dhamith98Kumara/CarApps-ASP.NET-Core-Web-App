using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CarApps.Pages.Checkouts
{
    [BindProperties(SupportsGet = true)]
    public class CheckoutModel : PageModel
    {



        public string CarNumberPlateName { get; set; }

        public float CarPrice { get; set; }

        public void OnGet()
        {
            if (string.IsNullOrWhiteSpace(CarNumberPlateName))
            {
                CarNumberPlateName = "Custom Car";
            }
        }



    }
}
