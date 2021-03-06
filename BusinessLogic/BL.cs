﻿using AutoMapper;
using BusinessLogic.Entities;
using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class BL : IDisposable
    {
        private UnitOfWork db;
        public BL()
        {
            db = new UnitOfWork();
        }

        public async Task<AnswerBL> GetInfo(string number)
        {
            if (number.Length < 9)
                return new AnswerBL { valid = false};

            string formatednumber = formatOperatorCodeToCountryCode(number);

            var operators = await db.OpCodesRepo.Get(formatednumber);

            if (operators == null)
                return new AnswerBL { valid = false };

            int countryCode = operators.CoutryCode;

            var patternModel = await db.CurrentPattern.Get(countryCode);

            string operatorCode = GiveOperatorCode(patternModel.CountryCode.ToString(), operators.OperCode);
            string otherNumbers = getLastSevenNumbers(operators.OperCode, number);
            AnswerBL answer = new AnswerBL
            {
                valid = true,
                number = number,
                e164format = $"+{number}",
                internationalFormat = $"+{patternModel.CountryCode} {operatorCode}-{otherNumbers}",
                nationalFormat = $"({operatorCode}) {otherNumbers}",
                Country = patternModel.Country,
                CountryCode = patternModel.CountryCode,
                CountryShort = patternModel.CountryShort,
                OperatorName = operators.Operators.OperatorName,
                OperCode = operatorCode
            };

            return answer;
        }

        public async Task<IEnumerable<SupportedCountries>> GetCountries()
        {
            List<SupportedCountries> list = new List<SupportedCountries>();
            
            foreach (var item in await db.CurrentPattern.GetAllCountries())
                list.Add(new SupportedCountries { Country = item.Country});

            return list;
        }

        public void Dispose()
        {
            db.Dispose();
        }

        private string formatOperatorCodeToCountryCode(string number)
        {
            char[] arr = number.ToCharArray();
            string res = string.Empty;
            for (int i = 0; i < number.Length - 7; i++)
                res += arr[i];

            return res;
        }
        private string GiveOperatorCode(string countrycode, string opcode)
        {
            StringBuilder builder = new StringBuilder(opcode);
            if (opcode.Contains(countrycode))
                builder.Remove(0, countrycode.Length);

            return builder.ToString();
        }

        private string getLastSevenNumbers(string opcode, string number)
        {
            StringBuilder builder = new StringBuilder(number);

            builder.Remove(0, opcode.Length);
            builder.Insert(3, "-");

            return builder.ToString();
        }
    }
}
