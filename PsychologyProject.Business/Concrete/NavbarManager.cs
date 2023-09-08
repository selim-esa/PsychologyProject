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
    public class NavbarManager : INavbarService
    {
        private readonly INavbarDal _navbarDal;

        public NavbarManager(INavbarDal navbarDal)
        {
            _navbarDal = navbarDal;
        }

        public void TAdd(Navbar t)
        {
            _navbarDal.Add(t);
        }

        public Navbar TGetById(int id)
        {
            return _navbarDal.GetById(id);
        }

        public List<Navbar> TGetList()
        {
            return _navbarDal.GetAll();
        }

        public void TRemove(Navbar t)
        {
            _navbarDal.Delete(t);
        }

        public void TUpdate(Navbar t)
        {
            _navbarDal.Update(t);
        }
    }
}
