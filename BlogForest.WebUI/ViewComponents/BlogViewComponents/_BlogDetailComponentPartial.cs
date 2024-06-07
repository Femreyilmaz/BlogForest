﻿using BlogForest.BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace BlogForest.WebUI.ViewComponents.BlogViewComponents
{
    public class _BlogDetailComponentPartial : ViewComponent
    {
        private readonly IBlogService _blogService;

        public _BlogDetailComponentPartial(IBlogService blogService)
        {
            _blogService = blogService;
        }

        public IViewComponentResult Invoke(int id)
        {
            var value = _blogService.TGetById(id);
            return View(value);
        }
    }
}
