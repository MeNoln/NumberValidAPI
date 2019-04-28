using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using BusinessLogic;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NumberValidAPI.Models;

namespace NumberValidAPI.Controllers
{
    [Route("api/number")]
    [ApiController]
    public class NumberController : Controller
    {
        [Route("validate")]
        public JsonResult GetNumInfo([FromQuery] string number)
        {
            if (string.IsNullOrEmpty(number))
                return Json("def");
            using (var db = new BL())
            {
                AnswerModel answer = Mapper.Map<AnswerModel>(db.GetInfo(number));
                return Json(answer);
            }
        }

        [Route("countries")]
        public JsonResult Get()
        {
            List<string> list = new List<string>();

            using (var db = new BL())
            {
                foreach (var item in db.GetCountries())
                    list.Add(item.Country.ToString());
            }

            return Json(new SupportedCountriesView { Countries = list});
        }
    }
}