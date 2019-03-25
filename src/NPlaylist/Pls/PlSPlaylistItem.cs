using System.Security.Policy;

namespace NPlaylist.Pls
{
    public  class PlSPlaylistItem:BasePlaylist<PlSPlaylistItem>, IPlaylistItem
    {
        private const string _itemKeyLenght = "Lenght";
        private const string _itemKeyTitle = "Title";

        public string Lenght
        {
            get => Tags.TryGetValue(_itemKeyLenght, out string value) ? value : null;
            set => Tags[_itemKeyLenght] = value;
        }

        public string Title
        {
            get => Tags.TryGetValue(_itemKeyTitle, out string value) ? value : null;
            set => Tags[_itemKeyTitle] = value;
        }
        public string Path { get; }
    }
}
