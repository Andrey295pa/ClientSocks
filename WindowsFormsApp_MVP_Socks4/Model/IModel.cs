using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp_MVP_Socks4.Model
{
    public interface IModel
    {
        BindingList<TypeModel> AllType();
        void SaveType(string someType);
        void DeleteType(int Id);
    }
}
