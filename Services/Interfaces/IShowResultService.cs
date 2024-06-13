using ProductionProcessCompanion.ModelsDTO;

namespace ProductionProcessCompanion.Services.Interfaces
{
    public interface IShowResultService
    {
        ResultCostDTO PresentResult(string cityName, ModuleListDTO moduleListDTO);
    }
}
