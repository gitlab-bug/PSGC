namespace PSGC.Api.Models
{
    public class GeoDataModel
    {
        public int Id { get; set; }
        public string? PSGCCode { get; set; }
        public string? Name { get; set; }
        public string? OldName { get; set; }
        public string? RegionCode { get; set; }
        public string? ProvinceCode { get; set; }
        public string? MunicipalityCode { get; set; }
        public string? BarangayCode { get; set; }
    }
}
