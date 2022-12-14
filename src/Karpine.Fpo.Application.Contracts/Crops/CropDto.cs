using System;
using Volo.Abp.Application.Dtos;
using System.ComponentModel.DataAnnotations;
using Volo.Abp.Data;
using System.Collections.Generic;

namespace Karpine.Fpo.Crops
{
    public class CropDto : AuditedEntityDto<Guid>
    {
        public string FarmerName { get; set; }
        public string Village { get; set; }
        public string Acreage { get; set; }
        public string SurveyNo { get; set; }
        public string SoilType { get; set; }
        public string CropType { get; set; }
        public string Stage { get; set; }
        public string Ph { get; set; }
        public string Nitrogen { get; set; }
        public string Phosphurus { get; set; }
        public string Pottasium { get; set; }
        public string Magnesium { get; set; }
        public string Calcium { get; set; }
        public string Salinity { get; set; }
        public string Zinc { get; set; }
        public string Iron { get; set; }
        public string Manganese { get; set; }
        public string Copper { get; set; }
        public string Sodium { get; set; }
        public string Sulphur { get; set; }

        public string SoilTestId { get; set; }
        public string Lattitude { get; set; }
        public string Longitude { get; set; }
        public DateTime TestDate { get; set; }
        public string TestedBy { get; set; }
        public string Location { get; set; }
        public string LocationType { get; set; }
    }
}
