using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarvUI.Components.DropDownLib;

public interface IFarvDorpDownItem
{
    string GetName();
    string GetId();
    bool IsActive { get; set; }
    bool IsVisible { get; set; }
    bool IsChecked { get; set; }
}
