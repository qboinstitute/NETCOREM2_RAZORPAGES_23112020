using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Sales.BusinessObject;

namespace NETCOREM2_RAZORPAGES.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }
        [BindProperty]
        public List<Producto> productos { get; set; }
        public void OnGet()
        {
            productos = new List<Producto>();
            Producto prod1 = new Producto();
            prod1.Id = 1;
            prod1.Descripcion = "Televisor UHD";
            prod1.Precio = 3300;

            Producto prod2 = new Producto();
            prod2.Id = 2;
            prod2.Descripcion = "Play Station 5";
            prod2.Precio = 3000;

            productos.Add(prod1);
            productos.Add(prod2);


        }

        public void OnPost(string Correo, string Clave)
        { 
        
        }

        public void OnPostAutenticacion(string Correo, string Clave)
        { 
        
        
        }
    }
}
