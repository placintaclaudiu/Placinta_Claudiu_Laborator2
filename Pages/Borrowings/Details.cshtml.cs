using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Placinta_Claudiu_Laborator2.Data;
using Placinta_Claudiu_Laborator2.Models;

namespace Placinta_Claudiu_Laborator2.Pages.Borrowings
{
    public class DetailsModel : PageModel
    {
        private readonly Placinta_Claudiu_Laborator2.Data.Placinta_Claudiu_Laborator2Context _context;

        public DetailsModel(Placinta_Claudiu_Laborator2.Data.Placinta_Claudiu_Laborator2Context context)
        {
            _context = context;
        }

      public Borrowing Borrowing { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Borrowing == null)
            {
                return NotFound();
            }

            var borrowing = await _context.Borrowing.Include(b => b.Member).Include(b => b.Book).FirstOrDefaultAsync(m => m.ID == id);
            if (borrowing == null)
            {
                return NotFound();
            }
            else 
            {
                Borrowing = borrowing;
            }
            return Page();
        }
    }
}
