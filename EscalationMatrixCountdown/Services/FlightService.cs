using System.Collections.Generic;
using System.Linq;
using EscalationMatrixCountdown.Models;

namespace EscalationMatrixCountdown.Services
{
    public class FlightsService
    {
        private readonly List<Flight> _flights = new List<Flight>();

        public FlightsService()
        {
            // Hard-coded sample flights
            _flights.Add(new Flight
            {
                Id = System.Guid.NewGuid().ToString(),
                Name = "IAH",
                TimeOfDay = "13:38",
                Finger = 3,
                IsActive = true
            });

            _flights.Add(new Flight
            {
                Id = System.Guid.NewGuid().ToString(),
                Name = "PIT",
                TimeOfDay = "14:30",
                Finger = 1,
                IsActive = true
            });

            _flights.Add(new Flight
            {
                Id = System.Guid.NewGuid().ToString(),
                Name = "CVG",
                TimeOfDay = "15:21",
                Finger = 2,
                IsActive = true
            });
        }

        public IReadOnlyList<Flight> GetAll()
        {
            return _flights;
        }

        public void Add(Flight f)
        {
            if (f == null) return;
            if (string.IsNullOrWhiteSpace(f.Id)) return;
            _flights.Add(f);
        }

        public void Remove(string id)
        {
            if (string.IsNullOrWhiteSpace(id)) return;
            var found = _flights.FirstOrDefault(x => x.Id == id);
            if (found != null) _flights.Remove(found);
        }

        // These two methods are no longer needed for TimeOfDay logic,
        // but you can keep placeholders for compatibility if referenced elsewhere
        public Flight GetNext(System.DateTime nowLocal)
        {
            // Let Home.razor handle next flight calculation
            return null;
        }
        
        public Flight GetNextByFinger(System.DateTime nowLocal, int finger)
        {
            // Let Home.razor handle next flight calculation
            return null;
        }
    }
}
