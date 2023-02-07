using System.ComponentModel.DataAnnotations;

namespace FormDemonstration.FormModels.Validation;

public class AgainstDynamicDataFormModel
{
    public bool AllowText { get; set; } = false;
    public string Text { get; set; } = "";
}