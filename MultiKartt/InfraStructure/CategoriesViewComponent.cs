using Domains;
using MultiKartt.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MultiKartt.InfraStructure
{
    public class CategoriesViewComponent : ViewComponent
    {
        MultiContext ctx;
        public CategoriesViewComponent(MultiContext context)
        {
            ctx = context;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var categories = await GetCategoriesAsync();
            return View(categories);
        }

        private Task<List<TbCategory>> GetCategoriesAsync()
        {
            return ctx.TbCategory.ToListAsync();
        }
    }
}
