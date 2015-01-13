using System;

namespace Torshify
{
    public class SearchOptions : ISearchOptions
    {
        public static int DefaultSearchOffset { get; set; }

        static SearchOptions()
        {
            DefaultSearchOffset = 25;
        }

        public string Query { get; set; }

        public int TrackOffset { get; set; }
        public int TrackCount { get; set; }
        public int AlbumOffset { get; set; }
        public int AlbumCount { get; set; }
        public int ArtistOffset { get; set; }
        public int ArtistCount { get; set; }
        public int PlaylistOffset { get; set; }
        public int PlaylistCount { get; set; }

        public SearchType SearchType  { get; set; }

        public object UserData { get; set; }

        public SearchOptions(int offset)
        {
            TrackCount = offset;
            AlbumCount = offset;
            ArtistCount = offset;
            PlaylistCount = offset;
        }

        public SearchOptions()
            : this(DefaultSearchOffset)
        {
        }
    }
}

