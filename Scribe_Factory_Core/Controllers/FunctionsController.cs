using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Scribe_Factory_Core.Common;
using Scribe_Factory_Core.CustomFilters;
using Scribe_Factory_Core.Repositories;
using Scribe_Factory_Core.Repositories.Interfaces;
using Scribe_Factory_Core.ViewModels;

namespace Scribe_Factory_Core.Controllers
{
    //[AuthorizationFilter]
    public class FunctionsController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IConfiguration Configuration;
        IProjectManagementRepository projectManagementRepository;
        AWSHelper aws = null;
        string BucketName = "";
        public FunctionsController(ILogger<HomeController> logger, IConfiguration configuration, IProjectManagementRepository projectManagementRepository)
        {
            _logger = logger;
            Configuration = configuration;
            this.projectManagementRepository = projectManagementRepository;
            var Accesskey = Configuration["AWSPollyAccessKey"];
            var SecretKey = Configuration["AWSPollySecretKey"];
            BucketName = Configuration["S3BucketName"];
            aws = new AWSHelper(Accesskey, SecretKey);
        }

        public IActionResult TextToSpeech()
        {
            return View();
        }

        [HttpGet]
        public IActionResult getLanguagesAgainstGender(string gender)
        {
            var Voices = aws.GetLanguagesAgainstGender(gender);
            return new JsonResult(Voices) { StatusCode = 200 };
        }
        [HttpGet]
        public IActionResult getVoicesAgainstLangugae(string LanguageCode, string gender)
        {
            var Voices = aws.GetVoicesAgainstLanguage(LanguageCode, gender);
            return new JsonResult(Voices) { StatusCode = 200 };
        }
        [HttpPost]
        public IActionResult ConvertTextToSpeech(string text, string VoiceId, string projectName, string ProjectType)
        {
            try
            {
                //saving a new project
                var currentUser = SessionHelper.GetObject<UserLoginViewModel>(HttpContext.Session, "CurrentUser");
                var projectId = projectManagementRepository.SaveProject(projectName, ProjectType, currentUser.User.TenantId);
                //settting current working projectId
                SessionHelper.SetObject(HttpContext.Session, "CurrentProjectId", projectId);
                //get details of voice from voiceID
                var voice = StaticVoiceDetails.AllVoices.Where(x => x.Id == VoiceId).FirstOrDefault();
                aws.ConvertTextToSpeech(text, VoiceId, voice.Name, voice.Engine.FirstOrDefault(), BucketName, projectId + "_" + projectName + ".mp3");
                ViewBag.ProjectId = projectId;
                return new JsonResult(projectId);
            }
            catch
            {
                return new JsonResult(false);

            }
        }
    }
}
