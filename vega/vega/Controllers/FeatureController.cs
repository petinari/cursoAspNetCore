using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using vega.Models;
using vega.Persistence;

namespace vega.Controllers
{
    public class FeatureController : Controller
    {
        private readonly VegaDbContext _context;
        private IMapper _mapper;

        public FeatureController(VegaDbContext context, IMapper mapper)
        {
            this._context = context;
            this._mapper = mapper;
        }
        [HttpGet("/api/features")]
        public IEnumerable<Feature> GetMakes()
        {
            var feature = _context.Features.ToList();
           
            return feature;



            // var makes = _context.Makes.Include(m => m.Models).ToList();

            // return _mapper.Map<List<Make>, List<MakeResource>>(makes);
        }
    }
}