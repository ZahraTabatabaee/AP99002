using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using P9.Server.DB;
using P9.Shared;

namespace P9.Server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ClotheController : Controller
    {
        public static List<Clothe> Clothes = new List<Clothe>
        {
            new Clothe {Id = 1 , Name = "T-shirt", Price = 1_000_000, Color = "Black"},
            new Clothe {Id = 2 , Name = "Pants", Price = 1_000, Color = "Red"},
            new Clothe {Id = 3 , Name = "Hat", Price = 50_000, Color = "Green"}
        };
        //[HttpGet("getAllClothes")] // api/Clothe/getAllClothes
        [HttpGet]
        [Route("getAllClothes")] // api/Clothe/getAllClothes
        public List<Clothe> getAllClothes() => ClotheController.Clothes;

        [HttpGet("{id}")]
        [Route("getClotheById")]
        [HttpGet("getClotheById/{id}")]
        public Clothe getClotheById(int id) => ClotheController.Clothes.Where(clothe => clothe.Id == id).FirstOrDefault();//-->agar vojod nadasht null mideh.
        // System.Linq.Enumerable.Where(ClotheController.Clothes,Clothe => Clothe.ID == id).FirstOrDefault();
        //getAllClothes().Where(clothe => clothe.ID == id).FirstOrDefault();
        
        
        [HttpPost]
        [Route("AddNewClothe")]
        public Clothe AddNewClothe(Clothe clothe)
        {
            var newId = ClotheController.Clothes.Last().Id + 1;
            var newClothe = new Clothe{ Id = newId, Color = clothe.Color , Name = clothe.Name,Price = clothe.Price};
            ClotheController.Clothes.Add(newClothe);
            return newClothe;
        }
        [HttpDelete]
        [Route("RemoveClothes")]//-->[]
        public List<Clothe> RemoveClothes(int[] ids)
        {
            Clothes = Clothes.Where(arg => ids.Contains(arg.Id)).ToList();
            return Clothes;
        }

        [HttpPut]
        [Route("UpdateClotheName")]//-->Params
        // [HttpPut("UpdateClotheName/{id}/{name}")]
        public Clothe UpdateClotheName(int id,string newname)
        {
            var clothe = Clothes.Where(arg => arg.Id == id).FirstOrDefault();
            clothe.Name = newname;
            return clothe;
        }

        [HttpPut]
        [Route("UpdateClothe")]
        public Clothe UpdateClothe(Clothe newClothe)
        {
            var idx = Clothes.IndexOf(newClothe) + 1;
            Clothes[idx] = newClothe;
            return Clothes[idx];
        }

        private readonly ClotheProvider _provider;
        public ClotheController(ClotheProvider provider)
        {
            this._provider = provider;
        }
        [HttpPost]
        [Route("AddNewClotheToDB")]
        public async Task<Clothe> AddNewClotheToDB(Clothe newClothe)
        {
            await this._provider.AddClothe(newClothe);
            return newClothe;
        }
        [HttpGet]
        [Route("GetAllClothesFromDB")]
        public List<Clothe> GetAllClothesFromDB()
            => this._provider.GetAllClothes();
        
    }
}