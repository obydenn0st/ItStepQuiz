using ItStepQuiz.Infrastructure.Entities;
using ItStepQuiz.Infrastructure.Persistence;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ItStepQuiz.Controllers.Test;

public class TestController : Controller
{
    private readonly DataContext _context;

    public TestController(DataContext context)
    {
        _context = context ?? throw new ArgumentNullException(nameof(context));
    }
    public async Task<IActionResult> Index()
    {
        return View();
    }

    public async Task<IActionResult> SaveQuestions(List<Questions> questions)
    {
        await _context.AddAsync(questions);
        await _context.SaveChangesAsync();
        return Ok();
    }

    public async Task<IActionResult> SaveAnswer(List<Answer> answers)
    {
        await _context.AddAsync(answers);
        await _context.SaveChangesAsync();
        return Ok();
    }

    public async Task<IActionResult> GetGame(Guid id) =>
     View(await GetQuestions(id));

    private async Task<List<Questions>> GetQuestions(Guid gameId) =>
        await _context.Questions.Where(w => w.Game.Id.Equals(gameId)).Include(w=>w.Question).ToListAsync();

    public async Task<IActionResult> EditGame(Guid Id,List<Questions> questions)
    {
        var replacedQuestions = await _context.Questions.Where(w=>w.Id.Equals(Id)).Select(s=> new Questions()
        {
            Id = s.Id,
            Name = s.Name,
            Game = s.Game,
            Question = s.Question
        }).ToListAsync();
        
        await _context.SaveChangesAsync();
        return View(questions);
    }
    public async Task<IActionResult> RemoveTest(Guid id)
    {
        var test = await _context.Games.Where(w => w.Id.Equals(id)).FirstOrDefaultAsync();
        var answers = await _context.Questions.Where(w => w.Game.Id.Equals(id)).ToListAsync();
        var questions = await _context.Questions.Where(w => w.Game.Id.Equals(id)).ToListAsync();
        _context.Remove(test);
        _context.Remove(answers);
        _context.Remove(questions);
        await _context.SaveChangesAsync();
        return Ok();
    }
}   
