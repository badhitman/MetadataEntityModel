using System.ComponentModel.DataAnnotations;

namespace MetadataEntityModel
{
    public enum ModeAnswerTelegramBotModel
    {
        [Display(Name = "Режим [бот-автоответчик]")]
        AutoAnswerTelegramBot,

        [Display(Name = "Режим [чат с оператором]")]
        OperatorChat
    }
}
