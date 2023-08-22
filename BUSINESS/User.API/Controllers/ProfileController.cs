using Microsoft.AspNetCore.Mvc;
using User.Service.Models.Profile;
using User.Service.Profile;

namespace User.API.Controllers;

[ApiController]
[Route("[controller]/[action]")]
public class ProfileController : Controller
{
    private readonly IProfileService _profileService;

    public ProfileController(IProfileService profileService)
    {
        _profileService = profileService;
    }
    
    /// <summary>
    /// this action provides to update profile
    /// </summary>
    /// <param name="requestModel"></param>
    /// <returns></returns>
    [HttpPost]
    public Task<ProfileUpdateResponseModel> UpdateProfile([FromQuery]ProfileUpdateRequestModel requestModel)
    {
        return _profileService.UpdateProfile(requestModel);
    }
}