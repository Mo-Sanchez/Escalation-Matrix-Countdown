using System;

namespace EscalationMatrixCountdown.Models
{
    public class AircraftConfig
    {
        public string Name { get; set; } = "";
        public int[] StringOffsetsMinutes { get; set; } = Array.Empty<int>();
        public int LastCanOffsetMinutes { get; set; }
    }
}