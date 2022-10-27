using LearningCenter.API.Learning.Interfaces.Internal;

namespace LearningCenter.API.Learning.Services;

public class LearningContextFacade : ILearningContextFacade
{
    private readonly TutorialService _tutorialService;

    public LearningContextFacade(TutorialService tutorialService)
    {
        _tutorialService = tutorialService;
    }

    public int TotalTutorials()
    {
        return _tutorialService.ListAsync().Result.Count();
    }
}