using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PsychologyProject.Business.Abstract;

public interface IGenericService<T> where T : class
{
    T TGetById(int id);
    void TAdd(T t);
    void TRemove(T t);
    void TUpdate(T t);
    List<T> TGetList();
}
