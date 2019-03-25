using System;
using System.Text;

namespace NPlaylist.Pls
{
    public class PLSSerialize:IPlaylistSerializer<PLSPlaylist>
    {
        public string Serialize(PLSPlaylist playlist)
        {
            if(playlist==null)
                return String.Empty;
            StringBuilder sb =new StringBuilder();
            sb.AppendLine(playlist.PlaylistHeader);
            sb.AppendLine();
            foreach (var i in playlist.Version)
            {
                
            }
        }
    }
}
