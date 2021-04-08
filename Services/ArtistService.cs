using System;
using System.Collections.Generic;
using artists.Models;
using artists.Repositories;

namespace artists.Services
{
    public class ArtistService
    {
        private readonly ArtistRepository _repo;

        public ArtistService(ArtistRepository repo)
        {
            _repo = repo;
        }

        internal IEnumerable<Artist> Get()
        {
            return _repo.Get();
        }

        internal Artist Create(Artist newArtist)
        {
            return _repo.Create(newArtist);
        }
    }
}