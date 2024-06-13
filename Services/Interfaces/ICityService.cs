using ProductionProcessCompanion.Models;
using ProductionProcessCompanion.ModelsDTO;

namespace ProductionProcessCompanion.Services.Interfaces
{
    public interface ICityService
    {
        City GetCityName(string cityName);
        OperationSuccessDTO<IList<City>> GetCities();
        OperationResultDTO UpdateCostOfWorkingHour(string cityName, double workingHourCost);
        OperationResultDTO UpdateTransportCost(string cityName, double transportCost);
        OperationResultDTO AddCity(City city);
        OperationResultDTO DeleteCity(string cityName);
    }
}
