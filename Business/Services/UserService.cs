using Business.Models.Request.Create;
using Business.Models.Response;
using Business.Services.Base;
using Business.Services.Interface;
using Business.Utilities.Mapping.Interface;
using Business.Utilities.Security.Auth.Jwt.Interface;
using Core.Constants;
using Core.Results;
using Infrastructure.Data.Postgres;
using Infrastructure.Data.Postgres.Entities;
using Infrastructure.Data.Postgres.Repositories.Base.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Services
{
    public class UserService : BaseService<User, UserProfileDto, int>,IProfileService
    {
        IHashingHelper _hashingHelper;
        public UserService(IMapperHelper mapperHelper, IUnitOfWork unitOfWork,IHashingHelper hashingHelper) : base(mapperHelper, unitOfWork.Users, unitOfWork)
        {
            _hashingHelper = hashingHelper;
        }

        public async Task<Result> ChangePasswordAsync(PasswordChangeDTO pwDto)
        {
            User? user = await _unitOfWork.Users.FirstOrDefaultAsync(u => u.Email == pwDto.Email);
            if (user != null && pwDto.Password.Length > 7)
            {

                _hashingHelper.CreatePasswordHash(pwDto.Password, out var passwordHash, out var passwordSalt);

                user.PasswordHash = passwordHash;

                user.PasswordSalt = passwordSalt;

                _unitOfWork.Users.Update(user);

                int a = await _unitOfWork.CommitAsync();
                if (a > 0)
                {
                    return new Result(Messages.Success, ResultStatus.Ok);
                }
                else
                {
                    return new Result(Messages.Error, ResultStatus.Error);
                }


            }
            return new Result(Messages.Error, ResultStatus.Error);
        }
        
    }
}
