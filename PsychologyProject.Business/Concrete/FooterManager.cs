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
    public class FooterManager : IFooterService
    {
        private readonly IFooterDal _footerDal;

        public FooterManager(IFooterDal footerDal)
        {
            _footerDal = footerDal;
        }

        public void TAdd(Footer t)
        {
            _footerDal.Add(t);
        }

        public Footer TGetById(int id)
        {
            return _footerDal.GetById(id);
        }

        public List<Footer> TGetList()
        {
            return _footerDal.GetAll();
        }

        public void TRemove(Footer t)
        {
            _footerDal.Delete(t);
        }

        public void TUpdate(Footer t)
        {
            _footerDal.Update(t);
        }
    }
}
