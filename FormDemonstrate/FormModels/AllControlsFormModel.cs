using Microsoft.AspNetCore.Components.Forms;
using System.ComponentModel.DataAnnotations;

namespace FormDemonstrate.FormModels;

public partial class AllControlsFormModel
{
    public bool SingleCheckbox { get; set; }
    public CheckboxModel[] CheckedCheckboxes { get; set; } = Array.Empty<CheckboxModel>(); // Assuming the type of the option is string
    public DateTime DateTime { get; set; }
    public DateTimeOffset DateTimeOffset { get; set; }
    public string SelectedRadio { get; set; } = "";
    public IReadOnlyList<IBrowserFile>? SelectedFiles { get; set; }
    public IBrowserFile? SelectedFile { get; set; }
    public int Number { get; set; }
    public string SingleOption { get; set; } = ""; // Assuming the type of the option is string
    [MaxLength(3)]
    public string[]? MultipleOptions { get; set; } = Array.Empty<string>(); // Assuming the type of the option is string
    public string SimpleText { get; set; } = "";
    public string LongText { get; set; } = "";
}
