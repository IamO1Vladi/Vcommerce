﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json.Serialization;
using System.Text.Json;
using Newtonsoft.Json;
using Vcommerce.Data;
using Vcommerce.Data.Models.Enums;
using Vcommerce.Services.ProductServices.Interfaces;
using Vcommerce.Web.ViewModels.Clothes;
using Newtonsoft.Json.Serialization;
using Vcommerce.Services.ServiceModels.Filtering;

namespace Vcommerce.WebApi.Controllers
{
    [Route("api/clothes")]
    [ApiController]
    public class ClothingApiController : ControllerBase
    {
        private readonly IClothingService clothingService;
        

        public ClothingApiController(IClothingService service)
        {
            this.clothingService = service;
           
        }

        [HttpPost("filerByBrand")]
        [Produces("application/json")]
        [ProducesResponseType(200,Type = typeof(ShopListClothingViewModel))]
        [ProducesResponseType(400)]
        public async Task <IActionResult> GetClothesByBrand([FromBody] Guid[] brandId, [FromQuery] Gender gender, Category category)
        {
            
            try
            {

                var clothing = await clothingService.GetClothesForShoppingList(gender, category);

                foreach (var id in brandId)
                {
                    clothing = clothing.Where(c => c.Brand.Id == id)
                        .ToArray();
                }

                var jsonSettings = new JsonSerializerSettings
                {
                    ReferenceLoopHandling = ReferenceLoopHandling.Serialize,
                    PreserveReferencesHandling = PreserveReferencesHandling.Objects,
                    ContractResolver = new DefaultContractResolver { NamingStrategy = new CamelCaseNamingStrategy() }
                };

                var jsonContent = JsonConvert.SerializeObject(clothing, jsonSettings);

                return Content(jsonContent, "application/json");

            }
            catch (Exception ex)
            {
                return this.BadRequest(ex);
            }

        }

    }
}
