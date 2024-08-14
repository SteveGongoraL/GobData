namespace GobData.Utilities
{
    public static class FormUtilities
    {
        // Validar que todos los textbox esten llenos
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

        // Verficar que los combobox tengan un valor seleccionado
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

        // Limpiar los textbox
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

        // Ocultar la primera columna de un data grid view
        public static void OcultarPrimeraColumna(DataGridView dgv)
        {
            if (dgv.Columns.Count > 0)
            {
                dgv.Columns[0].Visible = false;
            }
        }
    }
}
