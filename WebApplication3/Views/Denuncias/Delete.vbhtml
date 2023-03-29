@ModelType WebApplication3.Denuncia
@Code
    ViewData("Title") = "Delete"
End Code

<div>
    <div>
        <label>Nome</label>
        @Html.DisplayFor(Function(model) model.Descricao)
        <label>Nome</label>
        @Html.DisplayFor(Function(model) model.Descricao)
        <label>Nome</label>
        @Html.DisplayFor(Function(model) model.Descricao)

        @Using (Html.BeginForm())
            @<button type="submit" >Deletar</button>
        End Using
    </div>


</div>
