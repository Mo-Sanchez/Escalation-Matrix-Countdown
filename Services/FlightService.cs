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
            _flights.Add(new Flight { Id = System.Guid.NewGuid().ToString(), Name = "IAH", TimeOfDay = "23:38", Finger = 3, IsActive = true, Type = AircraftType.B737_800 });
            _flights.Add(new Flight { Id = System.Guid.NewGuid().ToString(), Name = "PIT", TimeOfDay = "23:30", Finger = 1, IsActive = true, Type = AircraftType.B767_300 });
            _flights.Add(new Flight { Id = System.Guid.NewGuid().ToString(), Name = "CVG", TimeOfDay = "07:21", Finger = 1, IsActive = true, Type = AircraftType.B737_800 });
        }

        public IReadOnlyList<Flight> GetAll() { return _flights; }

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

        public void Update(Flight f)
        {
            if (f == null) return;
            if (string.IsNullOrWhiteSpace(f.Id)) return;
            var i = _flights.FindIndex(x => x.Id == f.Id);
            if (i >= 0) _flights[i] = f;
        }
    }
}