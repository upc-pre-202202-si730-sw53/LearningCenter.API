using LearningCenter.API.Learning.Domain.Models;
using LearningCenter.API.Learning.Domain.Repositories;
using LearningCenter.API.Shared.Persistence.Contexts;
using LearningCenter.API.Shared.Persistence.Repositories;
using Microsoft.EntityFrameworkCore;

namespace LearningCenter.API.Learning.Persistence.Repositories;

public class TutorialRepository : BaseRepository, ITutorialRepository
{
    public TutorialRepository(AppDbContext context) : base(context)
    {
    }

    public async Task<IEnumerable<Tutorial>> ListAsync()
    {
        return await _context.Tutorials
            .Include(p => p.Category)
            .ToListAsync();
    }

    public async Task AddAsync(Tutorial tutorial)
    {
        await _context.Tutorials.AddAsync(tutorial);
    }

    public Task<Tutorial> FindByIdAsync(int tutorialId)
    {
        throw new NotImplementedException();
    }

    public Task<Tutorial> FindByTitleAsync(string title)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<Tutorial>> FindByCategoryIdAsync(int categoryId)
    {
        throw new NotImplementedException();
    }

    public void Update(Tutorial tutorial)
    {
        throw new NotImplementedException();
    }

    public void Remove(Tutorial tutorial)
    {
        throw new NotImplementedException();
    }
}