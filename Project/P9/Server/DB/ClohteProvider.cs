using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using P9.Server.Controllers;
using P9.Shared;

namespace P9.Server.DB
{
    public class ClotheProvider
    {
        //*********************Yek object az class ClotheDBContext
        private readonly ClotheDBContext _context;
        private readonly ILogger _logger;
        public ClotheProvider(ClotheDBContext context, ILoggerFactory loggerFactory)
        {
            this._context = context;
            this._logger = loggerFactory.CreateLogger("ClotheProvider");
        }
        public async Task AddClothe(Clothe clothe)
        {
            var LastClothe = this._context.Clothes.ToArray().LastOrDefault();
            var newID = 0;
            if(!(LastClothe is null))
                newID = LastClothe.Id + 1;
            clothe.Id = newID;

            await _context.Clothes.AddAsync(clothe);
            await _context.SaveChangesAsync();
        }
        
        public List<Clothe> GetAllClothes()
            => this._context.Clothes.ToList();
    }
}