namespace PSGC.Api.Models
{
    public class LocationDataModel
    {

        public int Id { get; set; }
        public string PSGCCode { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public string? CorrespondenceCode { get; set; }
        public string GeographicLevel { get; set; } = string.Empty;
        public string? OldNames { get; set; }
        public string? CityClass { get; set; }
        public string? IncomeClassification { get; set; }
        public string? Population { get; set; }
        public string? Status { get; set; }
        public string RegionCode { get; set; } = string.Empty;
        public string ProvincialCode { get; set; } = string.Empty;
        public string MunicipalCode { get; set; } = string.Empty;
        public string BarangayCode { get; set; } = string.Empty;

    }
}
