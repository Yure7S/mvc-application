using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;


public class Denuncia
{
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Key]
    public Guid Id { get; set; }

    [ForeignKey("UsuarioId")]
    public Usuario Usuario { get; set; }
    public Guid UsuarioId { get; set; }

    [Required(ErrorMessage = "Campo obrigatório")]
    public string OrgaoDestino { get; set; }

    [Required(ErrorMessage = "Campo obrigatório")]
    public string Assunto { get; set; }

    [Required(ErrorMessage = "Campo obrigatório")]
    public string OrgaoAssunto { get; set; }

    [Required(ErrorMessage = "Campo obrigatório")]
    public string Descricao { get; set; }

    [Required(ErrorMessage = "Campo obrigatório")]
    public string Uf { get; set; }

    [Required(ErrorMessage = "Campo obrigatório")]
    public string Municipio { get; set; }

    [Required(ErrorMessage = "Campo obrigatório")]
    public string Local { get; set; }

    [Required()]
    public DateTime DataPostagem { get; set; }

    public Denuncia()
    {
        DataPostagem = DateTime.Now;
    }
}
