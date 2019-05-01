using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp_MVP_Socks4.SocksServise;

namespace WindowsFormsApp_MVP_Socks4.Model
{
    public class Model_Type : IModel
    {
        private ServiceSocks2Client Service = new ServiceSocks2Client();

        public BindingList<TypeModel> AllType()
        {
            type[] tmp = Service.readAll();
            BindingList<TypeModel> type = new BindingList<TypeModel>();

            foreach (type item in tmp)
            {
                type.Add(new TypeModel {
                   Id = item.id,
                   Name = item.name
                });
            }
            return type;
        }

        public void DeleteType(int Id)
        {
            Service.delete(Id);
        }

        public void SaveType(string someName)
        {
            
            type[] myType = new type[1];
            type t = new type();
            t.name = someName;
            myType[0] = t;
            Service.save(myType);
            
        }
    }
}
