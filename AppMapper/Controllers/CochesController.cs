using AppMapper.Models;
using AppMapper.Repositories;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace AppMapper.Controllers
{
    public class CochesController : Controller
    {
        private Repository repo;
        private IMapper mapper;

        public CochesController(Repository repo, IMapper mapper)
        {
            this.repo = repo;
            this.mapper = mapper;
        }

        public IActionResult Coches()
        {
            List<Coche> coches = this.repo.GetCoches();
            return View(coches);
        }

        public IActionResult Vehiculos() 
        { 
            List<Vehiculo> vehiculos=this.repo.GetVehiculos();
            return View(vehiculos);
        }

        public IActionResult AgregarVehiculos()
        {
            List<Coche> coches = this.repo.GetCoches();
            List<Vehiculo> nuevosVehiculos=this.mapper.Map<List<Vehiculo>>(coches);
            this.repo.AgregarVehiculos("Coche",nuevosVehiculos);
            return RedirectToAction("Vehiculos");
        }
    }
}
