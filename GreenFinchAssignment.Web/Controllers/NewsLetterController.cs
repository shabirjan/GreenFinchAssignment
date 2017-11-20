using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using GreenFinchAssignment.DataStructure;
using GreenFinchAssignment.Web.Models;

using GreenFinchAssignment.Web.Repository;

namespace GreenFinchAssignment.Web.Controllers
{
    public class NewsLetterController : Controller
    {

        private readonly ISubscriberRepository _subscribeRepository;
        public NewsLetterController(ISubscriberRepository subscribeRepository)
        {

            _subscribeRepository = subscribeRepository;
        }


        // GET: NewsLetter/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: NewsLetter/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Email,SubscribingSourceId,SubscribingReason")] SubscribingUserViewModel subscribingUserViewModel)
        {
            if (ModelState.IsValid)
            {
                _subscribeRepository.Insert(subscribingUserViewModel);
                return View("Success");
            }
            return View(subscribingUserViewModel);
        }


        public JsonResult EmailExists(string Email)
        {

            if (Email == null)
            {
                return Json(false);
            }

            try
            {

                return Json(_subscribeRepository.CheckIfEmailExists(Email));
            }
            catch (Exception ex)
            {

            }
            return Json(false);
        }



    }
}
