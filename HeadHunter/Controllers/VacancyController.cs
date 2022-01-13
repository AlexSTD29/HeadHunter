﻿using HeadHunter.Entities;
using HeadHunter.Enums;
using HeadHunter.Models;
using HeadHunter.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace HeadHunter.Controllers
{
    public class VacancyController : Controller
    {
        private HeadHunterContext _context;
        public VacancyController(HeadHunterContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var vacancies = _context.Vacancies.Where(v => v.Status == PublishStatus.InPublic).OrderByDescending(r => r.RefreshDate);
            return View(vacancies);
        }

        public IActionResult Add() => View();

        [HttpPost]
        public IActionResult Add(Vacancy vacancy)
        {
            if (vacancy != null)
            {
                var userName = User.Identity.Name;
                vacancy.UserId = _context.Users.FirstOrDefault(u => u.UserName == userName).Id;
                vacancy.RefreshDate = DateTime.Now;
                vacancy.Status = PublishStatus.Secure;
                _context.Vacancies.Add(vacancy);
                _context.SaveChanges();
            }

            return RedirectToAction("Index", "Resume");
        }

        public IActionResult ChangePublishStatus(int vacancyId)
        {
            var vacancy = _context.Vacancies.Find(vacancyId);

            if (vacancy.Status == PublishStatus.InPublic)
                vacancy.Status = PublishStatus.Secure;
            else
                vacancy.Status = PublishStatus.InPublic;
            
            _context.SaveChanges();
            return RedirectToAction("Index", "Resume");
        }
        public IActionResult RefreshDate(int vacancyId)
        {
            var vacancy = _context.Vacancies.Find(vacancyId);

            vacancy.RefreshDate = DateTime.Now;

            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Details(int vacancyId)
        {
            var vacancyDetails = new VacancyDetailViewModel()
            {
                Vacancy = _context.Vacancies.Find(vacancyId),
                Resumes = _context.Resumes.Where(r => r.UserId == _context.Users.FirstOrDefault(u => u.UserName == User.Identity.Name).Id),
            };

            return View(vacancyDetails);
        }
    }
}
