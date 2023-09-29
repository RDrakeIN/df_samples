using df_samples.Models;
using df_samples.Data;
using Microsoft.EntityFrameworkCore;

namespace df_samples.Services;

public class SampleService
{
    private readonly SampleContext _context;

    public SampleService(SampleContext context)
    {
        _context = context;
    }

public IEnumerable<Sample> GetAll()
{
    return _context.Samples
        .AsNoTracking()
        .ToList();
}
public Sample? GetById(int id)
{
   //return _context.Samples
   //     .Include(p => p.Toppings)
   //     .Include(p => p.Sauce)
   //     .AsNoTracking()
   //     .SingleOrDefault(p => p.Id == id);
}

    public Sample? Create(Sample newSample)
    {
        throw new NotImplementedException();
    }

    //public void AddTopping(int SampleId, int ToppingId)
   // {
    //    throw new NotImplementedException();
   // }

    //public void UpdateSauce(int SampleId, int SauceId)
    //{
    //    throw new NotImplementedException();
    //}

    public void DeleteById(int id)
    {
        throw new NotImplementedException();
    }
}