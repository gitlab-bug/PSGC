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
                return await query.Where(d => d.MunicipalityCode == municipalCode && d.GeographicLevel!.Contains("Bgy")).Select(d => new GeoDataModel
                {
                    Id = d.Id,
                    PSGCCode = d.PSGCCode,
                    Name = d.Name,
                    OldName = d.OldName,
                    RegionCode = d.RegionCode,
                    ProvinceCode = d.ProvinceCode,
                    MunicipalityCode = d.MunicipalityCode,
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
                    MunicipalityCode = d.MunicipalityCode
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
                    MunicipalityCode = d.MunicipalityCode
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
