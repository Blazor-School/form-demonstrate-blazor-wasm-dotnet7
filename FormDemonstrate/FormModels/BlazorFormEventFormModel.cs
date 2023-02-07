using System.ComponentModel.DataAnnotations;

namespace FormDemonstration.FormModels;

public class BlazorFormEventFormModel
{
    [Required]
    public string ExampleString { get; set; } = "";
}
