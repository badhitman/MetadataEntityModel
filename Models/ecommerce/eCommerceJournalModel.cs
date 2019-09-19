namespace MetadataEntityModel
{
    public enum TypesBaseObject
    {
        /// <summary>
        /// Ручная корректировка: [UserModel]. В таких случаях базовый объект это пользователь, который манипулировал вручную балансом клиента.
        /// В таких случаях нужно смотреть Информацию по объекту
        /// </summary>
        Custom = 1,

        /// <summary>
        /// Пополнение: [BtcTransactionOutModel]
        /// </summary>
        TxOut,

        /// <summary>
        /// Списание: [GalleryModel]
        /// </summary>
        Gallery
    }

    public class eCommerceJournalModel : RootEntityModel
    {
        /// <summary>
        /// Сумма в BTC
        /// </summary>
        public double SumBTC { get; set; }

        public int ClientId { get; set; }
        /// <summary>
        /// Связаный пользователь-клиент
        /// </summary>
        public UserModel Client { get; set; }

        /// <summary>
        /// Ссылка на связаный объект-владелец.
        /// Тип данных извлекается из [TypeBaseObject]
        /// </summary>
        public int BaseObjectId { get; set; }

        /// <summary>
        /// Тип базового объекта
        /// </summary>
        public TypesBaseObject TypeBaseObject { get; set; }

        public override string ToString()
        {
            return SumBTC+" BTC"+System.Environment.NewLine+Client.ToString();
        }
    }
}
