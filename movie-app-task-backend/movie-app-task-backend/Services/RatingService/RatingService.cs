using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using movie_app_task_backend.Data;
using movie_app_task_backend.Dtos.Rating;
using movie_app_task_backend.Models;

namespace movie_app_task_backend.Services.RatingService
{
    public class RatingService : IRatingService
    {

        private readonly DataContext _context;
        private IHttpContextAccessor _httpContextAccessor;

        public RatingService()
        {
        }

        public RatingService(DataContext context)
        {
            _context = context;
     
        }
        public async Task<bool> AddRating(float rating, int MediaId)
        {

            var result = false;


             var addRating = new Rating
            {
                Rating_value = rating,
                MediaId = MediaId,
                
            };

              await _context.Ratings.AddAsync(addRating);
                 await _context.SaveChangesAsync();


            result = true;

            return result;
        }
    }
}