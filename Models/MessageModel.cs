namespace MetadataEntityModel
{
    public class MessageModel : MetadataEntityModel.RootEntityModel
    {
        /// <summary>
        /// Сообщение прочитано
        /// </summary>
        public bool IsReaded { get; set; } = false;

        /// <summary>
        /// Признак того, что уведомление требуется продублировать через Telegram бота.
        /// Если у пользователя нет связаного TelgramId, то автоматически выставляется как "True"
        /// </summary>
        public bool NeedTelegramNotify { get; set; } = false;

        /// <summary>
        /// ID отправителя
        /// </summary>
        public int? SenderId { get; set; }
        /// <summary>
        /// Отправитель
        /// </summary>
        public UserModel Sender { get; set; }

        /// <summary>
        /// ID Получателя
        /// </summary>
        public int RecipientId { get; set; }
        /// <summary>
        /// Получатель
        /// </summary>
        public UserModel Recipient { get; set; }
    }
}
