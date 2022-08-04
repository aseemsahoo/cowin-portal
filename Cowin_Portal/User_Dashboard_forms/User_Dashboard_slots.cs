using System;

namespace Cowin_Portal.User_Dashboard_forms
{
    public partial class User_Dashboard_slots : Base_search_class
    {
        public User_Dashboard_slots()
        {
            InitializeComponent();
            initialize_state_dropdown(state_comboBox);
        }
        internal string display_text()
        {
            return "Search for a vaccination center";
        }

        private void state_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            get_districts(state_comboBox, district_comboBox);
        }

        private bool validate_controls()
        {
            errorProvider_slots.Clear();
            if (state_comboBox.SelectedIndex <= -1)
            {
                errorProvider_slots.SetError(this.state_comboBox, "Please select a state");
                return false;
            }
            if (district_comboBox.SelectedIndex <= -1)
            {
                errorProvider_slots.SetError(this.district_comboBox, "Please select a district");
                return false;
            }
            if (get_groupbox_radiobuttion(vaccine_groupbox) == "")
            {
                errorProvider_slots.SetError(this.vaccine_groupbox, "Please select a vaccine");
                return false;
            }
            return true;
        }

        private void get_vaccine_index(ref int vaccine_index)
        {
            get_vaccine_index_base(vaccine_groupbox, ref vaccine_index);
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            if (validate_controls() == false)
                return;

            int age_limit = Convert.ToInt32(get_groupbox_radiobuttion(age_groupbox).Substring(0, 2));
            int vaccine_index = 0;
            get_vaccine_index(ref vaccine_index);

            load_DataGridView(district_comboBox, Centers_gridview, vaccine_index, age_limit);
        }
    }
}