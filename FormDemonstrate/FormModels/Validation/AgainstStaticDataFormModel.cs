using System.ComponentModel.DataAnnotations;

namespace FormDemonstration.FormModels.Validation;

public class AgainstStaticDataFormModel
{
    [Required]
    public string ExampleString { get; set; } = "";
    [Range(2, int.MaxValue, ErrorMessage = "This is a custom message.")]
    public int ExampleInt { get; set; } = 1;
}