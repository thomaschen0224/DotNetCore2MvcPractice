using System.Collections.Generic;

namespace DotNetCore2MvcPractice.Models
{
    public interface IPieRepository
    {
        
        IEnumerable<Pie> GetAllPies();

        Pie GetPieById(int pieId);
        
        
        
    }
}