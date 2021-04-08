using System;
using System.Collections.Generic;
using System.Data;
using artists.Models;
using Dapper;

namespace artists.Repositories
{
    public class ArtistRepository
    {
        public readonly IDbConnection _db;

        public ArtistRepository(IDbConnection db)
        {
            _db = db;
        }

        internal IEnumerable<Artist> Get()
        {
            string sql = "SELECT * FROM artists;";
            return _db.Query<Artist>(sql);
        }

        internal Artist Create(Artist newArtist)
        {
            string sql = @"
            INSERT INTO artists
            (name, description, age)
            VALUES
            (@Name, @Description, @Age);
            SELECT LAST_INSERT_ID();";
            int id = _db.ExecuteScalar<int>(sql, newArtist);
            newArtist.Id = id;
            return newArtist;
        }
    }
}