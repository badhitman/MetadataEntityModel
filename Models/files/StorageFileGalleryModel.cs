
namespace MetadataEntityModel.files
{
    public class StorageFileGalleryModel : StorageFileModel
    {
        public int GalleryId { get; set; }
        /// <summary>
        /// галлерея группировки файлов
        /// </summary>
        public GalleryModel Gallery { get; set; }
    }
}
