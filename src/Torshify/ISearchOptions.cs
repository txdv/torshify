using System;

namespace Torshify
{
    public interface ISearchOptions
    {
        string Query { get; set; }

        int TrackOffset { get; set; }
        int TrackCount { get; set; }
        int AlbumOffset { get; set; }
        int AlbumCount { get; set; }
        int ArtistOffset { get; set; }
        int ArtistCount { get; set; }
        int PlaylistOffset { get; set; }
        int PlaylistCount { get; set; }

        SearchType SearchType  { get; set; }

        object UserData { get; set; }
    }
}

