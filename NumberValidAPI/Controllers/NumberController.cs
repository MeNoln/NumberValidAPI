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

                if (answer.valid == false)
                    return Json(new FalseValid { valid = false,
                        message = "Check your number, it may have some errors, and be sure that you wrote it without + at the start. " +
                        "And check supported countries(use api/number/countries path), maybe we don't support your country." });

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