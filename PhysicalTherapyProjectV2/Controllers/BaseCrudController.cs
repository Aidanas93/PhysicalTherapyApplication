using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PhysicalTherapyProjectV2.Models.Interfaces;
using PhysicalTherapyProjectV2.Services.Interfaces;

namespace PhysicalTherapyProjectV2.Controllers
{
    public abstract class BaseCrudController<T> : Controller 
        where T : class, IEntity, new()
    {
        protected IGenericService<T> genericService;
        public BaseCrudController(IGenericService<T> _genericService)
        {
            genericService = _genericService;
        }

        [HttpGet]
        public virtual async Task<ActionResult> Index() => View(await genericService.GetAllAsync());

        [HttpGet]
        public virtual async Task<ActionResult> Get(int id) => View(await genericService.GetByIdAsync(id));

        [HttpGet]
        public virtual ActionResult Create() => View(new T());

        [HttpPost]
        public virtual async Task<ActionResult> Create(T entity)
        {
            if (!ModelState.IsValid)
            {
                return View();

            }
            
            if(entity.Id == 0)
            {
                var created_ent = await genericService.InsertAsync(entity);
                TempData["message"] = $"{created_ent} buvo sukurtas!";
            }
            else
            {
                var updated_ent = await genericService.UpdateAsync(entity);
                TempData["message"] = $"{updated_ent} buvo redaguotas!";
            }

            return RedirectToAction(nameof(Index));
        }



        [HttpGet]
        public virtual async Task<IActionResult> Edit(int id) =>
            View(nameof(Create), await genericService.GetByIdAsync(id));

        [HttpPost]
        public async Task<IActionResult> Delete(int id)
        {
            var entity = await genericService.DeleteAsync(id);

            if(entity != null)
            {
                TempData["message"] = $"{entity} buvo ištrintas!";
            }

            return RedirectToAction(nameof(Index));
        }


    }
}