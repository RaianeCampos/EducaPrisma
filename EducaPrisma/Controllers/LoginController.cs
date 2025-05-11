using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication.Google;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

[Route("[controller]")]
public class LoginController : Controller
{
    private readonly ILogger<LoginController> _logger;
    public LoginController(ILogger<LoginController> logger)
    {
        _logger = logger;
    }


    [HttpGet]
    public IActionResult Index()
    {
        if (User.Identity.IsAuthenticated)
        {
            return RedirectToAction("Index", "Home");
        }
        _logger.LogInformation("Iniciando autenticação Google");
        return View();
    }

    ////[HttpGet("login/google")]
    //[HttpGet("google-login")]
    [HttpGet("google")]
    public IActionResult LoginGoogle()
    {
        var properties = new AuthenticationProperties
        {
            RedirectUri = Url.Action("GoogleCallback"),
            Items =
        {
            { "LoginProvider", GoogleDefaults.AuthenticationScheme },
            { "scheme", GoogleDefaults.AuthenticationScheme },
        },
            AllowRefresh = true
            //ExpiresUtc = DateTimeOffset.UtcNow.AddHours(1)
        };

        return Challenge(properties, GoogleDefaults.AuthenticationScheme);
    }

    //[HttpGet("login/google-callback")]
    [HttpGet("google-callback")]
    public async Task<IActionResult> GoogleCallback()
    {
        var result = await HttpContext.AuthenticateAsync(GoogleDefaults.AuthenticationScheme);

        if (!result.Succeeded)
            return RedirectToAction("Index");

        var email = result.Principal.FindFirst(ClaimTypes.Email)?.Value;
        var name = result.Principal.FindFirst(ClaimTypes.Name)?.Value;


        // Aqui você normalmente:
        // 1. Verifica se o usuário existe no seu banco
        // 2. Cria um novo usuário se necessário
        // 3. Faz login no seu sistema

        // Cria cookie de autenticação
        await HttpContext.SignInAsync(
            CookieAuthenticationDefaults.AuthenticationScheme,
            result.Principal,
            new AuthenticationProperties { IsPersistent = true });

        return RedirectToAction("Index", "Home");
    }

    [HttpGet("logout")]
    public async Task<IActionResult> Logout()
    {
        await HttpContext.SignOutAsync();
        return RedirectToAction("Index");
    }
}