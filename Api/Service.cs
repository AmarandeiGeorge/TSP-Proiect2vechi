using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ef_design_first.DTOs;
using Ef_design_first.Repository;
namespace Ef_design_first.Service
{
   public class Service:IService
    {
        private readonly IRepository _repository;
        public Service()
        {
            Model2Container context = new Model2Container();
            _repository = new photoRepository(context);
        }
       public string AddPhoto(PhotoDto photo, string other, IList<PersonDto> persons)
        {
            _repository.addNewPhoto(photo, other, persons);
            return "saved";
        }
        public List<Photo> GetAll()
        {
            List<Photo> photos = _repository.GetAll();
            return photos;
        }
    }
}
