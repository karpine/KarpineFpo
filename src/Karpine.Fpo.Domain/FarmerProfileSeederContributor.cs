using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Karpine.Fpo.Domain.Helper;
using Karpine.Fpo.FarmerProfiles;
using Newtonsoft.Json;
using Volo.Abp.Data;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Domain.Repositories;

namespace Karpine.Fpo
{
    public class UserKeys
    {
        public string PublicKey { get; set; }
        public string PrivateKey { get; set; }
        public string WIF { get; set; }
        public string Address { get;set; }

    }
    public class FarmerProfileSeederContributor : IDataSeedContributor, ITransientDependency
    {
        public static string NodeUrl = "https://api.karpine.io";
        private readonly IRepository<FarmerProfile, Guid> _farmerProfileRepository;

        public FarmerProfileSeederContributor(
            IRepository<FarmerProfile, Guid> farmerProfileRepository)
        {
            _farmerProfileRepository = farmerProfileRepository;
        }

        private async Task<UserKeys> GetNewKeys()
        {
            UserKeys k = new UserKeys();
            WebRequestHelper webRequestHelper = new WebRequestHelper();
           
            var t = await WebRequestHelper.RetrieveUserKeysAsync(NodeUrl + "/api/Crypto/GenerateRandomKeyPair");
            return t;
        }
        public async Task SeedAsync(DataSeedContext context)
        {
            if (await _farmerProfileRepository.GetCountAsync() > 0)
            {
                return;
            }

            //user 1
            UserKeys k = await GetNewKeys();
          await _farmerProfileRepository.InsertAsync(
                new FarmerProfile
                {
                    PublicKey = k.PublicKey,
                    PrivateKey = k.PrivateKey,
                    CIF = k.WIF,
                    Address = k.Address,
                    FarmerName = "Krishna",
                    FatherName = "Ramesh",
                    Age = 25,
                    Gender = "Male",
                    Village = "Karakala",
                    Caste = "BC",
                    AadharNumber = "123412341234",
                    MobileNo = "9988112233",
                    SurveyNo = "144",
                    BankAccNo = "6512342134",
                    Remarks = "Soil Test Done."
                },
                autoSave: true
            );

            k = await GetNewKeys();
            await _farmerProfileRepository.InsertAsync(
                  new FarmerProfile
                  {
                      PublicKey = k.PublicKey,
                      PrivateKey = k.PrivateKey,
                      CIF = k.WIF,
                      Address = k.Address,
                      FarmerName = "Yadav",
                      FatherName = "Kamalesh",
                      Age = 25,
                      Gender = "Male",
                      Village = "Hubli",
                      Caste = "SC",
                      AadharNumber = "613412341235",
                      MobileNo = "9788112245",
                      SurveyNo = "124",
                      BankAccNo = "4512342128",
                      Remarks = "Soil Test Done."
                  },
                  autoSave: true
              );

            k = await GetNewKeys();
            await _farmerProfileRepository.InsertAsync(
                  new FarmerProfile
                  {
                      PublicKey = k.PublicKey,
                      PrivateKey = k.PrivateKey,
                      CIF = k.WIF,
                      Address = k.Address,
                      FarmerName = "Raja",
                      FatherName = "Kallesh",
                      Age = 26,
                      Gender = "Male",
                      Village = "Hubli",
                      Caste = "SC",
                      AadharNumber = "6233412341235",
                      MobileNo = "9758112245",
                      SurveyNo = "104",
                      BankAccNo = "4511542128",
                      Remarks = "Soil Test Done."
                  },
                  autoSave: true
              );

            k = await GetNewKeys();
            await _farmerProfileRepository.InsertAsync(
                  new FarmerProfile
                  {
                      PublicKey = k.PublicKey,
                      PrivateKey = k.PrivateKey,
                      CIF = k.WIF,
                      Address = k.Address,
                      FarmerName = "Tripathi",
                      FatherName = "Sanjay",
                      Age = 36,
                      Gender = "Male",
                      Village = "Karakala",
                      Caste = "SC",
                      AadharNumber = "6233412341235",
                      MobileNo = "9758112245",
                      SurveyNo = "92/1",
                      BankAccNo = "4511542128",
                      Remarks = "Soil Test Done."
                  },
                  autoSave: true
              );

            k = await GetNewKeys();
            await _farmerProfileRepository.InsertAsync(
                  new FarmerProfile
                  {
                      PublicKey = k.PublicKey,
                      PrivateKey = k.PrivateKey,
                      CIF = k.WIF,
                      Address = k.Address,
                      FarmerName = "Achyuta",
                      FatherName = "Alapati",
                      Age = 36,
                      Gender = "Male",
                      Village = "Karakala",
                      Caste = "SC",
                      AadharNumber = "6233412341235",
                      MobileNo = "9758112245",
                      SurveyNo = "33/12",
                      BankAccNo = "4511542128",
                      Remarks = "Soil Test Done."
                  },
                  autoSave: true
              );

            k = await GetNewKeys();
            await _farmerProfileRepository.InsertAsync(
                  new FarmerProfile
                  {
                      PublicKey = k.PublicKey,
                      PrivateKey = k.PrivateKey,
                      CIF = k.WIF,
                      Address = k.Address,
                      FarmerName = "Anjaneyulu",
                      FatherName = "Appa Rao",
                      Age = 25,
                      Gender = "Male",
                      Village = "Hubli",
                      Caste = "BC",
                      AadharNumber = "123412341234",
                      MobileNo = "9988112233",
                      SurveyNo = "139/1",
                      BankAccNo = "6512342134",
                      Remarks = "Soil Test Done."
                  },
                  autoSave: true
              );

            k = await GetNewKeys();
            await _farmerProfileRepository.InsertAsync(
                  new FarmerProfile
                  {
                      PublicKey = k.PublicKey,
                      PrivateKey = k.PrivateKey,
                      CIF = k.WIF,
                      Address = k.Address,
                      FarmerName = "Anish",
                      FatherName = "Anjaiah",
                      Age = 25,
                      Gender = "Male",
                      Village = "Gadag",
                      Caste = "SC",
                      AadharNumber = "613412341235",
                      MobileNo = "9788112245",
                      SurveyNo = "451",
                      BankAccNo = "4512342128",
                      Remarks = "Soil Test Done."
                  },
                  autoSave: true
              );

            k = await GetNewKeys();
            await _farmerProfileRepository.InsertAsync(
                  new FarmerProfile
                  {
                      PublicKey = k.PublicKey,
                      PrivateKey = k.PrivateKey,
                      CIF = k.WIF,
                      Address = k.Address,
                      FarmerName = "Tejaswani",
                      FatherName = "Grover",
                      Age = 26,
                      Gender = "Male",
                      Village = "Gadag",
                      Caste = "SC",
                      AadharNumber = "6233412341235",
                      MobileNo = "9758112245",
                      SurveyNo = "22/B",
                      BankAccNo = "4511542128",
                      Remarks = "Soil Test Done."
                  },
                  autoSave: true
              );

            k = await GetNewKeys();
            await _farmerProfileRepository.InsertAsync(
                  new FarmerProfile
                  {
                      PublicKey = k.PublicKey,
                      PrivateKey = k.PrivateKey,
                      CIF = k.WIF,
                      Address = k.Address,
                      FarmerName = "Satishwar",
                      FatherName = "Samuel",
                      Age = 36,
                      Gender = "Male",
                      Village = "Hospet",
                      Caste = "SC",
                      AadharNumber = "6233412341235",
                      MobileNo = "9758112245",
                      SurveyNo = "65//1",
                      BankAccNo = "4511542128",
                      Remarks = "Soil Test Done."
                  },
                  autoSave: true
              );

            k = await GetNewKeys();
            await _farmerProfileRepository.InsertAsync(
                  new FarmerProfile
                  {
                      PublicKey = k.PublicKey,
                      PrivateKey = k.PrivateKey,
                      CIF = k.WIF,
                      Address = k.Address,
                      FarmerName = "Yasmin",
                      FatherName = "Hora",
                      Age = 36,
                      Gender = "Male",
                      Village = "Hospet",
                      Caste = "SC",
                      AadharNumber = "6233412341235",
                      MobileNo = "9758112245",
                      SurveyNo = "782/2A",
                      BankAccNo = "4511542128",
                      Remarks = "Soil Test Done."
                  },
                  autoSave: true
              );
        }
    }
}