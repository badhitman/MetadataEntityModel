using MetadataEntityModel.files;
using System.Collections.Generic;

namespace MetadataEntityModel
{
    /// <summary>
    /// Галерея файлов
    /// </summary>
    public class GalleryModel : MetadataEntityModel.RootEntityModel
    {
        public int ProductId { get; set; }
        /// <summary>
        /// Связаный товар [Номенклатура]
        /// </summary>
        public ProductModel Product { get; set; }

        public int DeliveryCityId { get; set; }
        /// <summary>
        /// Связаный город [населённый пункт] доставки
        /// </summary>
        public DeliveryCityModel DeliveryCity { get; set; }

        public int DeliveryMethodId { get; set; }
        /// <summary>
        /// Связаный метод доставки
        /// </summary>
        public DeliveryMethodModel DeliveryMethod { get; set; }

        public int DeliveryServiceId { get; set; }
        /// <summary>
        /// Связаная служба доставки
        /// </summary>
        public DeliveryServiceModel DeliveryService { get; set; }

        /// <summary>
        /// Стоимость доставки
        /// </summary>
        public int DeliveryPrice { get; set; }

        public int? UserId { get; set; }
        /// <summary>
        /// Связаный пользователь
        /// </summary>
        public UserModel User { get; set; }

        /// <summary>
        /// Связанные сохранённые файлы
        /// </summary>
        public List<StorageFileGalleryModel> SavedFiles { get; set; }

        public override bool IsAvailable => UserId is null && base.IsAvailable;
    }
}
