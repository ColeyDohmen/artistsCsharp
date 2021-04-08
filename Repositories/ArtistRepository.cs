using System;
using System.Collections.Generic;
using artists.Models;

    namespace artists.Repositories
{
    public class ArtistRepository
    {
        internal IEnumerable<Artist> Get()
        {
            string sql = "SELECT * FROM artists;";
            return _db.Query<Artist>(sql);
         }
    }
}