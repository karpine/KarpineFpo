using System;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;
using Karpine.Fpo.Permissions;
using Karpine.Fpo;
using Karpine.Fpo.FarmerProfiles;
using Karpine.Fpo.Crops;
using System.Threading.Tasks;
using System.Linq;
using System.Linq.Dynamic.Core;
using System.Collections.Generic;
using Volo.Abp.ObjectMapping;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Volo.Abp.DependencyInjection;

namespace Karpine.Fpo.Crops
{
    [Authorize]
    [IgnoreAntiforgeryToken]
    public class CropAppService :
         CrudAppService<
            Crop, //The Book entity
            CropDto, //Used to show books
            Guid, //Primary key of the book entity
            PagedAndSortedResultRequestDto, //Used for paging/sorting
            CreateUpdateCropDto>, //Used to create/update a book
        ICropAppService, ITransientDependency //implement the IBookAppService
    {
        public CropAppService(
           IRepository<Crop, Guid> repository)
           : base(repository)
        {
            
            GetPolicyName = FpoPermissions.Crops.Default;
            GetListPolicyName = FpoPermissions.Crops.Default;
            CreatePolicyName = FpoPermissions.Crops.Create;
            UpdatePolicyName = FpoPermissions.Crops.Edit;
            DeletePolicyName = FpoPermissions.Crops.Create;
        }
        [Route("GetListCompleteAsync")]
        public async Task<ListResultDto<CropDto>> GetListAsync() //TODO: Why there are two GetList. GetListPagedAsync would be enough (rename it to GetList)!
        {
            var products = await Repository.GetListAsync();

            var productList = ObjectMapper.Map<List<Crop>, List<CropDto>>(products);

            return new ListResultDto<CropDto>(productList);
        }

        [Route("GetCropListByLocationAsync")]
        public async Task<List<CropDto>> GetCropListByLocationAsync()
        {
            IQueryable<Crop> queryable = await Repository.GetQueryableAsync();
            var products = queryable
                .Distinct()
                .OrderBy(x=>x.TestDate).ToList();
            var productList = ObjectMapper.Map<List<Crop>, List<CropDto>>((List<Crop>)products);
            return productList;
        }

        [Route("GetCropListByItemIdAsync")]
        public async Task<List<CropDto>> GetCropListByItemIdAsync(string Id)
        {
            IQueryable<Crop> queryable = await Repository.GetQueryableAsync();
            var products = queryable
               .Where(x => x.SoilTestId == Id)
                .OrderByDescending(x => x.TestDate).ToList();
            var productList = ObjectMapper.Map<List<Crop>, List<CropDto>>((List<Crop>)products);
            return productList;
        }

    }
}