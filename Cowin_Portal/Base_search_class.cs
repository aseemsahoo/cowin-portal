using System.Collections.Generic;
using System.Windows.Forms;
using Guna.UI2.WinForms;

namespace Cowin_Portal
{
    public partial class Base_search_class : Form
    {
        public List<Hospital> display = new List<Hospital>();
        public List<States> state_list = new List<States>();
        public List<Districts> district_list = new List<Districts>();

        public Base_search_class()
        {
            InitializeComponent();
        }

        public void initialize_state_dropdown(Guna2ComboBox state_comboBox)
        {
            DataAccess db = new DataAccess();
            state_list = db.get_all_states();
            foreach (States s in state_list)
            {
                state_comboBox.Items.Add(s.name);
            }
        }
        public void get_districts(Guna2ComboBox state_comboBox, Guna2ComboBox district_comboBox)
        {
            int index = state_comboBox.SelectedIndex;
            int state_id = state_list[index].id;

            DataAccess db = new DataAccess();
            district_list = db.get_districts(state_id);

            district_comboBox.Items.Clear();
            district_comboBox.SelectedIndex = -1;
            district_comboBox.Text = "";
            foreach (Districts d in district_list)
            {
                district_comboBox.Items.Add(d.name);
            }
        }
        public string get_groupbox_radiobuttion(GroupBox groupbox)
        {
            string res = "";
            foreach (RadioButton r in groupbox.Controls)
            {
                if (r.Checked)
                    res = r.Text;
            }
            return res;
        }

        public string get_vaccine_index_base(GroupBox vaccine_groupbox, ref int vaccine_index)
        {
            string vaccine = get_groupbox_radiobuttion(vaccine_groupbox);

            if (vaccine == "Covishield")
                vaccine_index = 1;
            else
            if (vaccine == "Covaxin")
                vaccine_index = 2;
            else
                vaccine_index = 3;
            return vaccine;
        }

        public void load_DataGridView(Guna2ComboBox district_comboBox, DataGridView Centers_gridview, ref int vaccine_index, ref int age_limit)
        {
            int index = district_comboBox.SelectedIndex;
            int district_id = district_list[index].id;

            DataAccess db = new DataAccess();
            display = db.search_center(district_id, vaccine_index, age_limit);

            Centers_gridview.DataSource = display;
            Centers_gridview.CurrentCell = null;

            Centers_gridview.Columns[0].Width = (int)(Centers_gridview.Width * 0.45);
            Centers_gridview.Columns[1].Width = (int)(Centers_gridview.Width * 0.4);
            Centers_gridview.Columns[2].Width = (int)(Centers_gridview.Width * 0.15);
        }
    }
}
