using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using polymorphic_model_binding.BinderProviders;
using polymorphic_model_binding.Models;

namespace polymorphic_model_binding.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        [ModelBinder(BinderType = typeof(DeviceModelBinder))]
        [BindProperty]
        public Device Device { get; set; }

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            Device = new Laptop { Kind = "Laptop", CPUIndex = "CPU" };
        }

        public void OnPost()
        {

        }
    }
}
