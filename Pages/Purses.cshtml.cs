using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Microsoft.EntityFrameworkCore;
using _3312FinalSpring22.Models;


namespace _3312FinalSpring22.Pages
{
    public class PursesModel : PageModel
    {
        private readonly PurseDbContext _context;
        private readonly ILogger<PursesModel> _logger;
        public List<Purse> Purses {get; set;}
        [BindProperty]
        public string PSize {get; set;}
        public string PBrand {get; set;}
        public string PColor {get; set;}
        public string PStyle  {get; set;}

        public PursesModel(PurseDbContext context, ILogger<PursesModel> logger)
        {
            _context = context;
            _logger = logger;
        }

        public void OnGet()
        {
            Purses = _context.Purse.ToList();
        }


    }
}