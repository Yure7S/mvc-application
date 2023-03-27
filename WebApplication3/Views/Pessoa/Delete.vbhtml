@ModelType WebApplication3.Pessoa
@Code
    ViewData("Title") = "Delete"
End Code

<div>
    <div>
        <label>Nome</label>
        @Html.DisplayFor(Function(model) model.Nome)
        <label>Nome</label>
        @Html.DisplayFor(Function(model) model.Sobrenome)
        <label>Nome</label>
        @Html.DisplayFor(Function(model) model.Idade)

        @Using (Html.BeginForm())
            @<button type="submit" >Deletar</button>
        End Using
    </div>


</div>
