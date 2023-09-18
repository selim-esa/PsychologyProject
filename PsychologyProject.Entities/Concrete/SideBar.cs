using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PsychologyProject.Entities.Concrete
{
    public class SideBar
    {
        public int SideBarId { get; set; }
        public string Name { get; set; }
        public int SideBarCategoryId { get; set; }      
        public virtual SideBarCategory SideBarCategory { get; set; }

    }
}
