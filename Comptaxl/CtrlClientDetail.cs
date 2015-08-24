using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;



//http://public.opendatasoft.com/explore/dataset/correspondance-code-insee-code-postal/?tab=export

namespace Comptaxl
{
    public partial class CtrlClientDetail : UserControl
    {
       public BindingSource ClientBindingSource
        {
            get { return c_ClientBindingSource; }
            set
            {
                c_ClientBindingSource.PositionChanged -=c_ClientBindingSource_PositionChanged;
                foreach (Control item in this.tableLayoutPanel1.Controls)
                {
                    if (item != null && item.DataBindings!=null && item.DataBindings.Count>0)
                    {
                        Binding tmp = new Binding(item.DataBindings[0].PropertyName, value, item.DataBindings[0].BindingMemberInfo.BindingMember, item.DataBindings[0].FormattingEnabled, item.DataBindings[0].DataSourceUpdateMode, item.DataBindings[0].NullValue);
                        item.DataBindings.Clear();
                        item.DataBindings.Add(tmp);
                    }
                }
                c_ClientBindingSource = value;
                c_ClientBindingSource.PositionChanged += c_ClientBindingSource_PositionChanged;
                //this.phoneListBindingSource.DataSource = this.c_ClientBindingSource;
                //c_ClientBindingSource.ResetBindings(false);
            }
        }

       
       public BindingSource PhoneTypeBindingSource
       {
           get { return cPhoneTypeBindingSource; }
           set
           {
               cPhoneTypeBindingSource = value;
               this.phoneTypeDataGridViewTextBoxColumn.DataSource = this.cPhoneTypeBindingSource;
           }
       }
        public CtrlClientDetail()
        {
            InitializeComponent();
            
        }

        private void c_ClientBindingSource_PositionChanged(object sender, EventArgs e)
        {
            phoneListBindingSource.DataSource = c_ClientBindingSource.Current != null ? ((ComptaxlData.C_Client)c_ClientBindingSource.Current).PhoneList : new List<ComptaxlData.C_Phone>();
        }

       

        private void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        private void personNameTextBox_TextChanged(object sender, EventArgs e)
        {
            
        }


        
    }
}
