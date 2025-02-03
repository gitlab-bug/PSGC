using Microsoft.EntityFrameworkCore;
using PSGC.Api.Data;
using PSGC.Api.Entities;
using PSGC.Api.Models;

namespace PSGC.Api.Repository
{
    public class Repository(IDbContextFactory<DataContext> factory) : IRepository
    {
        public async Task<IEnumerable<GeoData>> GetAll()
        {
            using (var context = factory.CreateDbContext())
            {
                var query = context.GeoDatas.AsQueryable();
                return await query.ToListAsync();
            }
        }

        public async Task<IEnumerable<GeoDataModel>> GetBarangays(string regionCode, string provinceCode, string municipalCode)
        {
            using (var context = factory.CreateDbContext())
            {
                var query = context.GeoDatas.AsQueryable().Where(d => d.RegionCode == regionCode && d.ProvinceCode == provinceCode);
                return await query.Where(d => d.MunicipalCode == municipalCode && d.GeographicLevel!.Contains("Bgy")).Select(d => new GeoDataModel
                {
                    Id = d.Id,
                    PSGCCode = d.PSGCCode,
                    Name = d.Name,
                    OldName = d.OldName,
                    RegionCode = d.RegionCode,
                    ProvinceCode = d.ProvinceCode,
                    MunicipalCode = d.MunicipalCode,
                    BarangayCode = d.BarangayCode
                }).ToListAsync();
            }
        }

        public async Task<IEnumerable<GeoDataModel>> GetCitiesMunicipalities(string regionCode, string provinceCode)
        {
            using (var context = factory.CreateDbContext())
            {
                var query = context.GeoDatas.AsQueryable().Where(d => d.RegionCode == regionCode && d.ProvinceCode == provinceCode);
                return await query.Where(d => d.GeographicLevel!.Contains("City") || d.GeographicLevel!.Contains("Mun")).Select(d => new GeoDataModel
                {
                    Id = d.Id,
                    PSGCCode = d.PSGCCode,
                    Name = d.Name,
                    OldName = d.OldName,
                    RegionCode = d.RegionCode,
                    ProvinceCode = d.ProvinceCode,
                    MunicipalCode = d.MunicipalCode
                }).ToListAsync();
            }
        }

        public async Task<IEnumerable<LocationDataModel>> GetMyBarangays(string regionCode, string provinceCode, string municipalCode)
        {
            using (var context = factory.CreateDbContext())
            {
                var query = context.psgc.AsQueryable().Where(d => d.RegionCode == regionCode && d.ProvincialCode == provinceCode);
                return await query.Where(d => d.MunicipalCode == municipalCode && d.GeographicLevel!.Contains("Bgy")).Select(d => new LocationDataModel
                {
                    Id = d.Id,
                    PSGCCode = d.PSGCCode,
                    Name = d.Name,
                    CorrespondenceCode = d.CorrespondenceCode,
                    GeographicLevel = d.GeographicLevel,
                    OldNames = d.OldNames,
                    CityClass = d.CityClass,
                    IncomeClassification = d.IncomeClassification,
                    Population = d.Population,
                    Status = d.Status,
                    RegionCode = d.RegionCode,
                    ProvincialCode = d.ProvincialCode,
                    MunicipalCode = d.MunicipalCode,
                    BarangayCode = d.BarangayCode
                }).ToListAsync();
            }
        }

        public async Task<IEnumerable<LocationDataModel>> GetMyCitiesMunicipalities(string regionCode, string provinceCode)
        {
            using (var context = factory.CreateDbContext())
            {
                var query = context.psgc.AsQueryable().Where(d => d.RegionCode == regionCode && d.ProvincialCode == provinceCode);
                return await query.Where(d => d.GeographicLevel!.Contains("City") || d.GeographicLevel!.Contains("Mun")).Select(d => new LocationDataModel
                {
                    Id = d.Id,
                    PSGCCode = d.PSGCCode,
                    Name = d.Name,
                    CorrespondenceCode = d.CorrespondenceCode,
                    GeographicLevel = d.GeographicLevel,
                    OldNames = d.OldNames,
                    CityClass = d.CityClass,
                    IncomeClassification = d.IncomeClassification,
                    Population = d.Population,
                    Status = d.Status,
                    RegionCode = d.RegionCode,
                    ProvincialCode = d.ProvincialCode,
                    MunicipalCode = d.MunicipalCode,
                    BarangayCode = d.BarangayCode
                }).ToListAsync();
            }
        }

        public async Task<IEnumerable<LocationDataModel>> GetMyProvinces(string regionCode)
        {
            using (var context = factory.CreateDbContext())
            {
                var query = context.psgc.AsQueryable().Where(d => d.RegionCode == regionCode && d.GeographicLevel!.Contains("Prov"));
                return await query.Select(d => new LocationDataModel
                {
                    Id = d.Id,
                    PSGCCode = d.PSGCCode,
                    Name = d.Name,
                    CorrespondenceCode = d.CorrespondenceCode,
                    GeographicLevel = d.GeographicLevel,
                    OldNames = d.OldNames,
                    CityClass = d.CityClass,
                    IncomeClassification = d.IncomeClassification,
                    Population = d.Population,
                    Status = d.Status,
                    RegionCode = d.RegionCode,
                    ProvincialCode = d.ProvincialCode,
                    MunicipalCode = d.MunicipalCode,
                    BarangayCode = d.BarangayCode
                }).ToListAsync();
            }
        }

        public async Task<IEnumerable<LocationDataModel>> GetMyRegions()
        {
            using (var context = factory.CreateDbContext())
            {
                var query = context.psgc.AsQueryable().Where(d => d.GeographicLevel!.Contains("Reg"));
                return await query.Select(d => new LocationDataModel
                {
                    Id = d.Id,
                    PSGCCode = d.PSGCCode,
                    Name = d.Name,
                    CorrespondenceCode = d.CorrespondenceCode,
                    GeographicLevel = d.GeographicLevel,
                    OldNames = d.OldNames,
                    CityClass = d.CityClass,
                    IncomeClassification = d.IncomeClassification,
                    Population = d.Population,
                    Status = d.Status,
                    RegionCode = d.RegionCode,
                    ProvincialCode = d.ProvincialCode,
                    MunicipalCode = d.MunicipalCode,
                    BarangayCode = d.BarangayCode
                }).ToListAsync();
            }
        }

        public async Task<IEnumerable<GeoDataModel>> GetProvinces(string regionCode)
        {
            using (var context = factory.CreateDbContext())
            {
                var query = context.GeoDatas.AsQueryable().Where(d => d.RegionCode == regionCode && d.GeographicLevel!.Contains("Prov"));
                return await query.Select(d => new GeoDataModel
                {
                    Id = d.Id,
                    PSGCCode = d.PSGCCode,
                    Name = d.Name,
                    OldName = d.OldName,
                    RegionCode = d.RegionCode,
                    ProvinceCode = d.ProvinceCode,
                    MunicipalCode = d.MunicipalCode
                }).ToListAsync();
            }
        }

        public async Task<IEnumerable<GeoDataModel>> GetRegions()
        {
            using (var context = factory.CreateDbContext())
            {
                var query = context.GeoDatas.AsQueryable().Where(d => d.GeographicLevel!.Contains("Reg"));
                return await query.Select(d => new GeoDataModel
                {
                    Id = d.Id,
                    PSGCCode = d.PSGCCode,
                    Name = d.Name,
                    OldName = d.OldName,
                    RegionCode = d.RegionCode
                }).ToListAsync();
            }
        }
    }
}
