#nullable disable
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SW.DAL;

namespace SW.WebAPI.Controllers
{
    [Route("clones")]
    [ApiController]
    public class CloneController : Controller
    {
        private IUnitOfWork _unitOfWork;

        public CloneController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllClones()
        {
            var clones = _unitOfWork.CloneRepository.Get();
            return Ok(clones);
        }


        [HttpGet("{id}")]
        public async Task<IActionResult> GetClone(int id)
        {
            var clone = _unitOfWork.CloneRepository.Get(clon => clon.Id == id, includeProperties: "Legion").FirstOrDefault();



            return Ok(new CloneDto()
            {
                BaseId = clone.BaseId,
                Equipment = clone.Equipment,
                Legion = new LegionDto
                {
                    GeneralJediId = clone.Legion.GeneralJediId,
                    Name = clone.Legion.Name,
                },
                Qualification = clone.Qualification,
                Number = clone.Number,
                StarshipId = clone.StarshipId,
            });
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteClone(int id)
        {
            _unitOfWork.CloneRepository.Delete(id);
            _unitOfWork.Save();
            return Ok();
        }

        [HttpPost]
        public async Task<IActionResult> InsertClone(CloneDto cloneDto)
        {
            Thread.Sleep(60_000);

            Clone clone = new ()
            {
                BaseId = cloneDto.BaseId,
                LegionId = cloneDto.LegionId,
                StarshipId = cloneDto.StarshipId,
                Equipment = cloneDto.Equipment,
                Number = cloneDto.Number,
                Qualification = cloneDto.Qualification,
                
            };

            _unitOfWork.CloneRepository.Insert(clone);
            _unitOfWork.Save();
            return Ok();
        }
    }
}
