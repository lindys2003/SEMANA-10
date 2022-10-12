﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRÁCTICA__SEMANA_10.BLL
{
    public class SedesBLL
    {
        private int id;
        private string nombre;
        private string ubicacion;

        public SedesBLL(int id)
        {
            this.id = id;
        }

        public SedesBLL(int id, string nombre, string ubicacion)
        {
            this.id = id;
            this.nombre = nombre;
            this.ubicacion = ubicacion;
        }

        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Ubicacion { get => ubicacion; set => ubicacion = value; }
    }
}

