﻿using Microsoft.AspNetCore.Mvc;
using MongoBase.Interfaces;
using Sample.Domain.Models;
using Swashbuckle.AspNetCore.Annotations;

namespace Sample.Domain.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : MongoBase.Controllers.ReadController<Product>
    {
        public ProductController(IRepository<Product> repository) : base(repository)
        {

        }
    }
}
