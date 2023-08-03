using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using learningEFCore.Data;
using learningEFCore.Models;

namespace learningEFCore.Pages.Products
{
    public class IndexModel : PageModel
    {
        private readonly learningEFCore.Data.SqlServerContainerContext _context;

        public IndexModel(learningEFCore.Data.SqlServerContainerContext context)
        {
            _context = context;
        }

        public IList<Product> Product { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Products != null)
            {
                Product = await _context.Products.ToListAsync();
            }
        }
    }
}
