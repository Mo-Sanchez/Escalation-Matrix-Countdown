namespace EscalationMatrixCountdown.Models
{
    public class Flight
    {
        public string Id { get; set; } = "";
        public string Name { get; set; } = "";
        public int Finger { get; set; } = 1;     // 1..3
        public string TimeOfDay { get; set; } = ""; // "HH:mm" local
        public bool IsActive { get; set; } = true;
    }
}