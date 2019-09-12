using MetadataEntityModel.files;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MetadataEntityModel
{
    public class ProductModel : RootEntityModel
    {
        /// <summary>
        /// Наименование
        /// </summary>
        [Required(ErrorMessage = "Не указано имя")]
        public string Name { get; set; }

        /// <summary>
        /// внешний ключ
        /// </summary>
        [Required(ErrorMessage = "Не указана единица измерения")]
        public int UnitId { get; set; }
        /// <summary>
        /// Единица измерения
        /// </summary>
        public UnitModel Unit { get; set; }

        /// <summary>
        /// Количество
        /// </summary>
        [Required(ErrorMessage = "Не указано количество")]
        [Range(0.001, double.MaxValue, ErrorMessage = "Недопустимое количество")]
        public double Count { get; set; }

        /// <summary>
        /// Цена
        /// </summary>
        [Required(ErrorMessage = "Не указана цена")]
        [Range(0.001, double.MaxValue, ErrorMessage = "Недопустимая цена")]
        public double Price { get; set; }

        /// <summary>
        /// Ссылка на файл изображения
        /// </summary>
        public StorageFileProductThumbnailImageModel ThumbnailImage { get; set; }

        /// <summary>
        /// Связаные галлереи
        /// </summary>
        public List<GalleryModel> Galleries { get; set; }

        public override string ToString()
        {
            return Name.Trim() + " [" + Count.ToString() + Unit?.ShortName + "|" + Price.ToString() + "₽]";
        }
    }
}
