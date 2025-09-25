using EscalationMatrixCountdown.Models;

namespace EscalationMatrixCountdown.Services
{
    public class StaticAircraftConfigService : IAircraftConfigService
    {
        // This is the method you pasted from AircraftConfig.cs
        public AircraftConfig GetConfig(AircraftType t)
        {
            if (t == AircraftType.B737_800)
            {
                return new AircraftConfig
                {
                    Name = "B737-800",
                    StringOffsetsMinutes = new Milestone[]
                    {
                        new Milestone { Label = "Forward Belly", OffsetMinutes = -135 },
                        new Milestone { Label = "Main Deck Position 1", OffsetMinutes = -105 },
                        new Milestone { Label = "AFT Belly's", OffsetMinutes = -90 },
                        new Milestone { Label = "String 1", OffsetMinutes = -70 },
                        new Milestone { Label = "String 2", OffsetMinutes = -55 },
                        new Milestone { Label = "String 3", OffsetMinutes = -45 },
                    },
                    LastCanOffsetMinutes = -32,
                    BellyCloseOffsetMinutes = null 
                };
            }
            // default 767-300
            return new AircraftConfig
            {
                Name = "B767-300",
                StringOffsetsMinutes = new Milestone[]
                {
                    new Milestone {Label = "FWD Lower Deck", OffsetMinutes = -110},
                    new Milestone {Label = "1st String", OffsetMinutes = -85},
                    new Milestone {Label = "2nd String", OffsetMinutes = -75},
                    new Milestone {Label = "Belly Can", OffsetMinutes = -70},
                    new Milestone {Label = "AFT Lower Deck", OffsetMinutes = -69},
                    new Milestone {Label = "3rd String", OffsetMinutes = -60},
                    new Milestone {Label = "4th String", OffsetMinutes = -55},
                    new Milestone {Label = "5th String", OffsetMinutes = -50},
                    new Milestone {Label = "6th String", OffsetMinutes = -45},
                },
                LastCanOffsetMinutes = -32,
                BellyCloseOffsetMinutes = null
            };
        }
    }
}