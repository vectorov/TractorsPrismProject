
using System.Collections.Generic;
using TractorsPrismUnityApp.Models;

namespace TractorsPrismUnityApp.Services
{
    public interface ITractorsRepository
    {
        List<Tractor> GetTractorsList();
        List<string> GetTitlesList();
    }
}
