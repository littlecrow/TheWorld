using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TheWorld.ViewModels;
using TheWorld.Services;
using Microsoft.Extensions.Configuration;
using TheWorld.Models;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace TheWorld.Controllers.Web
{
    public class AppController : Controller
    {
        private IMailService _mailService;
        private IConfigurationRoot _config;
        private IWorldRepository _repository;

        //private WorldContext _context;

        public AppController(IMailService mailService, IConfigurationRoot config, IWorldRepository repository)
        {
            _mailService = mailService;
            _config = config;
            //_context = context;
            _repository = repository;
        }
        // GET: /<controller>/
        public IActionResult Index()
        {
            //var data = _context.Trips.ToList();
            var data = _repository.GetAllTrips();

            return View(data);
        }

        public IActionResult About()
        {
            return View();
        }

        public IActionResult Contact()
        {
            
            return View();
        }

        [HttpPost]
        public IActionResult Contact(ContactViewModel model)
        {
            if (model.Email.Contains("aol.com"))
            {
                ModelState.AddModelError("Email", "We don't support AOL Address");
            }
            if (ModelState.IsValid)
            {
                _mailService.SendMail(_config["MailSettings:ToAddress"], model.Email, "The World", model.Message);

                ViewBag.UserMessage = "Message Sent";
            }
            return View();
        }
    }
}
