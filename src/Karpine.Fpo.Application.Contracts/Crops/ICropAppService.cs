using Karpine.Fpo.Crops;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace Karpine.Fpo.Crops
{
    public interface ICropAppService :
        ICrudAppService< //Defines CRUD methods
            CropDto, //Used to show books
            Guid, //Primary key of the book entity
            PagedAndSortedResultRequestDto, //Used for paging/sorting
            CreateUpdateCropDto> //Used to create/update a book
    {
        Task<ListResultDto<CropDto>> GetListAsync();
        Task<List<CropDto>> GetCropListByLocationAsync();

        Task<List<CropDto>> GetCropListByItemIdAsync(string Id);
    }
}
