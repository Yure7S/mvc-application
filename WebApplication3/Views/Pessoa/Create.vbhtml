@ModelType WebApplication3.Pessoa
@Code
    ViewData("Title") = "Criar Pessoa"
End Code

@Using (Html.BeginForm())

    @<form>
         <div>
             <label>Nome</label>
             @Html.EditorFor(Function(model) model.Nome)
         </div>
        <div>
            <label>Sobrenome</label>
             @Html.EditorFor(Function(model) model.Sobrenome)
         </div>
        <div>
             <label>Idade</label>
             @Html.EditorFor(Function(model) model.Idade)
         </div>
   
        <button type="submit" >Submit</button>
    </form>



End Using
