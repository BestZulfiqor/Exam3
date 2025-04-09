using Domain;
using Domain.DTOs;
using Domain.DTOs.ActivitySummaryDto;
using Domain.DTOs.Posts;
using Domain.DTOs.Users;
using Domain.Responses;
using Infrastructure.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers;
[ApiController]
[Route("api/[controller]")]
public class UserController(IUserService service)
{
    [HttpGet]
    public async Task<Response<List<GetUserDto>>> GetUserAsync()
    {
        var users = await service.GetAllUsersAsync();
        return users;
    }

    [HttpGet("{id:int}")]
    public async Task<Response<GetUserDto>> GetPostAsync(int id)
    {
        var user = await service.GetUserByIdAsync(id);
        return user;
    }

    [HttpPost]
    public async Task<Response<GetUserDto>> CreateUserAsync(CreateUserDto createUserDto)
    {
        var user = await service.CreateUserAsync(createUserDto);
        return user;
    }

    [HttpPut("{id:int}")]
    public async Task<Response<GetUserDto>> UpdateUserAsync(int id, UpdateUserDto updateUserDto)
    {
        var user = await service.UpdateUserAsync(id, updateUserDto);
        return user;
    }

    [HttpDelete("{id:int}")]
    public async Task<Response<string>> DeleteUserAsync(int id)
    {
        var user = await service.DeleteUserAsync(id);
        return user;
    }

    [HttpGet("userId/{id:int}")]
    public async Task<Response<List<UserPostsDto>>> GetUserPostsAsync(int id)
    {
        var user = await service.GetUserPostsAsync(id);
        return user;
    }

    [HttpGet("new-registrations")]
    public async Task<Response<List<NewRegistrationDto>>> GetNewRegistrationAsync()
    {
        var user = await service.GetNewRegistrationAsync();
        return user;
    }
    [HttpGet("active-posters")]
    public async Task<Response<List<ActivePosterDto>>> GetActivePosterAsync()
    {
        var user = await service.GetActivePoster();
        return user;
    }
    [HttpGet("recently-active")]
    public async Task<Response<List<RecentlyActiveUserDto>>> GetRecentlyActiveUsersAsync()
    {
        var user = await service.GetRecentlyActiveUsers();
        return user;
    }
    [HttpGet("top-creators")]
    public async Task<Response<List<TopCreatorDto>>> GetTopCreatorsAsync()
    {
        var user = await service.GetTopCreators();
        return user;
    }
    [HttpGet("high-interaction")]
    public async Task<Response<List<HighInteractionUserDto>>> GetHighInteractionUsersAsync()
    {
        var user = await service.GetHighInteractionUsers();
        return user;
    }
    [HttpGet("latest-posts")]
    public async Task<Response<List<LatestPostDto>>> GetLatestPostsAsync()
    {
        var user = await service.GetLatestPosts();
        return user;
    }
    [HttpGet("user-recent")]
    public async Task<Response<List<UserRecentPostDto>>> GetUserRecentPostsAsync(int userId)
    {
        var user = await service.GetUserRecentPosts(userId);
        return user;
    }
    [HttpGet("recent")]
    public async Task<Response<List<RecentCommentDto>>> GetRecentCommentsAsync()
    {
        var user = await service.GetRecentComments();
        return user;
    }
    [HttpGet("high-comment")]
    public async Task<Response<List<HighCommentPostDto>>> GetHighCommentPostsAsync()
    {
        var user = await service.GetHighCommentPosts();
        return user;
    }
    [HttpGet("{by-post-id:int}")]
    public async Task<Response<List<PostRecentCommentsDto>>> GetPostRecentCommentsAsync(int id)
    {
        var user = await service.GetPostRecentComments(id);
        return user;
    }
    [HttpGet("long-text")]
    public async Task<Response<List<LongTextCommentDto>>> GetLongTextCommentsAsync()
    {
        var user = await service.GetLongTextComments();
        return user;
    }
    [HttpGet("quick-responses")]
    public async Task<Response<List<QuickResponseCommentDto>>> GetQuickResponseCommentsAsync()
    {
        var user = await service.GetQuickResponseComments();
        return user;
    }
    [HttpGet("{activity-summary:int}")]
    public async Task<Response<List<ActivitySummaryDto>>> GetActivitySummaryAsync(int id)
    {
        var user = await service.GetActivitySummary(id);
        return user;
    }
    [HttpGet("recent-popular")]
    public async Task<Response<List<RecentPopularPostDto>>> GetRecentPopularPostsAsync()
    {
        var user = await service.GetRecentPopularPosts();
        return user;
    }
    [HttpGet("top-commenters")]
    public async Task<Response<List<TopCommenterDto>>> GetTopCommentersAsync()
    {
        var user = await service.GetTopCommenters();
        return user;
    }
}