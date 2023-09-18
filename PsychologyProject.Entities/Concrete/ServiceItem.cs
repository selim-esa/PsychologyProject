using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PsychologyProject.Entities.Concrete
{
	public class ServiceItem
	{
        public int Id { get; set; }
        public string? ServicesIcon { get; set; }
		public string? ServicesTitle { get; set; }
		public string? ServicesDescription { get; set; }
	}
}
