using Microsoft.EntityFrameworkCore;
using User.Service.Models.Profile;

namespace User.Service.Profile;

public interface IProfileService
{
    Task<ProfileUpdateResponseModel> UpdateProfile(ProfileUpdateRequestModel updateRequestModel);
}