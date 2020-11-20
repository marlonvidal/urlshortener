using System;
using System.Collections.Generic;
using System.Text;
using UrlShortener.Data.Context;
using UrlShortener.Model;

namespace UrlShortener.Data.Repositories
{
    public class LinkRepository : BaseRepository<Link>
    {
        public LinkRepository(UrlShortenerDbContext dbContext) : base(dbContext)
        {

        }
    }
}
