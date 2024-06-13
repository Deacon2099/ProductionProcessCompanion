using ProductionProcessCompanion.ModelsDTO;

namespace ProductionProcessCompanion.Services.Interfaces
{
    public interface ICalculatorCostService
    {
        OperationResultDTO CalculateCost(string cityName, ModuleListDTO moduleListDTO);
    }
}
