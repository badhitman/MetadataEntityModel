////////////////////////////////////////////////
// https://github.com/badhitman 
////////////////////////////////////////////////
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MetadataEntityModel
{
    public class LiteEntityModel
    {
        /// <summary>
        /// Ключ/Идентификатор объекта
        /// </summary>
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        /// <summary>
        /// Чтение/Запись коментария для объекта [info]
        /// </summary>
        [Display(Name = "Информация", Description = "Произвольная информация к объекту")]
        public string Information { get; set; }

        /// <summary>
        /// Дата создания объекта
        /// </summary>
        [Display(Name = "Дата создания", Description = "Дата/Время создания объекта")]
        public virtual DateTime DateCreate { get; set; }
    }
}
