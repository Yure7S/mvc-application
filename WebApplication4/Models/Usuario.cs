using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

public class Usuario
{
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Key]
    public Guid Id { get; set; }

    [Required(ErrorMessage = "Campo obrigatório")]
    public string Nome { get; set; }

    [EmailAddress]
    [Required(ErrorMessage = "Email inválido")]
    public string Email { get; set; }

    [Required(ErrorMessage = "Senha inválida")]
    [MinLength(8, ErrorMessage = "Sua senha precisa conter no mínimo 8 caracteres")]
    public string Senha { get; set; }

    [Required()]
    public DateTime DataCadastro { get; set; }

    public Usuario()
    {
        DataCadastro = DateTime.Now;
    }
}
