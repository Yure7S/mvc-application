@ModelType WebApplication3.Pessoa
@Code
    ViewData("Title") = "Destinatario"
End Code
@Using (Html.BeginForm())

    @<div>

        <div class="dest show">
            <label>Nome do Òrgão*</label>
            @Html.DropDownListFor(Function(model) model.Nome, New SelectList({Model.Nome, Model.Nome.FUBF, Model.Nome.EWRR}))

            <div>
                <label>Assunto*</label>
                @Html.DropDownListFor(Function(model) model.Nome, New SelectList({Model.Nome, Model.Nome.FUBF, Model.Nome.EWRR}))
            </div>
            <div>
                <label>Sobre qual òrgão você quer falar*</label>
                @Html.DropDownListFor(Function(model) model.Nome, New SelectList({Model.Nome, Model.Nome.FUBF, Model.Nome.EWRR}))
            </div>
        </div>


        <div class="create hidden">
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
            <button type="submit">Avançar</button>
        </div>

        <div style="display: none;" class="summary hidden">
            <p>Minha página final</p>
        </div>

    </div>

End Using

<button onclick="slide(-1)" class="voltar btn btn-secondary">voltar</button>
<button onclick="slide(1)" class="avancar btn btn-primary">Avançar</button>

<script src="../../Scripts/form.js"></script>





