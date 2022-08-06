using System;
using Volo.Abp.Application.Dtos;
using System.ComponentModel.DataAnnotations;
using Volo.Abp.Data;
using System.Collections.Generic;

namespace Karpine.Fpo.FarmerProfiles
{
    public class FarmerProfileDto : AuditedEntityDto<Guid>
    {
        public string PublicKey { get; set; }
        public string PrivateKey { get; set; }
        public string CIF { get; set; }
        public string Address { get; set; }
        public string FIGNo { get; set; }
        public string FarmerName { get; set; }
        public string FatherName { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public string Village { get; set; }

        public string Caste { get; set; }
        public string AadharNumber { get; set; }
        public string MobileNo { get; set; }
        public string SurveyNo { get; set; }
        public string BankAccNo { get; set; }
        public string Remarks { get; set; }
    }
}
