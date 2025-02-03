using System.ComponentModel.DataAnnotations;

namespace PSGC.Api.Entities
{
    public class GeoData
    {
        public int Id { get; set; }
        [MaxLength(10)]
        public string? PSGCCode { get; set; }
        [MaxLength(150)]
        public string? Name { get; set; }
        [MaxLength(10)]
        public string? GeographicLevel { get; set; }
        [MaxLength(150)]
        public string? OldName { get; set; }
        [MaxLength(2)]
        public string? RegionCode { get; set; }
        [MaxLength(3)]
        public string? ProvinceCode { get; set; }
        [MaxLength(2)]
        public string? MunicipalCode { get; set; }
        [MaxLength(3)]
        public string? BarangayCode { get; set; }
    }
}


