using Microsoft.Extensions.Caching.Memory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserApp.application.Common;
using UsersApp.domain.Entities;

namespace UsersApp.infrastructure.Database
{
    public class ExternalUserCacheService : IUserCacheService
    {
        private readonly IMemoryCache _cache;
        private readonly IExternalUserApi _externalApi;

        public ExternalUserCacheService(IMemoryCache cache, IExternalUserApi externalApi)
        {
            _cache = cache;
            _externalApi = externalApi;
        }

        public async Task<IEnumerable<User>> GetUsersFromCacheOrApiAsync()
        {
            if (_cache.TryGetValue("external_users_date", out DateTime cachedDate))
            {
                if (cachedDate.Date == DateTime.UtcNow.Date &&
                    _cache.TryGetValue("external_users", out IEnumerable<User>? cachedUsers))
                {
                    return cachedUsers ?? Enumerable.Empty<User>();
                }
            }
            var externalUsers = await _externalApi.GetUsersAsync();

            var mappedUsers = externalUsers.Select(u => new User
            {
                Name = u.Name,
                Username = u.Username,
                Email = u.Email,
                AddressStreet = u.Address.Street,
                AddressCity = u.Address.Street,
                Website = u.Website,
                Password = Guid.NewGuid().ToString(),
                GeoLng = (double)u.Address.Geo.Lat,
                GeoLat = (double)u.Address.Geo.Lng
            }).ToList();

            var expiration = DateTime.Today.AddDays(1) - DateTime.UtcNow;

            _cache.Set("external_users", mappedUsers, expiration);
            _cache.Set("external_users_date", DateTime.UtcNow, expiration);

            return mappedUsers;
        }
    }
}
