﻿using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;


public class DenunciaViewModel
{
    public Denuncia Denuncia { get; set; }

    public Envolvido Envolvido { get; set; }
 
}
