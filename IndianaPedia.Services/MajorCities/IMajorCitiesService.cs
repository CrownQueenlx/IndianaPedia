using IndianaPedia.Data;
using IndianaPedia.Models;

namespace IndianaPedia.Services;

public interface IMajorCitiesService
{
    //Create
    Task<IEnumerable<MajorCitiesIndexVM>> GetAllMajorCitiesAsync(MajorCities model);
    Task<MajorCities> GetMajorCitiesByIdAsync(int model);
}