using BlazorIdentityV2.Data.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BlazorIdentityV2.Areas.Identity.Pages
{
    public class LoginModel : PageModel
    {
        private readonly SignInManager<IdentityUser> _signInManager;
        private readonly UserManager<IdentityUser> _userManager;

        public LoginModel(UserManager<IdentityUser> userManager, SignInManager<IdentityUser> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }

        [BindProperty]
        public InputModel Input { get; set; }

        public void OnGet()
        {
        }

        public async Task<IActionResult> OnPost()
        {
            if (ModelState.IsValid)
            {
                var user = await _userManager.FindByEmailAsync(Input.Email);
                if (user != null)
                {
                    var result = await _userManager.CheckPasswordAsync(user, Input.Password);
                    if (result)
                    {
                        await _signInManager.SignInAsync(user, isPersistent: false);
                        return Redirect("/");
                    }
                    // If there are any errors, add them to the ModelState object
                    // which will be displayed by the validation summary tag helper
                    ModelState.AddModelError(string.Empty, "Wrong password");
                    return Page();
                }
                ModelState.AddModelError(string.Empty, "Email not found");
                return Page();
            }

            return Page();
        }
    }
}
