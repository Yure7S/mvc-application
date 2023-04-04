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

    [EmailAddress(ErrorMessage = "O email informado no campo não é válido")]
    [Required(ErrorMessage = "Email inválido")]
    [Index(IsUnique = true)]
    [StringLength(128)]
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

    public bool SenhaValida(string senha)
    {
        return Senha == senha;
    }
}
