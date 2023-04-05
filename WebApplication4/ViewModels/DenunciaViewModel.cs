using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;


public class DenunciaViewModel
{
    public Denuncia Denuncia { get; set; }

    public Envolvido Envolvido { get; set; }

    // public List<DenunciaViewModel> ListaEnvolvidos = new List<DenunciaViewModel>();

}
