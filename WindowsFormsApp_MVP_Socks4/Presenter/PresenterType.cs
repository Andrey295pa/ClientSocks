using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using WindowsFormsApp_MVP_Socks4.View;
using WindowsFormsApp_MVP_Socks4.Model;
using WindowsFormsApp_MVP_Socks4.Control;

namespace WindowsFormsApp_MVP_Socks4.Presenter
{
    public class PresenterType : BasePresenter<IViewType>
    {
        private readonly IModel model;

        public PresenterType(IApplicationController _controller,
            IViewType _type,IModel _model)
            : base(_controller,_type)
        {
            this.model = _model;
            View.AddType += View_AddType;
            View.DeleteType += View_DeleteType;
            
            
        }

        private void View_DeleteType(string obj)
        {            
            foreach (var item in View.allType)
            {
                if (item.Name == obj)
                {
                    model.DeleteType(item.Id);
                    break;
                }                
            }

        }

        private void View_AddType()
        {
            // this.model.SaveType(View.newType);
            System.Windows.Forms.MessageBox.Show(View.newType);

        }

        public override void Run()
        {
            View.allType = model.AllType();
            View.Show();
        }
    }
}
