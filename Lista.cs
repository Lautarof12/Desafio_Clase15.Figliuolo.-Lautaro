﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1__Electrodomesticos
{
    class Lista
    {
        List<Imostrar> listado = new List<Imostrar>();

        public void mostrartodo()
        {
            foreach(Imostrar c in listado)
            {
                c.mostrar();
            }
        }
        public void agregar(Imostrar unImostrar)
        {
            listado.Add(unImostrar);
        }

    }
}



    

