﻿using JSM.Web.Models.Shared.Resume;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace JSM.Web.Controllers {
    public class SkillsAndTechController : BaseController {
        public ActionResult Index() {
            return View("Section", Resume.Instance.FindSection("skills-and-tech"));
        }
    }
}