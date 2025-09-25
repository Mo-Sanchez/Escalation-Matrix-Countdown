namespace EscalationMatrixCountdown.Models
{
    public class AircraftConfig
    {
        public string Name { get; set; } = "";
        public Milestone[] StringOffsetsMinutes { get; set; } = new Milestone[0]; 
        public int LastCanOffsetMinutes { get; set; }                  
        public int? BellyCloseOffsetMinutes { get; set; }              
    }
    
    public class Milestone
    {
        public string Label { get; set; } = "";
        public int OffsetMinutes { get; set; }
    }
}