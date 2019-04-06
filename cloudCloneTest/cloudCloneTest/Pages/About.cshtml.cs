using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;

namespace cloudCloneTest.Pages
{
    public class AboutModel : PageModel
    {
        private IConfiguration configuration;
        public AboutModel(IConfiguration configuration)
        {
            this.configuration = configuration;

        }
        public string Message { get; set; }

        public void OnGet()
        {
            throw new Exception("afafasf");
            Message = this.configuration["greeting"];
        }
    }
}
