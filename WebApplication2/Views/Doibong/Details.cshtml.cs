﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using WebApplication2.Data;
using WebApplication2.Models;

namespace WebApplication2.Views.Doibong
{
    public class DetailsModel : PageModel
    {
        private readonly WebApplication2.Data.WebApplication2Context _context;

        public DetailsModel(WebApplication2.Data.WebApplication2Context context)
        {
            _context = context;
        }

      public Doibong Doibong { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Doibong == null)
            {
                return NotFound();
            }

            var doibong = await _context.Doibong.FirstOrDefaultAsync(m => m.Id == id);
            if (doibong == null)
            {
                return NotFound();
            }
            else 
            {
                Doibong = doibong;
            }
            return Page();
        }
    }
}
