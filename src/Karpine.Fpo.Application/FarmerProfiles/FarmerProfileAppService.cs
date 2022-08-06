using System;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace Karpine.Fpo.FarmerProfiles
{
    public class FarmerProfileAppService :
        CrudAppService<
            FarmerProfile, //The Book entity
            FarmerProfileDto, //Used to show books
            Guid, //Primary key of the book entity
            PagedAndSortedResultRequestDto, //Used for paging/sorting
            CreateUpdateFarmerProfileDto>, //Used to create/update a book
        IFarmerProfileAppService //implement the IBookAppService
    {
        public FarmerProfileAppService(IRepository<FarmerProfile, Guid> repository)
            : base(repository)
        {

        }
    }
}
