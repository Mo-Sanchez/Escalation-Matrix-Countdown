using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;
using EscalationMatrixCountdown.Models;
using Postgrest;               // for Constants and Order
using Supabase;

namespace EscalationMatrixCountdown.Services
{
    public class FlightsService
    {
        private readonly Supabase.Client _supabase;

        public FlightsService(Supabase.Client supabase)
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

        public async Task DeleteFlightAsync(System.Guid id)
        {
            await _supabase.From<Flight>()
                .Filter("id", Postgrest.Constants.Operator.Equals, id.ToString())
                .Delete();
        }

        // Escalation config
        public async Task<AircraftConfigRow> GetAircraftConfigAsync(string aircraft)
        {
            var r = await _supabase.From<AircraftConfigRow>()
                .Filter("aircraft", Postgrest.Constants.Operator.Equals, aircraft)
                .Single();
            return r ?? new AircraftConfigRow { Aircraft = aircraft };
        }


        public async Task<IReadOnlyList<AircraftMilestoneRow>> GetMilestonesAsync(string aircraft)
        {
            var r = await _supabase.From<AircraftMilestoneRow>()
                .Filter("aircraft", Postgrest.Constants.Operator.Equals, aircraft)
                .Order("sort_order", Postgrest.Constants.Ordering.Ascending)
                .Get();
            return r.Models;
        }

        public async Task SaveAircraftConfigAsync(AircraftConfigRow row)
        {
            await _supabase.From<AircraftConfigRow>().Upsert(row);
        }

        public async Task UpsertMilestoneAsync(AircraftMilestoneRow row)
        {
            if (row.Id == System.Guid.Empty) row.Id = System.Guid.NewGuid();
            await _supabase.From<AircraftMilestoneRow>().Upsert(row);
        }

        public async Task DeleteMilestoneAsync(System.Guid id)
        {
            await _supabase.From<AircraftMilestoneRow>()
                .Filter("id", Postgrest.Constants.Operator.Equals, id.ToString())
                .Delete();
        }
    }
}
