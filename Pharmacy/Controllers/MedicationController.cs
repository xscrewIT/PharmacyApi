using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Pharmacy.Database;

namespace Pharmacy.Controllers;

[ApiController]
[Route("[controller]")]
public class MedicationController : ControllerBase
{
    [HttpGet]
    public IActionResult GetMedications()
    {
        return Ok(MedicationData.Medications);
    }

    [HttpGet("{id}")]
    public IActionResult GetMedicationById(int id)
    {
        return Ok(MedicationData.Medications.FirstOrDefault(m => m.Id == id));
    }
}
