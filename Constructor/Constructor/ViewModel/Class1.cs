using Constructor.Modelos;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace Constructor.ViewModel
{
    public class Class1
    {
        private ObservableCollection<Bloque> listadoBloque;
        private ObservableCollection<Pregunta> listadoPregunta;
        private ObservableCollection<Respuesta> listadoRespuestas;

        public ObservableCollection<Bloque> ListadoBloque {
            get {
                if (listadoBloque==null)
                {
                    llenarDatos();
                }
                return listadoBloque;
            }
            set => listadoBloque = value;
        }

        public void llenarDatos()
        {
            ObservableCollection<Bloque> data = new ObservableCollection<Bloque>();
            for (int i = 0; i < 5; i++)
            {

                data.Add(new Bloque()
                {
                    Nombre = "Bloque "+i,
                    Preguntas = null
                });
            }
            foreach (var item in data)
            {
                ObservableCollection<Pregunta> pregunta = new ObservableCollection<Pregunta>();
                for (int i = 0; i < 2; i++)
                {
                    pregunta.Add(new Pregunta()
                    {
                        Nombre = "Pregunta "+i,
                        Tipo = "Select",
                        Respuestas = null
                    });
                }
                item.Preguntas = pregunta;
            }
            foreach (var item in data)
            {
                foreach (var item2 in item.Preguntas)
                {
                    ObservableCollection<Respuesta> respuesta = new ObservableCollection<Respuesta>();
                    for (int i = 0; i < 4; i++)
                    {
                        respuesta.Add(new Respuesta()
                        {
                            Nombre = "Respuesta "+i
                        });
                    }
                    item2.Respuestas = respuesta;
                }
            }
            listadoBloque = data;
        }
    }
}
