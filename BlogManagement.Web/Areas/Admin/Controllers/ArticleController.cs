using AutoMapper;
using BlogManagement.Application.DTOs.Article;
using BlogManagement.Application.DTOs.Category;
using BlogManagement.Application.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;

namespace BlogManagement.Web.Areas.Admin.Controllers
{
    public class ArticleController : Controller
    {
        private readonly IArticleService _articleService;
        private readonly ICategoryService _categoryService;
        private readonly IMapper _mapper;

        public ArticleController(
            IArticleService articleService,
            ICategoryService categoryService,
            IMapper mapper)
        {
            _articleService = articleService;
            _categoryService = categoryService;
            _mapper = mapper;
        }
        public async Task<IActionResult> Index()
        {
            var articles = await _articleService.GetAllWithCategoryAsync();

            var model = _mapper.Map<List<ArticleDto>>(articles);

            return View(model);
        }
        [HttpGet]
        public async Task<IActionResult> Create()
        {
            var categories = await _categoryService.GetAllAsync();

            ViewBag.Categories = _mapper.Map<List<CategoryDto>>(categories);

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateArticleDto model)
        {
            if (model.ImageFile != null)
            {
                string fileName = Guid.NewGuid().ToString() +
                                  Path.GetExtension(model.ImageFile.FileName);

                string path = Path.Combine(
                    Directory.GetCurrentDirectory(),
                    "wwwroot",
                    "uploads",
                    "articles",
                    fileName);

                using (var stream = new FileStream(path, FileMode.Create))
                {
                    await model.ImageFile.CopyToAsync(stream);
                }

                model.ImageName = fileName;
            }
            if (!ModelState.IsValid)
            {
                ViewBag.Categories = _mapper.Map<List<CategoryDto>>(await _categoryService.GetAllAsync());
                return View(model);
            }

            var article = _mapper.Map<BlogManagement.Domain.Entities.Article>(model);

            await _articleService.AddAsync(article);

            return RedirectToAction(nameof(Index));
        }
        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            var article = await _articleService.GetByIdWithCategoryAsync(id);

            if (article == null)
                return NotFound();

            ViewBag.Categories = await _categoryService.GetAllAsync();

            var model = _mapper.Map<UpdateArticleDto>(article);

            return View(model);
        }
        [HttpPost]
        public async Task<IActionResult> Edit(UpdateArticleDto model)
        {
            if (!ModelState.IsValid)
            {
                ViewBag.Categories = await _categoryService.GetAllAsync();
                return View(model);
            }

            var article = await _articleService.GetByIdAsync(model.Id);

            if (article == null)
                return NotFound();

            _mapper.Map(model, article);

            await _articleService.UpdateAsync(article);

            return RedirectToAction(nameof(Index));
        }
        [HttpPost]
        public async Task<IActionResult> Delete(int id)
        {
            await _articleService.DeleteAsync(id);

            return RedirectToAction(nameof(Index));
        }
    }
}
