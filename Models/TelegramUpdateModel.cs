namespace MetadataEntityModel
{
    /// <summary>
    /// Объект БД для хранения JSON ответов Telegram
    /// </summary>
    public class TelegramUpdateModel : MetadataEntityModel.RootEntityModel
    {
        public int UserId { get; set; }
        public UserModel User { get; set; }
    }
}
