using System;
using System.Net;

namespace SwitchMediaTest.Droid.Common
{
    public class Utils
    {
		public static Android.Graphics.Bitmap GetBitmapFromUrl(string url)
        {
            using (WebClient webClient = new WebClient())
            {
                byte[] bytes = webClient.DownloadData(url);
                if (bytes != null && bytes.Length > 0)
                {
                    return Android.Graphics.BitmapFactory.DecodeByteArray(bytes, 0, bytes.Length);
                }
            }
            return null;
        }

        public static Android.Graphics.Bitmap GetBitmapFromBytes(byte[] bytesImage)
        {
            if (bytesImage != null && bytesImage.Length > 0)
            {
                return Android.Graphics.BitmapFactory.DecodeByteArray(bytesImage, 0, bytesImage.Length);
            }

            return null;
        }
    }
}
