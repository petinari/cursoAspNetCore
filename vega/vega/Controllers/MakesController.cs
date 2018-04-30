using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using vega.Controllers.Resources;
using vega.Models;
using vega.Persistence;

namespace vega.Controllers
{
    public class MakesController : Controller
    {
        private readonly VegaDbContext _context;
        private readonly IMapper _mapper;


        public MakesController(VegaDbContext context, IMapper mapper)
        {
            this._context = context;
            this._mapper = mapper;
        }

        [HttpGet("/api/makes")]
        public IEnumerable<MakeResource> GetMakes()
        {
           var makes = _context.Makes.Include(m => m.Models).ToList();

           return _mapper.Map<List<Make>, List<MakeResource>>(makes);
        }
    }
}
