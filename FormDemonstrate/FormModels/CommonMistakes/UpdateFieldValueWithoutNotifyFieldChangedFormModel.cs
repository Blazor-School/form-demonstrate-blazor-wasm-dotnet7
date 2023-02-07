using System.ComponentModel.DataAnnotations;

namespace FormDemonstration.FormModels.CommonMistakes;

public class UpdateFieldValueWithoutNotifyFieldChangedFormModel
{
    [Required]
    public string RequiredString { get; set; } = "Blazor School";
}
