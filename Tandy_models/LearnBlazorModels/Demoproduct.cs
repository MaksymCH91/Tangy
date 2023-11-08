using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tandy_models.LearnBlazorModels
{
    public class Demoproduct
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public bool IsActiv { get; set; }
        public List<Demo_productprops> ProductProperies { get; set; }
    }
}
