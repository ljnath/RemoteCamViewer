using MetroFramework;
using RemoteCamViewer.Common;
using RemoteCamViewer.Handlers;
using RemoteCamViewer.Models;
using System;
using System.Linq;

namespace RemoteCamViewer.Extensions
{
    /// <summary>
    /// Extension class for common String operation
    /// </summary>
    internal static class StringExtension
    {
        internal static MetroThemeStyle GetMetroThemeStyle(this string themeName)
        {
            foreach (MetroThemeStyle metroThemeStyle in Enum.GetValues(typeof(MetroThemeStyle)))
                if (metroThemeStyle.ToString().Equals(themeName))
                    return metroThemeStyle;

            return Constants.DefaultTheme;
        }

        internal static MetroColorStyle GetMetroColorStyle(this string colorType)
        {
            foreach (MetroColorStyle metroColorStyle in Enum.GetValues(typeof(MetroColorStyle)))
                if (metroColorStyle.ToString().Equals(colorType))
                    return metroColorStyle;

            return Constants.DefaultColor;
        }

        internal static Camera GetCameraFromId(this string cameraID)
        {
            if (!string.IsNullOrEmpty(cameraID))
                return ConfigHandler.Instance.Config.Cameras.FirstOrDefault(config => config.ID.Equals(cameraID)) ?? null;

            return null;
        }

        internal static Camera GetCameraFromSelectionText(this string selectionText)
        {
            string[] tokens = selectionText.Split('|');
            string lastToken = tokens[tokens.Length - 1].Trim();

            string cameraId = lastToken.Split('=')[1].Trim();
            return GetCameraFromId(cameraId);
        }

        internal static CameraType GetCameraTypeFromSelectionText(this string selectionText)
        {
            CameraType cameraType = Enum.GetValues(typeof(CameraType))
                .Cast<CameraType>()
                .FirstOrDefault(type => type.ToString().Equals(selectionText));

            return cameraType != default ? cameraType : CameraType.Hi3516;

            //foreach (CameraType cameraType in Enum.GetValues(typeof(CameraType)))
            //    if (cameraType.ToString().Equals(selectionText))
            //        return cameraType;

            //return CameraType.Hi3516;
        }
    }
}
