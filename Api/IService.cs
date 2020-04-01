using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ef_design_first.DTOs;
namespace Ef_design_first.Service
{
    public interface IService
    {
        string AddPhoto(PhotoDto photo,string other,IList<PersonDto>persons);
        List<Photo> GetAll();
    }
}
