using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using Ef_design_first;
using Ef_design_first.DTOs;
namespace ObjectWCF
{
    [ServiceContract]
    interface IServiceWCF
    {
        [OperationContract]
        string AddPhoto(PhotoDto photo, string other, IList<PersonDto> persons);
        [OperationContract]
        List<Photo> GetAll();
    }
}
