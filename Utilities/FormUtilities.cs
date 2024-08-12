namespace GobData.Utilities
{
    public static class FormUtilities
    {
        public static bool ValidarTextBox(Control parent)
        {
            bool allFilled = true;

            foreach (Control control in parent.Controls)
            {
                if (control is TextBox txtBox)
                {
                    if (String.IsNullOrWhiteSpace(txtBox.Text))
                    {
                        allFilled = false;
                        break;
                    }
                }
            }

            return allFilled;
        }

        public static bool ValidarComboBox(Control parent)
        {
            bool allSelected = true;

            foreach (Control control in parent.Controls)
            {
                if (control is ComboBox comboBox)
                {
                    if (comboBox.SelectedIndex == -1)
                    {
                        allSelected = false;
                        break;
                    }
                }
            }

            return allSelected;
        }

        public static void LimpiarTextBox(Control parent)
        {
            foreach (Control control in parent.Controls)
            {
                if (control is TextBox txtBox)
                {
                    txtBox.Clear();
                }
            }
        }
    }
}
