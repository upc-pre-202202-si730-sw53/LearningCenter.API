using LearningCenter.API.Analytics.Domain.Service;
using LearningCenter.API.Learning.Interfaces.Internal;

namespace LearningCenter.API.Analytics.Service;

public class LearningAnalyticsService : ILearningAnalyticsService
{
    private readonly ILearningContextFacade _learningContext;

    public LearningAnalyticsService(ILearningContextFacade learningContext)
    {
        _learningContext = learningContext;
    }

    public int TotalLearningTutorialsCount()
    {
        return _learningContext.TotalTutorials();
    }
}