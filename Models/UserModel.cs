using MetadataEntityModel.files;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MetadataEntityModel
{
    public class UserModel : MetadataEntityModel.RootEntityModel
    {
        #region Реквизиты

        public string Username { get; set; }

        public string PasswordHash { get; set; }

        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        public long TelegramId { get; set; }

        [Display(Name = "Telegram пользователь")]
        public string AboutTelegramUser { get; set; }

        /// <summary>
        /// Уровень доступа/привелегий пользователя [access_level]
        /// </summary>
        [Required]
        [Display(Name = "Уровень")]
        public AccessLevelUserModel AccessLevel { get; set; }

        public ModeAnswerTelegramBotModel ModeAnswerTelegramBot { get; set; } = ModeAnswerTelegramBotModel.AutoAnswerTelegramBot;

        /// <summary>
        /// Bitcoin addres
        /// </summary>
        [Display(Name = "BTC address")]
        public string BitcoinAddress { get; set; }

        /// <summary>
        /// Баланс пользователя
        /// </summary>
        [Display(Name = "Баланс BTC")]
        public double BalanceBTC { get; set; }

        /// <summary>
        /// Авторизующий токен. Одноразовый временный параметр для авторизации. Например в http.get запросе через некоторый параметр
        /// </summary>
        [Display(Name = "Токен доступа")]
        public string AuthToken { get; set; }

        /// <summary>
        /// ДатаВремя создания токена авторизации
        /// </summary>
        [Display(Name = "Дата/время создания токена авторизации")]
        public DateTime AuthTokenCreated { get; set; }

        /// <summary>
        /// Последняя дата/время активности
        /// </summary>
        [Display(Name = "Последняя активность через Web")]
        public DateTime LastWebActiv { get; set; }

        [Display(Name = "Последняя активность через Telegram")]
        public DateTime LastTelegramActiv { get; set; }

        #endregion

        #region Навигационные свойства

        /// <summary>
        /// Сообщения в которых пользователь выступает получателем
        /// </summary>
        public List<MessageModel> ReceivedMessages { get; set; }

        /// <summary>
        /// Сообщения в которых пользователь выступает отправителем
        /// </summary>
        public List<MessageModel> SentMessages { get; set; }

        /// <summary>
        /// Связаные сохранённые в БД файлы.
        /// В файлах указывается администратор, который записал файл в БД
        /// </summary>
        public List<StorageFileGalleryModel> SavedFiles { get; set; }

        /// <summary>
        /// Связаные выходы btc транзакций
        /// </summary>
        public List<BtcTransactionOutModel> TransactionsOutputs { get; set; }

        /// <summary>
        /// Связаные полученные данный от TelegramBot
        /// </summary>
        public List<TelegramUpdateModel> TelegramUpdates { get; set; }

        public List<eCommerceJournalModel> eCommerceJournal { get; set; }
        
        public List<GalleryModel> Galleries { get; set; }
        #endregion

        public override string ToString()
        {
            string ret_val = "";
            ret_val += IsDelete ? " [DELETE]" : "";
            ret_val += IsOff ? " [OFF]" : "";

            if (!string.IsNullOrEmpty(Username))
                ret_val += " [username: " + Username + "]";

            if (!string.IsNullOrEmpty(Email))
                ret_val += " [email: " + Email + "]";

            if (TelegramId != 0)
                ret_val += " [telegramId: " + TelegramId + "]";

            return ret_val.Trim();
        }
    }
}
