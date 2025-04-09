using Domain;
using Domain.DTOs;
using Domain.DTOs.ActivitySummaryDto;
using Domain.DTOs.Users;
using Domain.Responses;

namespace Infrastructure.Interfaces;

public interface IUserService
{
    Task<Response<List<GetUserDto>>> GetAllUsersAsync();
    Task<Response<GetUserDto>> GetUserByIdAsync(int id);
    Task<Response<GetUserDto>> CreateUserAsync(CreateUserDto createUserDto);
    Task<Response<GetUserDto>> UpdateUserAsync(int id, UpdateUserDto updateUserDto);
    Task<Response<string>> DeleteUserAsync(int id);
    Task<Response<List<UserPostsDto>>> GetUserPostsAsync(int id);
    Task<Response<List<NewRegistrationDto>>> GetNewRegistrationAsync();
    Task<Response<List<ActivePosterDto>>> GetActivePoster();
    Task<Response<List<RecentlyActiveUserDto>>> GetRecentlyActiveUsers();
    Task<Response<List<TopCreatorDto>>> GetTopCreators();
    Task<Response<List<HighInteractionUserDto>>> GetHighInteractionUsers();
    Task<Response<List<LatestPostDto>>> GetLatestPosts();
    Task<Response<List<UserRecentPostDto>>> GetUserRecentPosts(int userId);
    Task<Response<List<HighCommentPostDto>>> GetHighCommentPosts();
    Task<Response<List<RecentCommentDto>>> GetRecentComments();
    Task<Response<List<PostRecentCommentsDto>>> GetPostRecentComments(int id);
    Task<Response<List<LongTextCommentDto>>> GetLongTextComments();
    Task<Response<List<QuickResponseCommentDto>>> GetQuickResponseComments();
    Task<Response<List<ActivitySummaryDto>>> GetActivitySummary(int id);
    Task<Response<List<RecentPopularPostDto>>> GetRecentPopularPosts();
    Task<Response<List<TopCommenterDto>>> GetTopCommenters();
}