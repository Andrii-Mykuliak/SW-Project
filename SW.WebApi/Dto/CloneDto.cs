using System.ComponentModel.DataAnnotations;

namespace SW.WebAPI
{
    public class CloneDto
    {
        public string Number { get; set; }

        [Required]
        public int? BaseId { get; set; }

        public int? LegionId { get; set; }

        public LegionDto Legion { get; set; }

        public int? StarshipId { get; set; }

        public string Equipment { get; set; }

        public string Qualification { get; set; }
    }
}
