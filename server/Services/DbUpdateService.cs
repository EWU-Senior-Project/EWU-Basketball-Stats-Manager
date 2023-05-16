using server.Data;
using server.Data.Mappings;
using CsvHelper;
using CsvHelper.Configuration;
using System.Globalization;

namespace server.Services;

public class DbUpdateService
{
    private readonly AppDbContext _context;

    public DbUpdateService(AppDbContext context)
    {
        _context = context;
    }

    public static void SeedTeams (AppDbContext context)
    {
        using (var reader = new StreamReader("../Content/schedule.csv"))
        using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
        {
            csv.Context.RegisterClassMap<TeamClassMap>();
            var verboseRecords = csv.GetRecords<Team>();

            var filteredRecords = verboseRecords.GroupBy(team => team.TeamId)
                                                .Select(group => group.First())
                                                .ToList();
        }
    }
}