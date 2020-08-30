﻿using DevCA.Api.Controllers;
using DevCA.Business.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace DevCA.Api.v2.Controllers
{
    [ApiVersion("2.0")]
    [Route("api/v{version:apiVersion}/teste")]
    public class TesteController : MainController
    {
        public TesteController(INotificador notificador, IUser appUser) : base(notificador, appUser)
        {
        }

        [HttpGet]
        public string Valor()
        {
            return "Sou a v2";
        }
    }
}
