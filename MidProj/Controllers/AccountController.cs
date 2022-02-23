using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MidProj.Models;
using System.Threading.Tasks;

namespace MidProj.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly SignInManager<IdentityUser> _signInManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        public AccountController(UserManager<IdentityUser> userManager, SignInManager<IdentityUser> signInManager, RoleManager<IdentityRole> roleManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _roleManager = roleManager;

        }
        [HttpGet]
        public IActionResult Login()
        {
            return RedirectToAction("CreateRoles");

        }
        [HttpGet]

        public IActionResult Register()
        {
            return View();

        }
        [HttpPost]
        public async Task<IActionResult> Login(LoginModel model)
        {
            if (ModelState.IsValid)
            {
                var result = await _signInManager.PasswordSignInAsync(model.Username, model.Password, false, false);
                if (result.Succeeded)
                {
                    return RedirectToAction("Home", "Home");
                }
                
            }
            ViewBag.usercreated = "Username or password was wrong.";
            ViewBag.usercreatedmassage = "";
            return View();
        }

        public IActionResult Logout()
        {
            _signInManager.SignOutAsync();
            return RedirectToAction("Login", "Account");
        }
        [HttpPost]
        public async Task<IActionResult> Register(string username, string password)
        {
            if (password !=null & username != null)
            {
                IdentityUser user = new IdentityUser
                {
                    UserName = username,
                };

                var result = await _userManager.CreateAsync(user, password);

                if (result.Succeeded)
                {
                    ViewBag.usercreated = "";
                    ViewBag.usercreatedmassage = "User created successfully!.";
                    return View("Login");
                }
            }
            return View();

        }

        public async Task<IActionResult> CreateRoles()
        {
            
            IdentityRole role = new IdentityRole();
            role.Name = "Administrators";
            await _roleManager.CreateAsync(role);

            IdentityUser admin = new IdentityUser
            {
                UserName = "administrator",
            };
            await _userManager.CreateAsync(admin, "123qwe!Q");

            await _userManager.AddToRoleAsync(admin, "Administrators");

            return View("Login");
            
        }
    }
}
