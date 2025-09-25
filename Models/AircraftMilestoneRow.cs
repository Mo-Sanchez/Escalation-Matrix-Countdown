using Postgrest.Attributes;
using Postgrest.Models;
using System;

namespace EscalationMatrixCountdown.Models
{
    [Table("aircraft_milestone")]
    public class AircraftMilestoneRow : BaseModel
    {
        [PrimaryKey("id", false)]
        public Guid Id { get; set; }

        [Column("aircraft")]
        public string Aircraft { get; set; }

        [Column("label")]
        public string Label { get; set; }

        [Column("offset_minutes")]
        public int OffsetMinutes { get; set; }

        [Column("sort_order")]
        public int SortOrder { get; set; }
    }
}