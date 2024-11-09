using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using SupermarketWEB.Data;
using SupermarketWEB.Models;
using System.Security.Claims;

namespace SupermarketWEB.Pages.Account
{
	
	public class LoginModel : PageModel
    {
        private readonly SupermarketContext _context;

        public LoginModel(SupermarketContext context)
        {
            _context = context;
        }

        public IList<User> Users { get; set; } = default!;

        [BindProperty]
		public User User { get; set; }
		public void OnGet()
        {
        }

       public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            // Valida En BD
            var user = await _context.Users.FirstOrDefaultAsync(m => m.Email == User.Email && m.Password == User.Password);

            if (user != null)
            {
                // Crear los Claims 
                var claims = new List<Claim>
        {
            new Claim(ClaimTypes.Name, user.Email),  
            new Claim(ClaimTypes.Email,user.Password)
        };

                var identity = new ClaimsIdentity(claims, "MyCookieAuth");

                ClaimsPrincipal claimsPrincipal = new ClaimsPrincipal(identity);

                await HttpContext.SignInAsync("MyCookieAuth", claimsPrincipal);

                return RedirectToPage("/Index");  // Manda al Home
            }

            ModelState.AddModelError(string.Empty, "Correo o contraseña incorrectos.");
            return Page();
        }
        }
}
