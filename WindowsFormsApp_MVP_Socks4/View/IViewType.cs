using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using WindowsFormsApp_MVP_Socks4.Model;

namespace WindowsFormsApp_MVP_Socks4.View
{
    public interface IViewType : IView
    {
        BindingList<TypeModel> allType { set; get; }
        event Action<string> DeleteType;
        event Action AddType;
        string newType { set; get; }


    }
}
