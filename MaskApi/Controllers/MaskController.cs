using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MaskApi.models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;



namespace MaskApi.Controllers 
{
    [ApiController]
    [Route("[controller]")]
    public class MaskController : ControllerBase
    {
        
        public List<Mask> MasksInStock = new List<Mask>();

        public MaskController(){

            MasksInStock.Add(new Mask( "m-9999",  1,  "Whyte", true, true, "flower", true, 14.6));
            MasksInStock.Add(new Mask( "m-9998",  5,  "rouge", false, false, "Pig", true, 5.5));
            MasksInStock.Add(new Mask( "m-9997",  6,  "blue", true, true, "car", true, 1.2));
            MasksInStock.Add(new Mask( "m-9996",  2,  "jaune", false, false, "Logo", true, 4.1));
        }


        [HttpGet("GetAll")]

        public List<Mask> Getall(){

            return MasksInStock;

        }

        [HttpGet("{maskId}")]
        public Mask GetMask(string maskId)
        {
            Mask found = null;
            foreach (Mask mask in MasksInStock) {
                if (maskId == mask.MaskId){ 
                    found = mask ;
                    break;
                }
            }
            return found;
        }

        





    }
}