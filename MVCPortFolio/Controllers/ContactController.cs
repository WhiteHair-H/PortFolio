using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MVCPortFolio.Data;
using MVCPortFolio.Models;

namespace MVCPortFolio.Controllers
{
    public class ContactController : Controller
    {
        private readonly MVCPortFolioContext _context;

        public ContactController(MVCPortFolioContext context)
        {
            _context = context;
        }

        // GET: Contact
        public async Task<IActionResult> Index()
        {
            return View();
        }

        
        [HttpPost]
        public async Task<IActionResult> Index([Bind("Id,Name,Email,Contents")] Contact contact)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    contact.Regdate = DateTime.Now;
                    _context.Add(contact);
                    await _context.SaveChangesAsync();

                    ModelState.Clear();
                }
                catch (Exception ex)
                {
                    ModelState.Clear();
                }
                //return RedirectToAction(nameof(Index));
            }
            return View();
        }
    }
}
