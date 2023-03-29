@ModelType WebApplication3.Denuncia
@Code
    ViewData("Title") = "Destinatario"
End Code

<section class="container-sm justify-content-center mt-n1">
    <h2></h2>

    <div class="form-container">
        @Using (Html.BeginForm())

            @<div>

                <div class="dest show form-boot">
                    <label>Órgão para o qual você quer enviar sua manifestação*</label>
                    @Html.DropDownListFor(Function(model) model.Descricao, New SelectList({"testando"}))
                    <label>Sobre qual assunto você quer falar</label>
                    @Html.DropDownListFor(Function(model) model.Descricao, New SelectList({"testando"}))
                    <label>Sobre qual órgão você quer falar</label>
                    @Html.DropDownListFor(Function(model) model.Descricao, New SelectList({"testando"}))
                </div>

                <div class="create hidden form-boot">

                    <label>Descrição dos atos ou fatos*</label>
                    @Html.EditorFor(Function(model) model.Descricao)
                    <label>Seu email*</label>
                    @Html.EditorFor(Function(model) model.Descricao)

                    <div class="local-do-fato d-flex" flex>
                        <h3>Local do fato</h3>
                        <div>
                            <label>UF</label>
                            @Html.EditorFor(Function(model) model.Descricao)
                        </div>
                        <div>
                            <label>Município</label>
                            @Html.EditorFor(Function(model) model.Descricao)
                        </div>
                        <div>
                            <label>Local</label>
                            @Html.EditorFor(Function(model) model.Descricao)
                        </div>
                    </div>

                    <div class="envolvidos">
                        <h3>Quais são os envolvidos do fato</h3>
                        <label>Nome do envolvido</label>
                        @Html.EditorFor(Function(model) model.Descricao)
                        <label>Função do envolvido</label>
                        @Html.EditorFor(Function(model) model.Descricao)
                        <label>Órgão/Empresa</label>
                        @Html.EditorFor(Function(model) model.Descricao)
                    </div>

                </div>

                <div style="display: none;" class="summary hidden">
                    <p>Minha página final</p>
                    <button type="submit">Avançar</button>
                </div>

            </div>

        End Using

        <div class="buttons d-flex">
            <button onclick="slide(-1)" class="voltar btn btn-secondary">&lt;&lt; Voltar</button>
            <button onclick="slide(1)" class="avancar btn btn-primary">Avançar &gt;&gt;</button>
        </div>
    </div>

</section>



<script src="../../Scripts/form.js"></script>





