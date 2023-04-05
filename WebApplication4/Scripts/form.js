const summary = document.querySelector(".summary")
const create = document.querySelector(".create")
const dest = document.querySelector(".dest")
const voltar = document.querySelector(".voltar")
const avancar = document.querySelector(".avancar")
const enviar = document.querySelector(".enviar")

let count = 1
function slide(i, e) {

    count += i
    console.log(count)
    switch (count) {
        case 0:
            window.location.href = "/";
            break
        case 1:
            dest.classList.replace("hidden", "show")
            create.classList.replace("show", "hidden")
            break
        case 2:
            dest.classList.replace("show", "hidden");
            create.classList.replace("hidden", "show")
            avancar.classList.remove("hidden")
            summary.classList.replace("show", "hidden")
            enviar.classList.replace("show", "hidden")
            break
        case 3:
            create.classList.replace("show", "hidden")
            summary.classList.replace("hidden", "show")
            avancar.classList.add("hidden")
            enviar.classList.replace("hidden", "show")
            break
        default:
            alert("erro")
    }
}

/* Adicionar envolvido */
const grupoEnvolvidos = document.querySelector(".grupo-envolvidos")
const campos = Array.from(document.querySelectorAll(".envolvidos input"))
const listaEnvolvidos = document.querySelector(".lista-envolvidos")
const btnAdd = document.querySelector(".btn-add-envolvido")
const btnDelete = document.querySelector("li div .excluir-envolvido")

btnAdd.addEventListener("click", () => {
    listaEnvolvidos.innerHTML += `<li><div class="item"><span>${campos[0].value}</span></div><div class="item"><span>${campos[1].value}</span></div><div class="item"><span>${campos[2].value}</span></div><button class="excluir-envolvido">Excluir</button></li>`
    grupoEnvolvidos.classList.replace("hidden", "show")
    for (let item of campos) {
        item.value = ""
    }
})

const validarForm = () => {
    for (let item of campos) {
        item.value != "" ? true : false
    }
}

document.addEventListener("click", (e) => {
    e = e.target

    if (e.classList.contains("excluir-envolvido")) {
        e.parentElement.remove()
    }
})