﻿using System;
using System.Collections.Generic;
using System.Text;

namespace LibreriaRDCifrado
{
    interface IEncriptador
    {
        public string Cipher(string mensaje, string clave);

        public string Decipher(string mensaje, string clave);

        public string[] GenerarLlave(string llave, int[] P10, int[] P8);
    }
}
