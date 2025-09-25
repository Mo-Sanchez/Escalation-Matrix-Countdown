using EscalationMatrixCountdown.Models;

namespace EscalationMatrixCountdown.Services
{
    public interface IAircraftConfigService
    {
        AircraftConfig GetConfig(AircraftType type);
    }
}