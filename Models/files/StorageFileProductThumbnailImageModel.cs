using Microsoft.AspNetCore.Http;
using System.Drawing;
using System.IO;
using System.Text.RegularExpressions;

namespace MetadataEntityModel.files
{
    public class StorageFileProductThumbnailImageModel : StorageFileModel
    {
        public int ProductId { get; set; }
        /// <summary>
        /// связаная номенклатура
        /// </summary>
        public ProductModel Product { get; set; }

        public void LoadImage(IFormFile InputThumbFile)
        {
            using (BinaryReader binaryReader = new BinaryReader(InputThumbFile.OpenReadStream()))
            {
                byte[] imageAvatarData = null;
                byte[] imageData = binaryReader.ReadBytes((int)InputThumbFile.Length);

                using (Image img = Image.FromStream(InputThumbFile.OpenReadStream()))
                {
                    if (img.Width > 30 || img.Height > 30)
                        imageAvatarData = img.Resize(30, 30).ToByteArray();
                }

                Bytes = imageData;
                ThumbnailImageUpTo30Pixels = imageAvatarData;
                Filename = InputThumbFile.FileName;
                Information = "avatar uplosd by created product";
                Length = InputThumbFile.Length;
                MimeType = InputThumbFile.ContentType;
            }
        }

        public byte[] ThumbnailImageUpTo30Pixels { get; set; }

        public byte[] GetThumbnailBytes()
        {
            if (!Regex.IsMatch(MimeType, @"image/.*", RegexOptions.IgnoreCase))
                return new byte[0];

            if (ThumbnailImageUpTo30Pixels is null)
                if (Bytes is null)
                    return new byte[0];
                else
                    return Bytes;
            else
                return ThumbnailImageUpTo30Pixels;
        }
    }
}
