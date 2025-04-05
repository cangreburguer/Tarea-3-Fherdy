using System;
using System.Windows.Forms;

public class BotonCerrar
{
    private Form form;

    // Constructor que recibe el formulario
    public BotonCerrar(Form form)
    {
        this.form = form;
    }

    // Método para cerrar el formulario
    public void CerrarFormulario(object sender, EventArgs e)
    {
        form.Close();
    }
}
