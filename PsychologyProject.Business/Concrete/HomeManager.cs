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
    public class HomeManager : IHomeService
    {
        private readonly IHomeDal _homeDal;

        public HomeManager(IHomeDal homeDal)
        {
            _homeDal = homeDal;
        }

        public void TAdd(Home t)
        {
           _homeDal.Add(t);
        }

        public Home TGetById(int id)
        {
            return _homeDal.GetById(id);
        }

        public List<Home> TGetList()
        {
            return _homeDal.GetAll();
        }

        public void TRemove(Home t)
        {
            _homeDal.Delete(t);
        }

        public void TUpdate(Home t)
        {
            _homeDal.Update(t);
        }
    }
}
