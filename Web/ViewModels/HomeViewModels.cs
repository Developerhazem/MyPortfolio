using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web.ViewModels
{
    public class HomeViewModels
    {
        public Owner Owner { get; set; }
        public List<PortfolioItem> portfolioItems { get; set; }
    }
}
