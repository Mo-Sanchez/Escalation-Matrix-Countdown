using System.Collections.Generic;
using System.Threading.Tasks;
using EscalationMatrixCountdown.Models;
using Supabase;
using System;

namespace EscalationMatrixCountdown.Services
{
    public class FlightsService
    {
        private readonly Client _supabase;

        public FlightsService(Client supabase)
        {
            _supabase = supabase;
        }

        public async Task<IReadOnlyList<Flight>> GetAll()
        {
            var r = await _supabase.From<Flight>()
                .Select("*")
                .Get();
            return r.Models;
        }

        public async Task AddFlightAsync(Flight flight)
        {
            await _supabase.From<Flight>().Insert(flight);
        }

        public async Task UpdateFlightAsync(Flight flight)
        {
            await _supabase.From<Flight>().Update(flight);
        }

        public async Task DeleteFlightAsync(Guid id)
        {
            await _supabase.From<Flight>().Where(f => f.Id == id).Delete();
        }
    }
}