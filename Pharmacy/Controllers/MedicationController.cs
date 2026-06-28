using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Pharmacy.Database;

namespace Pharmacy.Controllers;

[ApiController]
[Route("[controller]")]
public class MedicationController : ControllerBase
{
    private readonly PharmacyDbContext _dbContext;

    public MedicationController(PharmacyDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    [HttpGet]
    public IActionResult GetMedications()
    {
        return Ok(_dbContext.Medication.ToList());
    }

    [HttpGet("{id}")]
    public IActionResult GetMedicationById(int id)
    {
        return Ok(_dbContext.Medication.FirstOrDefault(m => m.Id == id));
    }
}
