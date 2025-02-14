﻿using PSGC.Api.Entities;
using PSGC.Api.Models;

namespace PSGC.Api.Repository
{
    public interface IRepository
    {
        Task<IEnumerable<GeoData>> GetAll();
        Task<IEnumerable<GeoDataModel>> GetRegions();

        Task<IEnumerable<LocationDataModel>> GetMyRegions();
        Task<IEnumerable<GeoDataModel>> GetProvinces(string regionCode);
        Task<IEnumerable<LocationDataModel>> GetMyProvinces(string regionCode);
        Task<IEnumerable<GeoDataModel>> GetCitiesMunicipalities(string regionCode, string provinceCode);
        Task<IEnumerable<GeoDataModel>> GetBarangays(string regionCode, string provinceCode, string municipalCode);
        Task<IEnumerable<LocationDataModel>> GetMyCitiesMunicipalities(string regionCode, string provinceCode);
        Task<IEnumerable<LocationDataModel>> GetMyBarangays(string regionCode, string provinceCode, string municipalCode);
    }
}
