using System.Collections.Generic;
using DotNetCore2MvcPractice.Models;

namespace DotNetCore2MvcPractice.ViewModels.Home
{
    public class HomeViewModel
    {
        
        public List<Pie> Pies { get; set; }
        public string Title { get; set; }
        
        
    }
}