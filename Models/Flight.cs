// Models/Flight.cs
using Postgrest.Attributes;
using Postgrest.Models;
using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace EscalationMatrixCountdown.Models
{
    [Table("flights")]
    public class Flight : BaseModel
    {
        [PrimaryKey("id", false)]
        public Guid Id { get; set; }

        [Column("name")]
        public string Name { get; set; }

        [Column("departure_time")]
        public string TimeOfDay { get; set; }

        [Column("finger")]
        public int Finger { get; set; }
        
        
        [Column("aircraft")]
        
        [JsonConverter(typeof(StringEnumConverter))]
        public AircraftType Type { get; set; }

        [Column("is_active")]
        public bool IsActive { get; set; }


    }
}