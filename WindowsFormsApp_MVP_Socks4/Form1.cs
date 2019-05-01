using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp_MVP_Socks4.View;
using WindowsFormsApp_MVP_Socks4.Model;
using WindowsFormsApp_MVP_Socks4.SocksServise;

namespace WindowsFormsApp_MVP_Socks4
{
    public partial class Form1 : Form, IViewType
    {
        private readonly ApplicationContext context;
        public Form1()
        {
            InitializeComponent();
          //  this.context = _context;
            Load += Form1_Load;
        }

        private void Form1_Load(object sender, EventArgs e)
         {
            foreach (TypeModel item in allType)
            {
                if(item.Name!=null)
                comboBox1.Items.Add(item.Name);
            }
            textBox1.DataBindings.Add("Text", this, "newType");
        }

        public BindingList<TypeModel> allType { set; get; }
        public string newType { set; get; }

        public event Action<string> DeleteType;
        public event Action AddType;

        void IView.Closed()
        {
            throw new NotImplementedException();
        }

        public new void Show()
        {
            //context.MainForm = this;           
            Application.Run(new ApplicationContext(this));            
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(AddType!=null)
            {
                AddType();
            }   
        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            newType = comboBox1.SelectedItem.ToString();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (DeleteType != null)
                DeleteType(comboBox1.SelectedItem.ToString());
        }

       
    }
}
