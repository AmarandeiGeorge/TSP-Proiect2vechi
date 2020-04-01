using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Text;
using System.Threading.Tasks;
using Ef_design_first;
using Ef_design_first.DTOs;
namespace Ef_design_first.Repository
{
    
   public class photoRepository:IRepository
    {
        private readonly Model2Container Context;
        public photoRepository(Model2Container context)
        {
            Context = context;
        }
        public void addNewPhoto(PhotoDto photo,string others,IList<PersonDto> persons)
        {
            Location newLoc;
            Location loc =  Context.Locations.Where(locatie => locatie.Name == photo.location).FirstOrDefault();
            if (loc == null)
            {
                Location newLocation = new Location()
                {
                    Name = photo.location
                   

                };
                newLoc = Context.Locations.Add(newLocation);
            }
            else newLoc = loc;

            Photo newPhoto = new Photo()
            {   Path=photo.path,
                Titlu = photo.title,
                Descriere = photo.description,
                Eveniment = photo.eveniment,
                Data = photo.date,
                Other = others,
                LocationId = newLoc.Id,
                

            };

            foreach (PersonDto person in persons)
            {
                Person ppl = Context.People.Where(pers => pers.Nume==person.name).Where(pers=> pers.Prenume==person.surname)
                    .FirstOrDefault();
                if (ppl == null)
                {
                    Person newPerson = new Person()
                    {
                        Nume = person.name,
                        Prenume = person.surname
                    };
                    ppl = Context.People.Add(newPerson);

                }
                newPhoto.People.Add(ppl);
            }
            Context.Photos.Add(newPhoto);
            Context.SaveChanges();
        }
        public List<Photo> GetAll()
        {
            return Context.Photos.Include(photo => photo.People)
                          .Include(photo => photo.Location).ToList();
        }

    }
}
