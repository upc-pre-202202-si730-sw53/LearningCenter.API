using System.Net.Mime;
using LearningCenter.API.Analytics.Domain.Service;
using Microsoft.AspNetCore.Mvc;

namespace LearningCenter.API.Analytics.Interfaces.Rest.Controllers;

[ApiController]
[Route("/api/v1/analytics/learning")]
[Produces(MediaTypeNames.Application.Json)]
public class LearningAnalyticsController : ControllerBase
{
    private readonly ILearningAnalyticsService _learningAnalyticsService;

    public LearningAnalyticsController(ILearningAnalyticsService learningAnalyticsService)
    {
        _learningAnalyticsService = learningAnalyticsService;
    }

    [HttpGet("tutorials/total")]
    public int GetTutorialsCount()
    {
        return _learningAnalyticsService.TotalLearningTutorialsCount();
    }
    
}