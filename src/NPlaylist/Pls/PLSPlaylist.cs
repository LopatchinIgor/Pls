namespace NPlaylist.Pls
{
    public class PLSPlaylist:BasePlaylist<PlSPlaylistItem>
    {
        public string PlaylistHeader = "[playlist]";
        private const string _playlistKeyVersion = "Version";
        private const string _playlistKeyNumberOfEntries = "NumberOfEntries";

        public string Version
        {
            get => Tags.TryGetValue(_playlistKeyVersion, out string value) ? value : null;
            set => Tags[_playlistKeyVersion] = value;
        }

        public string NumberOfEntries
        {
            get => Tags.TryGetValue(_playlistKeyNumberOfEntries, out string value) ? value : null;
            set => Tags[_playlistKeyNumberOfEntries] = value;
        }
    }
}
