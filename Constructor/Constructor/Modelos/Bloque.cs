using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace Constructor.Modelos
{
    public class Bloque
    {
        //bloque
        private string nombre;
        private ObservableCollection<Pregunta> preguntas;

        public string Nombre { get => nombre; set => nombre = value; }
        public ObservableCollection<Pregunta> Preguntas { get => preguntas; set => preguntas = value; }
    }
}
