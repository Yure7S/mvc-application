@ModelType WebApplication3.Denuncia
@Code
    ViewData("Title") = "Criar Pessoa"
End Code

@Using (Html.BeginForm())

    @<form>
         <div>
             <label>Nome</label>
             @Html.EditorFor(Function(model) model.Descricao)
         </div>
        <div>
            <label>Sobrenome</label>
             @Html.EditorFor(Function(model) model.Descricao)
         </div>
        <div>
             <label>Idade</label>
             @Html.EditorFor(Function(model) model.Descricao)
         </div>
   
        <button type="submit" >Submit</button>
    </form>



End Using
