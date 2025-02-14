using SignalR.BusinessLayer.Abstract;
using SignalR.DataAccessLayer.Abstract;
using SignalR.EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalR.BusinessLayer.Concrete
{
    public class AboutManager : IAboutService
    {
        private readonly IAboutDal _aboutDal;

        public AboutManager(IAboutDal aboutDal)
        {
            _aboutDal = aboutDal;
        }

        public void TAdd(About entity)
        {
            _aboutDal.add(entity);
        }

        public void TDelete(About entity)
        {
            _aboutDal.delete(entity);
        }

        public About TGetByID(int id)
        {
          return  _aboutDal.GetByID(id);
        }

        public List<About> TGetListAll()
        {
           return _aboutDal.GetListAll();
        }

        public void TUpdate(About entity)
        {
            _aboutDal.update(entity);
        }
    }
}
