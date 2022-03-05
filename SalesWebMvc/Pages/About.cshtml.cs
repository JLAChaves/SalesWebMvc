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
        public string Professor { get; set; }
        public string Student { get; set; }
        public string Email { get; set; }

        public void OnGet()
        {
            Message = "Salles Web MVC App from C# Course";
            Professor = "Professor: Dr. Nelio Alves";
            Student = "Student: JLAChaves";
            Email = "lucas2015nxi@gmail.com";
        }
    }
}
