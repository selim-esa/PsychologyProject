using PsychologyProject.Entities.Concrete;

namespace PsychologyProject.Web.ViewModel
{
    public class ServiceViewModel
    {
        public Service Service { get; set; }
        public List<ServiceItem> serviceItem { get; set; }
    }
}
