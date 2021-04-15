﻿using Microsoft.AspNetCore.Mvc;
using MongoBase.Interfaces;
using Sample.Domain.Models;
using Swashbuckle.AspNetCore.Annotations;

namespace Sample.Domain.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ProductColorSizesController : MongoBase.Controllers.Controller<ProductColorSize>
    {
        public ProductColorSizesController(IRepository<ProductColorSize> repository) : base(repository)
        {

        }
    }
}
