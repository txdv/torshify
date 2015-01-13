using System;

namespace Torshify
{
    public static class SearchOptionsExtensions
    {
        public static ISearch Search(this ISession session, SearchOptions searchOptions)
        {
            if (searchOptions == null)
            {
                throw new ArgumentNullException("searchOptions");
            }

            if (string.IsNullOrEmpty(searchOptions.Query))
            {
                throw new ArgumentException("query string can't be empty or null");
            }

            return session.Search(searchOptions.Query,
                searchOptions.TrackOffset,
                searchOptions.TrackCount,
                searchOptions.AlbumOffset,
                searchOptions.AlbumCount,
                searchOptions.ArtistOffset,
                searchOptions.ArtistCount,
                searchOptions.PlaylistOffset,
                searchOptions.PlaylistCount,
                searchOptions.SearchType);
        }
    }
}

