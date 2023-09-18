using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PsychologyProject.Entities.Concrete
{
    public class SideBarCategory
    {
        public int SideBarCategoryId { get; set; }
        public string Title { get; set; }
        public virtual ICollection<SideBar> SideBars { get; set; }
    }
}
