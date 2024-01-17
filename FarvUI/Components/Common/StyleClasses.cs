using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarvUI.Components.Common;

internal class StyleClasses
{
    private Dictionary<string,string> _classSets {  get; set; }
    public StyleClasses(Dictionary<string, string> ClassSets)
    {
        _classSets = ClassSets;
    }
    public string GetStyles(List<string> Keys)
    {
        var result = new StringBuilder();
        foreach (var Key in Keys)
        {
            string value;
            if(_classSets.TryGetValue(Key, out value))
            {
                result.AppendFormat(" {0} ", value);
            }           
        }
        return result.ToString();

    }
}
