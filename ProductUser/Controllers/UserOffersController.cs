﻿using Microsoft.AspNetCore.Mvc;
using ProductUser.Models;
using ProductUser.Services;

namespace ProductUser.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserOffersController : ControllerBase
    {
        private readonly IUserService userService;

        public UserOffersController(IUserService _userService)
        {
            userService = _userService;
        }

        [HttpGet("offerlist")]
        public Task<IEnumerable<ProductOfferDetail>> ProductListAsync()
        {
            var productList = userService.GetProductListAsync();
            return productList;

        }

        [HttpGet("getofferbyid")]
        public Task<ProductOfferDetail> GetProductByIdAsync(int Id)
        {
            return userService.GetProductByIdAsync(Id);
        }
    }
}
