// Models/AircraftConfigRow.cs
using Postgrest.Attributes;
using Postgrest.Models;

namespace EscalationMatrixCountdown.Models
{
    [Table("aircraft_config")]
    public class AircraftConfigRow : BaseModel
    {
        [PrimaryKey("aircraft", false)]
        public string Aircraft { get; set; }

        [Column("last_can_offset_minutes")]
        public int LastCanOffsetMinutes { get; set; }

        [Column("belly_close_offset_minutes")]
        public int? BellyCloseOffsetMinutes { get; set; }
    }
}

// Models/AircraftMilestoneRow.cs
