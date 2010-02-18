using System.Collections.Generic;
using Learning.Core.Domain;

namespace Learning.Core.Services
{
    public interface IWineService
    {
        IEnumerable<WineUnit> GetWineList();
        void WineListInit();
    }
}