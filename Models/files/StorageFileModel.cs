namespace MetadataEntityModel.files
{
    public class StorageFileModel : MetadataEntityModel.RootEntityModel
    {
        /// <summary>
        /// Менеджер/Админ, который сохранил файл в базу данных
        /// </summary>
        public int UserSavingId { get; set; }
        public UserModel UserSaving { get; set; }
        
        /// <summary>
        /// Оригинальное/Исходное имя файла
        /// </summary>
        public string Filename { get; set; }

        /// <summary>
        /// Размер файла в байтах
        /// </summary>
        public long Length { get; set; }

        public string MimeType { get; set; }

        /// <summary>
        /// Данные для сохранения
        /// </summary>
        public byte[] Bytes { get; set; }
    }
}
