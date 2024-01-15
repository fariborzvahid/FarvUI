using FarvUI.Components.DropDownLib;




namespace BlazorTestApp.FarvUi.Exstensions;

public class DropdownItem : IFarvDorpDownItem
{
    private Guid id = Guid.NewGuid();
    public string name { get; set; }
    public bool IsActive { get; set; } = true;
    public bool IsVisible { get; set; } = true;
    public bool IsChecked { get; set; }

    public string GetId()
    {
        return id.ToString();
    }

    public string GetName()
    {
        return name;
    }
}

