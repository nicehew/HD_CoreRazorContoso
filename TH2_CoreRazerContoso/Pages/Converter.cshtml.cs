using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace TH2_CoreRazerContoso.Pages
{
    public class ConverterModel : PageModel
    {
        public decimal Pounds { get; set; }
        public decimal Euros { get; set; }

        public void OnGet()
        {

        }

        public void OnPost()
        {

        }
    }
}