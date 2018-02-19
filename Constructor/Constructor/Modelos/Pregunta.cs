using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace Constructor.Modelos
{
    public class Pregunta
    {
        private string nombre;
        private ObservableCollection<Respuesta> respuestas;
        private string tipo;

        public string Nombre { get => nombre; set => nombre = value; }
        public string Tipo { get => tipo; set => tipo = value; }
        public ObservableCollection<Respuesta> Respuestas { get => respuestas; set => respuestas = value; }
    }
}
