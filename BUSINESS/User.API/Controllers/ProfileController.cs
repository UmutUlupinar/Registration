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

    public Task<ProfileUpdateResponseModel> UpdateProfile(ProfileUpdateRequestModel requestModel)
    {
        return _profileService.UpdateProfile(requestModel);
    }
}