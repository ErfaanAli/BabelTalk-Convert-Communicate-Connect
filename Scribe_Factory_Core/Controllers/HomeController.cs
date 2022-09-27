using System;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Scribe_Factory_Core.Common;
using Scribe_Factory_Core.Models;
using Scribe_Factory_Core.Repositories;
using Scribe_Factory_Core.Repositories.Interfaces;
using Scribe_Factory_Core.ViewModels;

namespace Scribe_Factory_Core.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IConfiguration Configuration;
        AWSHelper aws = null;
        string BucketName = "";
        private IProjectManagementRepository ProjectManagementRepository;
        public HomeController(ILogger<HomeController> logger, IConfiguration configuration,IProjectManagementRepository projectManagementRepository)
        {
            _logger = logger;
            Configuration = configuration;
            var Accesskey = Configuration["AWSPollyAccessKey"];
            var SecretKey = Configuration["AWSPollySecretKey"];
            BucketName = Configuration["S3BucketName"];
            aws = new AWSHelper(Accesskey,SecretKey);
            this.ProjectManagementRepository = projectManagementRepository;
        }

        public IActionResult Dashboard()
        {
            var currentUser = SessionHelper.GetObject<UserLoginViewModel>(HttpContext.Session, "CurrentUser");
            if(currentUser != null) { 
            var ALLusers = ProjectManagementRepository.GetProjects(currentUser);
                return View(ALLusers);
            }
            else
            {
                ViewBag.NoProject = "You don't have any project.";
                return View();
            }
        }

       

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
