using RemoteCamViewer.Extensions;

namespace RemoteCamViewer.Models
{
    /// <summary>
    /// Type of camera. The type defines the URL using which images of a camera can be downloaded
    /// 
    /// </summary>
    public enum CameraType
    {
        [CameraUrl("http://{ip-address}/webcapture.jpg?command=snap&channel={channel-number}")]
        Hi3516,

        [CameraUrl("http://{ip-address}/cgi-bin/snapshot.cgi?chn={channel-number}&u=admin&p=")]
        Defeway
    }
}
