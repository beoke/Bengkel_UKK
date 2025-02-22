using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO; // Pastikan namespace ini ditambahkan

namespace Bengkel_UKK.Helper
{
    public class ImageDirectory
    {
        public static Image _imageResult;

        // Mengambil gambar dari folder Asset di path yang ditentukan dan meresize-nya
        public static byte[] _defaultProfile = ImageConvert.ImageToByteArray(
            ImageConvert.ResizeImageMax(
                Image.FromFile(@"D:\UKK\Bengkel_UKK\Bengkel_UKK\Asset\defaultProfile.png"),
                55, 55
            )
        );

        public static void FillInTheImage(Image image)
        {
            _imageResult = image;
        }
    }

}
