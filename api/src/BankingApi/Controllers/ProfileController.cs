namespace BankingApi.Controllers;

using BankingApi.Model;
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("[controller]")]
public class ProfileController : ControllerBase
{
    private readonly ProfileService _profileService;

    public ProfileController(ProfileService profileService)
    {
        _profileService = profileService;
    }

    [HttpGet]
    public IActionResult GetProfile()
    {
        return Ok();
    }
}
