using System;
using System.Threading.Tasks;
using Karpine.Fpo.Crops;
using Karpine.Fpo.Domain.Helper;
using Volo.Abp.Data;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Domain.Repositories;

namespace Karpine.Fpo
{
    public class CropDataSeederContributor : IDataSeedContributor, ITransientDependency
    {
        private readonly IRepository<Crop, Guid> _cropRepository;
       
        public CropDataSeederContributor(
            IRepository<Crop, Guid> cropRepository)
        {
            _cropRepository = cropRepository;
        }

        public async Task SeedAsync(DataSeedContext context)
        {
            if (await _cropRepository.GetCountAsync() > 0)
            {
                return;
            }
            Crop c = new Crop
            {
                FarmerName = "Krishna",
                Village = "Karakala",
                Acreage = "2.4",
                SurveyNo = "14/2",
                SoilType = "Loamy",
                CropType = "Banana",
                Stage = "Initial",
                Ph = "5.3",
                Nitrogen = "4",
                Phosphurus = "2",
                Pottasium = "6",
                Magnesium = "12",
                Calcium = "10",
                Salinity = "2",
                Zinc = "3.2",
                Iron = "4.5",
                Manganese = "3",
                Copper = "1",
                Sodium = "14",
                Sulphur = "12",
                SoilTestId = "KA608894",
                Lattitude = "13° 11´ 37.984˝",
                Longitude = "74° 55´ 24.352˝",
                TestDate = new DateTime(2022, 07, 31),
                TestedBy = "Nitte Karakala",
                Location = "Karakala",
                LocationType = "Farm"
            };
            await _cropRepository.InsertAsync(
               c ,
                autoSave: true
            );
            BlockChainHelper.AddMessageObject(c);

            c = new Crop
            {
                FarmerName = "Krishna",
                Village = "Karakala",
                Acreage = "2.4",
                SurveyNo = "14/2",
                SoilType = "Loamy",
                CropType = "Banana",
                Stage = "Initial",
                Ph = "5.3",
                Nitrogen = "4",
                Phosphurus = "2",
                Pottasium = "6",
                Magnesium = "12",
                Calcium = "10",
                Salinity = "2",
                Zinc = "3.2",
                Iron = "4.5",
                Manganese = "3",
                Copper = "1",
                Sodium = "14",
                Sulphur = "12",
                SoilTestId = "KA608894",
                Lattitude = "13° 11´ 37.984˝",
                Longitude = "74° 55´ 24.352˝",
                TestDate = new DateTime(2022, 08, 01),
                TestedBy = "Nitte Karakala",
                Location = "Karakala",
                LocationType = "FPO"
            };
            await _cropRepository.InsertAsync(
               c,
                autoSave: true
            );
            BlockChainHelper.AddMessageObject(c);

            c = new Crop
            {
                FarmerName = "Krishna",
                Village = "Karakala",
                Acreage = "2.4",
                SurveyNo = "14/2",
                SoilType = "Loamy",
                CropType = "Banana",
                Stage = "Initial",
                Ph = "5.3",
                Nitrogen = "4",
                Phosphurus = "2",
                Pottasium = "6",
                Magnesium = "12",
                Calcium = "10",
                Salinity = "2",
                Zinc = "3.2",
                Iron = "4.5",
                Manganese = "3",
                Copper = "1",
                Sodium = "14",
                Sulphur = "12",
                SoilTestId = "KA608894",
                Lattitude = "13° 11´ 37.984˝",
                Longitude = "74° 55´ 24.352˝",
                TestDate = new DateTime(2022, 08, 03),
                TestedBy = "Nitte Karakala",
                Location = "Udupi",
                LocationType = "Logistics"
            };
            await _cropRepository.InsertAsync(
               c,
                autoSave: true
            );
            BlockChainHelper.AddMessageObject(c);

            c = new Crop
            {
                FarmerName = "Krishna",
                Village = "Karakala",
                Acreage = "2.4",
                SurveyNo = "14/2",
                SoilType = "Loamy",
                CropType = "Banana",
                Stage = "Initial",
                Ph = "5.3",
                Nitrogen = "4",
                Phosphurus = "2",
                Pottasium = "6",
                Magnesium = "12",
                Calcium = "10",
                Salinity = "2",
                Zinc = "3.2",
                Iron = "4.5",
                Manganese = "3",
                Copper = "1",
                Sodium = "14",
                Sulphur = "12",
                SoilTestId = "KA608894",
                Lattitude = "13° 11´ 37.984˝",
                Longitude = "74° 55´ 24.352˝",
                TestDate = new DateTime(2022, 08, 05),
                TestedBy = "Nitte Karakala",
                Location = "Udupi",
                LocationType = "Store"
            };
            await _cropRepository.InsertAsync(
               c,
                autoSave: true
            );
            BlockChainHelper.AddMessageObject(c);


            //item 2

            c = new Crop
            {
                FarmerName = "Ramesh",
                Village = "Karakala",
                Acreage = "4",
                SurveyNo = "24/1",
                SoilType = "Loamy",
                CropType = "Arecanut",
                Stage = "Initial",
                Ph = "5.3",
                Nitrogen = "4",
                Phosphurus = "2",
                Pottasium = "6",
                Magnesium = "12",
                Calcium = "10",
                Salinity = "2",
                Zinc = "3.2",
                Iron = "4.5",
                Manganese = "3",
                Copper = "1",
                Sodium = "14",
                Sulphur = "12",
                SoilTestId = "KA608897",
                Lattitude = "13° 11´ 37.984˝",
                Longitude = "74° 55´ 24.352˝",
                TestDate = new DateTime(2022, 07, 29),
                TestedBy = "Nitte Karakala",
                Location = "Karakala",
                LocationType = "Farm"
            };
            await _cropRepository.InsertAsync(
               c,
                autoSave: true
            );
            BlockChainHelper.AddMessageObject(c);

            c = new Crop
            {
                FarmerName = "Ramesh",
                Village = "Karakala",
                Acreage = "4",
                SurveyNo = "24/1",
                SoilType = "Loamy",
                CropType = "Banana",
                Stage = "Initial",
                Ph = "5.3",
                Nitrogen = "4",
                Phosphurus = "2",
                Pottasium = "6",
                Magnesium = "12",
                Calcium = "10",
                Salinity = "2",
                Zinc = "3.2",
                Iron = "4.5",
                Manganese = "3",
                Copper = "1",
                Sodium = "14",
                Sulphur = "12",
                SoilTestId = "KA608897",
                Lattitude = "13° 11´ 37.984˝",
                Longitude = "74° 55´ 24.352˝",
                TestDate = new DateTime(2022, 08, 02),
                TestedBy = "Nitte Karakala",
                Location = "Karakala",
                LocationType = "FPO"
            };
            await _cropRepository.InsertAsync(
               c,
                autoSave: true
            );
            BlockChainHelper.AddMessageObject(c);

            c = new Crop
            {
                FarmerName = "Ramesh",
                Village = "Karakala",
                Acreage = "4",
                SurveyNo = "24/1",
                SoilType = "Loamy",
                CropType = "Banana",
                Stage = "Initial",
                Ph = "5.3",
                Nitrogen = "4",
                Phosphurus = "2",
                Pottasium = "6",
                Magnesium = "12",
                Calcium = "10",
                Salinity = "2",
                Zinc = "3.2",
                Iron = "4.5",
                Manganese = "3",
                Copper = "1",
                Sodium = "14",
                Sulphur = "12",
                SoilTestId = "KA608897",
                Lattitude = "13° 11´ 37.984˝",
                Longitude = "74° 55´ 24.352˝",
                TestDate = new DateTime(2022, 08, 04),
                TestedBy = "Nitte Karakala",
                Location = "Udupi",
                LocationType = "Logistics"
            };
            await _cropRepository.InsertAsync(
               c,
                autoSave: true
            );
            BlockChainHelper.AddMessageObject(c);

            c = new Crop
            {
                FarmerName = "Ramesh",
                Village = "Karakala",
                Acreage = "4",
                SurveyNo = "24/1",
                SoilType = "Loamy",
                CropType = "Banana",
                Stage = "Initial",
                Ph = "5.3",
                Nitrogen = "4",
                Phosphurus = "2",
                Pottasium = "6",
                Magnesium = "12",
                Calcium = "10",
                Salinity = "2",
                Zinc = "3.2",
                Iron = "4.5",
                Manganese = "3",
                Copper = "1",
                Sodium = "14",
                Sulphur = "12",
                SoilTestId = "KA608897",
                Lattitude = "13° 11´ 37.984˝",
                Longitude = "74° 55´ 24.352˝",
                TestDate = new DateTime(2022, 08, 05),
                TestedBy = "Nitte Karakala",
                Location = "Udupi",
                LocationType = "Store"
            };
            await _cropRepository.InsertAsync(
               c,
                autoSave: true
            );
            BlockChainHelper.AddMessageObject(c);


            //item 3
            
            c = new Crop
            {
                FarmerName = "Suresh",
                Village = "Karakala",
                Acreage = "14",
                SurveyNo = "221",
                SoilType = "Black Cotton",
                CropType = "Coconut",
                Stage = "Initial",
                Ph = "5.3",
                Nitrogen = "4",
                Phosphurus = "2",
                Pottasium = "6",
                Magnesium = "12",
                Calcium = "10",
                Salinity = "2",
                Zinc = "3.2",
                Iron = "4.5",
                Manganese = "3",
                Copper = "1",
                Sodium = "14",
                Sulphur = "12",
                SoilTestId = "KA608811",
                Lattitude = "13° 11´ 37.984˝",
                Longitude = "74° 55´ 24.352˝",
                TestDate = new DateTime(2022, 06, 29),
                TestedBy = "Nitte Karakala",
                Location = "Karakala",
                LocationType = "Farm"
            };
            await _cropRepository.InsertAsync(
               c,
                autoSave: true
            );
            BlockChainHelper.AddMessageObject(c);

            c = new Crop
            {
                FarmerName = "Suresh",
                Village = "Karakala",
                Acreage = "14",
                SurveyNo = "221",
                SoilType = "Black Cotton",
                CropType = "Coconut",
                Stage = "Initial",
                Ph = "5.3",
                Nitrogen = "4",
                Phosphurus = "2",
                Pottasium = "6",
                Magnesium = "12",
                Calcium = "10",
                Salinity = "2",
                Zinc = "3.2",
                Iron = "4.5",
                Manganese = "3",
                Copper = "1",
                Sodium = "14",
                Sulphur = "12",
                SoilTestId = "KA608811",
                Lattitude = "13° 11´ 37.984˝",
                Longitude = "74° 55´ 24.352˝",
                TestDate = new DateTime(2022, 07, 02),
                TestedBy = "Nitte Karakala",
                Location = "Karakala",
                LocationType = "FPO"
            };
            await _cropRepository.InsertAsync(
               c,
                autoSave: true
            );
            BlockChainHelper.AddMessageObject(c);

            c = new Crop
            {
                FarmerName = "Suresh",
                Village = "Karakala",
                Acreage = "14",
                SurveyNo = "221",
                SoilType = "Black Cotton",
                CropType = "Coconut",
                Stage = "Initial",
                Ph = "5.3",
                Nitrogen = "4",
                Phosphurus = "2",
                Pottasium = "6",
                Magnesium = "12",
                Calcium = "10",
                Salinity = "2",
                Zinc = "3.2",
                Iron = "4.5",
                Manganese = "3",
                Copper = "1",
                Sodium = "14",
                Sulphur = "12",
                SoilTestId = "KA608811",
                Lattitude = "13° 11´ 37.984˝",
                Longitude = "74° 55´ 24.352˝",
                TestDate = new DateTime(2022, 08, 04),
                TestedBy = "Nitte Karakala",
                Location = "Mangalore",
                LocationType = "Logistics"
            };
            await _cropRepository.InsertAsync(
               c,
                autoSave: true
            );
            BlockChainHelper.AddMessageObject(c);


            //Item 4
          
            c = new Crop
            {
                FarmerName = "Rama Rao",
                Village = "Karakala",
                Acreage = "12",
                SurveyNo = "1/12",
                SoilType = "Red",
                CropType = "Potato",
                Stage = "Initial",
                Ph = "5.3",
                Nitrogen = "4",
                Phosphurus = "2",
                Pottasium = "6",
                Magnesium = "12",
                Calcium = "10",
                Salinity = "2",
                Zinc = "3.2",
                Iron = "4.5",
                Manganese = "3",
                Copper = "1",
                Sodium = "14",
                Sulphur = "12",
                SoilTestId = "KA608911",
                Lattitude = "13° 11´ 37.984˝",
                Longitude = "74° 55´ 24.352˝",
                TestDate = new DateTime(2022, 06, 29),
                TestedBy = "Nitte Karakala",
                Location = "Karakala",
                LocationType = "Farm"
            };
            await _cropRepository.InsertAsync(
               c,
                autoSave: true
            );
            BlockChainHelper.AddMessageObject(c);

            c = new Crop
            {
                FarmerName = "Rama Rao",
                Village = "Karakala",
                Acreage = "12",
                SurveyNo = "1/12",
                SoilType = "Red",
                CropType = "Potato",
                Stage = "Initial",
                Ph = "5.3",
                Nitrogen = "4",
                Phosphurus = "2",
                Pottasium = "6",
                Magnesium = "12",
                Calcium = "10",
                Salinity = "2",
                Zinc = "3.2",
                Iron = "4.5",
                Manganese = "3",
                Copper = "1",
                Sodium = "14",
                Sulphur = "12",
                SoilTestId = "KA608911",
                Lattitude = "13° 11´ 37.984˝",
                Longitude = "74° 55´ 24.352˝",
                TestDate = new DateTime(2022, 8, 03),
                TestedBy = "Nitte Karakala",
                Location = "Karakala",
                LocationType = "FPO"
            };
            await _cropRepository.InsertAsync(
               c,
                autoSave: true
            );
            BlockChainHelper.AddMessageObject(c);

            //Item 5 and 6
            //Item 4

            c = new Crop
            {
                FarmerName = "Janhavi",
                Village = "Karakala",
                Acreage = "2",
                SurveyNo = "16",
                SoilType = "Red",
                CropType = "Potato",
                Stage = "Initial",
                Ph = "5.3",
                Nitrogen = "4",
                Phosphurus = "2",
                Pottasium = "6",
                Magnesium = "12",
                Calcium = "10",
                Salinity = "2",
                Zinc = "3.2",
                Iron = "4.5",
                Manganese = "3",
                Copper = "1",
                Sodium = "14",
                Sulphur = "12",
                SoilTestId = "KA609911",
                Lattitude = "13° 11´ 37.984˝",
                Longitude = "74° 55´ 24.352˝",
                TestDate = new DateTime(2022, 06, 29),
                TestedBy = "Nitte Karakala",
                Location = "Karakala",
                LocationType = "Farm"
            };
            await _cropRepository.InsertAsync(
               c,
                autoSave: true
            );
            BlockChainHelper.AddMessageObject(c);

            c = new Crop
            {
                FarmerName = "Ganesh",
                Village = "Karakala",
                Acreage = "21",
                SurveyNo = "6/2B",
                SoilType = "Red",
                CropType = "Potato",
                Stage = "Initial",
                Ph = "5.3",
                Nitrogen = "4",
                Phosphurus = "2",
                Pottasium = "6",
                Magnesium = "12",
                Calcium = "10",
                Salinity = "2",
                Zinc = "3.2",
                Iron = "4.5",
                Manganese = "3",
                Copper = "1",
                Sodium = "14",
                Sulphur = "12",
                SoilTestId = "KA609911",
                Lattitude = "13° 11´ 37.984˝",
                Longitude = "74° 55´ 24.352˝",
                TestDate = new DateTime(2022, 8, 03),
                TestedBy = "Nitte Karakala",
                Location = "Karakala",
                LocationType = "Farm"
            };
            await _cropRepository.InsertAsync(
               c,
                autoSave: true
            );
            BlockChainHelper.AddMessageObject(c);
        }
    }
}