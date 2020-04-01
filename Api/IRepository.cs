using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ef_design_first.DTOs;
namespace Ef_design_first.Repository
{
    public interface IRepository
    {
        void addNewPhoto(PhotoDto photo, string others, IList<PersonDto> persons);
        List<Photo> GetAll();
    }
}
