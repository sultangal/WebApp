﻿using Microsoft.AspNetCore.Mvc.RazorPages;
using WebApp.Models;

namespace WebApp.Pages
{
    public class EditorPageModel : PageModel
    {
        public EditorPageModel(DataContext dbContext)
        {
            DataContext = dbContext;
        }

        public DataContext DataContext { get; set; }
        public IEnumerable<Category> Categories => DataContext.Categories;
        public IEnumerable<Supplier> Suppliers => DataContext.Suppliers;
        public ProductViewModel? ViewModel { get; set; }
    }
}