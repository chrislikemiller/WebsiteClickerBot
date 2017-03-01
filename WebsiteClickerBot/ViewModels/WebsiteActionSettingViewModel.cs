using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebsiteClickerBot.ViewModels
{
    public class WebsiteActionSettingViewModel : ViewModelBase
    {
        public int ID { get; set; }
        public string SelectorName { get; set; }
        public List<string> SelectorTypeList { get; set; } = new List<string>()
        {
            "ID",
            "Class",
            "Attribute name"
        };
        public List<string> ActionTypeList { get; set; } = new List<string>()
        {
            "Click",
            "Type text",
            "Type password"
        };

        public WebsiteActionSettingViewModel(int ID)
        {
            this.ID = ID;
        }
    }
}
