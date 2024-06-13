using ProductionProcessCompanion.Models;
using ProductionProcessCompanion.ModelsDTO;

namespace ProductionProcessCompanion.Services.Interfaces
{
    public interface ISearchHistoryService
    {
        ResultCostDTO GetSearchHistory (string cityName, ModuleListDTO moduleListDTO);
        OperationSuccessDTO<IList<SearchHistory>> GetSearchHistories();
        OperationResultDTO AddSearchHistory (SearchHistory searchHistory);
    }
}
