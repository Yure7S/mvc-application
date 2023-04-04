using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;



    public class Envolvido
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id{ get; set; }

        [ForeignKey("DenunciaId")]
        public Denuncia Denuncia { get; set; }
        public Guid DenunciaId { get; set; }

        public string Nome { get; set; }

        public string Funcao{ get; set; }

        public string Empresa { get; set; }

    

    }
