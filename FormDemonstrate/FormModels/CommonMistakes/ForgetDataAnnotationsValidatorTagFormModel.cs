using System.ComponentModel.DataAnnotations;

namespace FormDemonstration.FormModels.CommonMistakes;

public class ForgetDataAnnotationsValidatorTagFormModel
{
    [Required]
    public string RequiredString { get; set; } = "";
}