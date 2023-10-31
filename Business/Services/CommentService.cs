using Business.Models.Response;
using Business.Services.Base;
using Business.Services.Interface;
using Business.Utilities.Mapping.Interface;
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
    public class CommentService : BaseService<Comment, CommentInfoDto, int>, ICommentService
    {
        public CommentService(IMapperHelper mapperHelper, IUnitOfWork unitOfWork) : base(mapperHelper, unitOfWork.Comment, unitOfWork)
        {
        }
    }
}
