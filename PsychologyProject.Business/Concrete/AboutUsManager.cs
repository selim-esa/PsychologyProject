using PsychologyProject.Business.Abstract;
using PsychologyProject.DataAccess.Abstract;
using PsychologyProject.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PsychologyProject.Business.Concrete
{
    public class AboutUsManager : IAboutUsService
    {
        private readonly IAboutUsDal _aboutUsDal;

        public AboutUsManager(IAboutUsDal aboutUsDal)
        {
            _aboutUsDal = aboutUsDal;
        }


        public void TAdd(AboutUs t)
        {
            _aboutUsDal.Add(t);
        }

        public AboutUs TGetById(int id)
        {
            return _aboutUsDal.GetById(id);
        }

        public List<AboutUs> TGetList()
        {
            return _aboutUsDal.GetAll();
        }

        public void TRemove(AboutUs t)
        {
            _aboutUsDal.Delete(t);
        }

        public void TUpdate(AboutUs t)
        {
            _aboutUsDal.Update(t);
        }
    }
}
