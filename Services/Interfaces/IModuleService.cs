using ProductionProcessCompanion.Models;
using ProductionProcessCompanion.ModelsDTO;

namespace ProductionProcessCompanion.Services.Interfaces
{
    public interface IModuleService
    {
        Module GetModuleByName(string moduleName);
        OperationSuccessDTO<List<Module>> GetModules();
        OperationSuccessDTO<Module> AddModule(Module module);
        OperationSuccessDTO<Module> UpdateModule(Module module);
        OperationSuccessDTO<Module> DeleteModule(string name);
    }
}
