using Data.Model;
using Data.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApiVeiculos1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarroController : ControllerBase
    {


        CarroRepository carroRepository;

        public CarroController()
        {
            this.carroRepository = new CarroRepository();
        }

        [HttpGet]
        public List<Carro> GetAll()
        {
            return this.carroRepository.GetAll();
        }

        [HttpPost]
        public string Post(Carro model)
        {
            return carroRepository.Create(model);
        }

        [HttpGet("{id}")]
        public Carro GetById(int id)
        {
            return  carroRepository.GetById(id);
        }

        [HttpPut]
        public string Update(Carro model)
        {
            return carroRepository.Update(model);
        }

        [HttpDelete]
        public string Delete(int id)
        {
            return carroRepository.Delete(id);
        }

    }
}
