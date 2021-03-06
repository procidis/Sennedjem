﻿using Business.Adapters.PersonService;
using Nest;
using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace SennedjemTests.Bussiness.Adapters
{
    public class PersonServiceHelper
    {
        IPersonService _personService;

        public PersonServiceHelper(IPersonService personService)
        {
            this._personService = personService;
        }

        public bool VerifyId(long TCKimlikNo, string Ad, string Soyad, int DogumYili)
        {
            try
            {
                return _personService.VerifyCid(TCKimlikNo, Ad, Soyad, DogumYili).Result;
            }
            catch (WebException)
            {
                return false;
            }
        }
    }
}
