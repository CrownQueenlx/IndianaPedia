using System.Data.Common;
using IndianaPedia.Data;
using IndianaPedia.Models;
using IndianaPedia.Services;

namespace IndianaPedia.Services;

public class MajorCitiesService : IMajorCitiesService
{
    private readonly MajorCitiesEntity _cityId;
    private readonly AppDbContext _dbContext;
    public MajorCitiesService(AppDbContext dbContext, MajorCitiesEntity Id)
    {
        _dbContext = dbContext;
        _cityId = Id;
    }
    public async Task<IEnumerable<MajorCitiesIndexVM>> GetAllMajorCitiesAsync(MajorCities model)
    {
        var allCity = await _dbContext.MajorCities
        .Where(city => city.Id == _cityId)
        .Select(city => new MajorCities
        {
            Id = city.Id
        })
        .ToListAsync();
        return allCity;
    }

    public Task<MajorCities> GetMajorCitiesByIdAsync(int model)
    {
        throw new NotImplementedException();
    }
}