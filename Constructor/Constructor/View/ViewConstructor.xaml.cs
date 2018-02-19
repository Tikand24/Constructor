using Constructor.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Constructor.View
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ViewConstructor : ContentPage
	{

		public ViewConstructor ()
		{
			InitializeComponent ();
            this.BindingContext = new Class1();
            Class1 data=new Class1();
            foreach (var bloque in data.ListadoBloque)
            {
                System.Diagnostics.Debug.WriteLine("Nombre del bloque");
                System.Diagnostics.Debug.WriteLine(bloque.Nombre);
                foreach (var pregunta in bloque.Preguntas)
                {
                    System.Diagnostics.Debug.WriteLine("Nombre de la pregunta");
                    System.Diagnostics.Debug.WriteLine(pregunta.Nombre);
                    System.Diagnostics.Debug.WriteLine("Tipo de pregunta");
                    System.Diagnostics.Debug.WriteLine(pregunta.Tipo);
                    foreach (var respuestas in pregunta.Respuestas)
                    {
                        System.Diagnostics.Debug.WriteLine("Respuesta");
                        System.Diagnostics.Debug.WriteLine(respuestas.Nombre);
                    }
                }
            }
        }
    }
}