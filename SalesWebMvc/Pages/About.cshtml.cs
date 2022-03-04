using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesWebMvc.Pages
{
    public class AboutModel : PageModel
    {
        public string Message { get; set; }
        public string Student { get; set; }

        public void OnGet()
        {
            Message = "Salles Web MVC App from c# Course";
            Student = "Student: JLAChaves";
        }
    }
}
