using Ef_design_first;
using Ef_design_first.DTOs;
using Ef_design_first.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectWCF
{
    public class ServiceWCF:IServiceWCF
    {
        private readonly IService _service;
        public ServiceWCF()
        {
            _service = new Service();
        }
 

        string IServiceWCF.AddPhoto(PhotoDto photo, string other, IList<PersonDto> persons)
        {
            return _service.AddPhoto(photo, other, persons);
        }

    
        List<Photo> IServiceWCF.GetAll()
        {
            return _service.GetAll();
        }
    }
}
