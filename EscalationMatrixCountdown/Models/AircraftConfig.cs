namespace EscalationMatrixCountdown.Models
{
    public class AircraftConfig
    {
        public string Name { get; set; } = "";
        public int[] StringOffsetsMinutes { get; set; } = new int[0]; // e.g., {-100,-90,...}
        public int LastCanOffsetMinutes { get; set; }                  // LCO for main deck
        public int? BellyCloseOffsetMinutes { get; set; }              // optional: e.g., -150 for 737

        public static AircraftConfig Get(AircraftType t)
        {
            if (t == AircraftType.B737_800)
            {
                return new AircraftConfig
                {
                    Name = "B737-800",
                    StringOffsetsMinutes = new[] { -80, -70, -60 },
                    LastCanOffsetMinutes = -32,
                    BellyCloseOffsetMinutes = -150  // “All belly cans closed 2:30 before dep”
                };
            }
            // default 767-300
            return new AircraftConfig
            {
                Name = "B767-300",
                StringOffsetsMinutes = new[] { -100, -90, -80, -70, -60, -50 },
                LastCanOffsetMinutes = -32,
                BellyCloseOffsetMinutes = null
            };
        }
    }
}