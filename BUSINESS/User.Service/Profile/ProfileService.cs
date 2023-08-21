using Microsoft.EntityFrameworkCore;
using User.Core.Enums;
using User.DataAccess.Repository.Abstract;
using User.Service.Models.Profile;

namespace User.Service.Profile;

public class ProfileService :IProfileService
{
    private readonly IProfileRepository _profileRepository;

    public ProfileService(IProfileRepository profileRepository)
    {
        _profileRepository = profileRepository;
    }

    public Task<ProfileUpdateResponseModel> UpdateProfile(ProfileUpdateRequestModel updateRequestModel)
    {
        var profile = _profileRepository.AsQueryable()
            .Include(p => p.User)
            .FirstOrDefault(p => p.User.Id == Guid.Parse(updateRequestModel.UserId));

        var updatedProfile = new Core.Entities.Profile()
        {
            Id = profile.Id,
            UserId = profile.UserId,
            Name = updateRequestModel.UserName,
            LastName = updateRequestModel.LastName,
            PhoneNumber = updateRequestModel.PhoneNumber,
            Status = Status.Active,
            UpdatedTime = DateTime.Now,
            User = new Core.Entities.User()
            {
                UserName = updateRequestModel.UserName,
                Password = updateRequestModel.Password,
                Status = Status.Active,
                UpdatedTime = DateTime.Now,
                Mail = updateRequestModel.Mail
            }
        };
        var profileResponseEntity = _profileRepository.Update(updatedProfile).Entity;
        var profileUpdateResponseModel= new ProfileUpdateResponseModel()
            {
                Mail = profileResponseEntity.User.Mail,
                LastName = profileResponseEntity.LastName,
                Name = profileResponseEntity.Name,
                PhoneNumber = profileResponseEntity.PhoneNumber,
                UserName = profileResponseEntity.User.UserName
                
            };
        return Task.FromResult(profileUpdateResponseModel);


    }
}