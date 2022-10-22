using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarApps.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CarApps.Pages.Forms
{
    public class CustomCarModel : PageModel
    {
        [BindProperty]
        public CarsModel Cars { get; set; }
        public float CarPrice { get; set; }

        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {

            CarPrice = Cars.BasePrice;
            if (Cars.Autopilot) CarPrice += 2000;
            if (Cars.ExteriorPaint) CarPrice += 50000;
            if (Cars.InteriorColor) CarPrice += 10050;

            return RedirectToPage("/Checkouts/Checkout", new { Cars.CarNumberPlateName, CarPrice });


        }


    }
}
