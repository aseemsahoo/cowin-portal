using Cowin_Portal.Accessibility;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Cowin_Portal.User_Dashboard_forms
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

        public async void initialize_state_dropdown(Guna2ComboBox state_comboBox)
        {
            ApiAccess db = new ApiAccess();
            state_list = await db.get_all_states();
            foreach (States s in state_list)
            {
                state_comboBox.Items.Add(s.name);
            }
        }
        public async void get_districts(Guna2ComboBox state_comboBox, Guna2ComboBox district_comboBox)
        {
            int index = state_comboBox.SelectedIndex;
            int state_id = state_list[index].id;

            ApiAccess db = new ApiAccess();
            district_list = await db.get_districts(state_id);

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

        public void vaccine_to_index(string vaccine, ref int vaccine_index)
        {
            if (vaccine == "Covishield")
                vaccine_index = 1;
            else
            if (vaccine == "Covaxin")
                vaccine_index = 2;
            else
                vaccine_index = 3;
        }

        public string get_vaccine_index_base(GroupBox vaccine_groupbox, ref int vaccine_index)
        {
            string vaccine = get_groupbox_radiobuttion(vaccine_groupbox);

            vaccine_to_index(vaccine, ref vaccine_index);
            return vaccine;
        }


        public async void load_DataGridView(Guna2ComboBox district_comboBox, DataGridView Centers_gridview, int vaccine_index, int age_limit)
        {
            int index = district_comboBox.SelectedIndex;
            int district_id = district_list[index].id;

            ApiAccess db = new ApiAccess();
            display = await db.search_center(district_id, vaccine_index, age_limit);

            Centers_gridview.DataSource = display;
            Centers_gridview.CurrentCell = null;

            Centers_gridview.Columns[0].Width = (int)(Centers_gridview.Width * 0.45);
            Centers_gridview.Columns[1].Width = (int)(Centers_gridview.Width * 0.4);
            Centers_gridview.Columns[2].Width = (int)(Centers_gridview.Width * 0.15);
        }

        private void Base_search_class_Load(object sender, EventArgs e)
        {

        }
    }
}
