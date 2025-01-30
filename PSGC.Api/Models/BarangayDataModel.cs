using System.ComponentModel.DataAnnotations;

namespace PSGC.Api.Models
{

    public class BarangayDataModel
    {
        public int Id { get; set; }
        public string? PSGCCode { get; set; }
        public string? Name { get; set; }
        public string? OldName { get; set; }
        public string? BarangayCode { get; set; }
    }
}
