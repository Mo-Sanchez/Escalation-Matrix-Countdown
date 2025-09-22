namespace EscalationMatrixCountdown.Models
{
    public class Flight
    {
        public string Id { get; set; } = "";
        public string Name { get; set; } = "";
        public int Finger { get; set; } = 1;
        public string TimeOfDay { get; set; } = ""; // "HH:mm"
        public bool IsActive { get; set; } = true;
        public AircraftType Type { get; set; } = AircraftType.B767_300;
    }
}