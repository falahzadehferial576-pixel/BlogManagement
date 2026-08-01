using BlogManagement.Application.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;
using AutoMapper;
using BlogManagement.Application.DTOs.Category;
using BlogManagement.Application.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;
namespace BlogManagement.Web.Areas.Admin.Controllers;

[Area("Admin")]
public class CategoryController : Controller
{
    private readonly ICategoryService _categoryService;
    private readonly IMapper _mapper;

    public CategoryController(ICategoryService categoryService, IMapper mapper)
    {
        _categoryService = categoryService;
        _mapper = mapper;
    }

    public async Task<IActionResult> Index()
    {
        var categories = await _categoryService.GetAllAsync();

        var model = _mapper.Map<List<CategoryDto>>(categories);

        return View(model);
    }

    [HttpGet]
    public IActionResult Create()
    {
        return View();
    }

    [HttpGet]
    public async Task<IActionResult> Edit(int id)
    {
        var category = await _categoryService.GetByIdAsync(id);

        if (category == null)
            return NotFound();

        var model = _mapper.Map<UpdateCategoryDto>(category);

        return View(model);
    }

    [HttpPost]
    public async Task<IActionResult> Edit(UpdateCategoryDto model)
    {
        if (!ModelState.IsValid)
            return View(model);

        var category = await _categoryService.GetByIdAsync(model.Id);

        if (category == null)
            return NotFound();

        _mapper.Map(model, category);

        await _categoryService.UpdateAsync(category);

        return RedirectToAction(nameof(Index));
    }

    [HttpPost]
    public async Task<IActionResult> Create(CreateCategoryDto model)
    {
        if (!ModelState.IsValid)
            return View(model);

        if (await _categoryService.IsTitleExistAsync(model.Title))
        {
            ModelState.AddModelError("Title", "این دسته‌بندی قبلاً ثبت شده است.");
            return View(model);
        }

        var category = _mapper.Map<BlogManagement.Domain.Entities.Category>(model);

        await _categoryService.AddAsync(category);

        return RedirectToAction(nameof(Index));
    }
    [HttpPost]
    public async Task<IActionResult> Delete(int id)
    {
        var category = await _categoryService.GetByIdAsync(id);

        if (category == null)
            return NotFound();

        await _categoryService.DeleteAsync(id);

        return RedirectToAction(nameof(Index));
    }

}