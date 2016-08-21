using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CNS_ERP.Data;
using CNS_ERP.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;

namespace CNS_ERP.Controllers
{
    public class ApplicationRolesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ApplicationRolesController(ApplicationDbContext context)
        {
            _context = context;    
        }

        // GET: ApplicationRoles
        public async Task<IActionResult> Index()
        {
            return View(await _context.Roles.ToListAsync());
        }

        // GET: ApplicationRoles/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var applicationRole = await _context.Roles.SingleOrDefaultAsync(m => m.Id == id);
            if (applicationRole == null)
            {
                return NotFound();
            }

            return View(applicationRole);
        }

        // GET: ApplicationRoles/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: ApplicationRoles/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,ConcurrencyStamp,Name,NormalizedName")] IdentityRole applicationRole)
        {
            if (ModelState.IsValid)
            {
                _context.Add(applicationRole);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(applicationRole);
        }

        // GET: ApplicationRoles/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var applicationRole = await _context.Roles.SingleOrDefaultAsync(m => m.Id == id);
            if (applicationRole == null)
            {
                return NotFound();
            }
            return View(applicationRole);
        }

        // POST: ApplicationRoles/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("Id,ConcurrencyStamp,Name,NormalizedName")] IdentityRole applicationRole)
        {
            if (id != applicationRole.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(applicationRole);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ApplicationRoleExists(applicationRole.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction("Index");
            }
            return View(applicationRole);
        }

        // GET: ApplicationRoles/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var applicationRole = await _context.Roles.SingleOrDefaultAsync(m => m.Id == id);
            if (applicationRole == null)
            {
                return NotFound();
            }

            return View(applicationRole);
        }

        // POST: ApplicationRoles/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var applicationRole = await _context.Roles.SingleOrDefaultAsync(m => m.Id == id);
            _context.Roles.Remove(applicationRole);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        private bool ApplicationRoleExists(string id)
        {
            return _context.Roles.Any(e => e.Id == id);
        }
        [HttpGet]
        public IActionResult ManageUsersInGroups()
        {
            IEnumerable<ApplicationUser> users = _context.Users.ToList();
            IEnumerable<IdentityRole> roles = _context.Roles.ToList();
            ViewBag.Role = roles;
            return View(users);
        }

        [HttpGet]
        public ActionResult AddUserToGroup(string userName,string groupName)
        {
            bool isValid = true;
            var userfromDatabase = _context.Users.Where(u => u.UserName == userName).First();
            string userID = userfromDatabase.Id;
            var rolefromDatabase=_context.Roles.Where(u => u.Name == groupName).First();
            string roleID = rolefromDatabase.Id;
            IdentityUserRole<string> userAndrole = new IdentityUserRole<string>
            {
                RoleId = roleID,
                UserId = userID,
            };
            try
            {
                _context.UserRoles.Add(userAndrole);
                isValid = true;
                _context.SaveChanges();
            }
            catch (Exception)
            {
                isValid = false;
            }
            
            var obj = new
            {
                valid = isValid
            };
            return Json(obj);
        }
        [HttpGet]
        public ActionResult DajUzytkownikowDlaRoli(string groupName)
        {
            var rolefromDatabase = _context.Roles.Where(u => u.Name == groupName).First();
            string roleID = rolefromDatabase.Id;
            var userRolesfromDatabase = _context.UserRoles.Where(u => u.RoleId == groupName).ToList();
            return Json(userRolesfromDatabase);
        }
    }
}
