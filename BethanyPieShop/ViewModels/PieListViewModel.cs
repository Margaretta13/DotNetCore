using System.Collections.Generic;
using BethanyPieShop.Models;

namespace BethanyPieShop.ViewModels
{
    public class PieListViewModel
    {
        public IEnumerable<Pie> Pies { get; set; }
        public string CurrentCategory { get; set; }
    }
}
