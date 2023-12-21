using BusinessLayer.Abstract.AbstractUow;
using EntityLayer.Concrate;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SkiaSharp;
using System.Collections.Generic;
using TraversalProje.Areas.Admin.Models;

namespace TraversalProje.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class AccountController : Controller
    {
        private readonly IAccountService _accountService;

        public AccountController(IAccountService accountService)
        {
            _accountService = accountService;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(AccountViewModel model)
        {
            var valueSender= _accountService.TGetById(model.SenderID);
            var valueReciever = _accountService.TGetById(model.RecieverID);

            valueSender.Balance -=  model.Amount;
            valueReciever.Balance += model.Amount;

            List<Account> modifiedAccounts = new List<Account>()
            {
                valueReciever,
                valueSender
            };
            _accountService.TMultiUpdate(modifiedAccounts);
            return View();
        }
    }
}
