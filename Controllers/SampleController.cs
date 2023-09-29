using df_samples.Services;
using df_samples.Models;
using Microsoft.AspNetCore.Mvc;

namespace df_samples.Controllers;

[ApiController]
[Route("[controller]")]
public class SampleController : ControllerBase
{
    SampleService _service;
    
    public SampleController(SampleService service)
    {
        _service = service;
    }

    [HttpGet]
    public IEnumerable<Sample> GetAll()
    {
        return _service.GetAll();
    }

    [HttpGet("{id}")]
    public ActionResult<Sample> GetById(int id)
    {
        var sample = _service.GetById(id);

        if(sample is not null)
        {
            return sample;
        }
        else
        {
            return NotFound();
        }
    }


    [HttpPost]
    public IActionResult Create(Sample newSample)
    {
        var sample = _service.Create(newSample);
        return CreatedAtAction(nameof(GetById), new { id = sample!.Id }, sample);
    }

    [HttpPut("{id}/addtopping")]
    public IActionResult AddTopping(int id, int toppingId)
    {
        var sampleToUpdate = _service.GetById(id);

        if(sampleToUpdate is not null)
        {
            _service.AddTopping(id, toppingId);
            return NoContent();    
        }
        else
        {
            return NotFound();
        }
    }

    [HttpPut("{id}/updatesauce")]
    public IActionResult UpdateSauce(int id, int sauceId)
    {
        var sampleToUpdate = _service.GetById(id);

        if(sampleToUpdate is not null)
        {
            _service.UpdateSauce(id, sauceId);
            return NoContent();    
        }
        else
        {
            return NotFound();
        }
    }

    [HttpDelete("{id}")]
    public IActionResult Delete(int id)
    {
        var sample = _service.GetById(id);

        if(sample is not null)
        {
            _service.DeleteById(id);
            return Ok();
        }
        else
        {
            return NotFound();
        }
    }
}