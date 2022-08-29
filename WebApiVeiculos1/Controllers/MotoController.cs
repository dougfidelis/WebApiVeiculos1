using Data.Model;
using Data.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace WebApiVeiculos1.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MotoController : ControllerBase
    {

        MotoRepository motoRepo;

        public MotoController()
        {
            this.motoRepo = new MotoRepository();
        }

        [HttpGet]
        public List<Moto> GetAll ()
        {
            return motoRepo.GetAll();
        }

        [HttpPost]
        public string Post(Moto model)
        {
           return motoRepo.Create(model);
           
        }

        [HttpGet("{id}")]
        public Moto GetById(int id)
        {
            Moto moto = motoRepo.GetById(id);
            return moto;
            
        }

        [HttpPut]
        public string Update(Moto model)
        {
            return motoRepo.Update(model);
        }

        [HttpDelete]
        public string Delete(int id)
        {
            return motoRepo.Delete(id);
        }


    }
}
