using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace Karpine.Fpo.FarmerProfiles
{
    public interface IFarmerProfileAppService :
       ICrudAppService< //Defines CRUD methods
           FarmerProfileDto, //Used to show books
           Guid, //Primary key of the book entity
           PagedAndSortedResultRequestDto, //Used for paging/sorting
           CreateUpdateFarmerProfileDto> //Used to create/update a book
    {

    }
}
