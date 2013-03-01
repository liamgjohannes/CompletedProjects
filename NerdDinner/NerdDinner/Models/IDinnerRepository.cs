using System;
namespace NerdDinner.Models
{
    public interface IDinnerRepository
    {
        
        System.Linq.IQueryable<Dinner> FindAllDinners();
        System.Linq.IQueryable<Dinner> FindByLocation(float latitude, float longitude);
        System.Linq.IQueryable<Dinner> FindUpcomingDinners();

        Dinner GetDinner(int id);

        void Add(Dinner dinner);
        void Delete(Dinner dinner);

        void Save();
    }
}
