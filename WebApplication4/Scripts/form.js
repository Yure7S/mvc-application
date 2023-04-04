const summary = document.querySelector(".summary")
const listaEnvolvidos = document.querySelector(".lista-envolvidos")
const create = document.querySelector(".create")
const dest = document.querySelector(".dest")
const voltar = document.querySelector(".voltar")
const avancar = document.querySelector(".avancar")
console.log("testando")

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
            break
        case 3:
            create.classList.replace("show", "hidden")
            summary.classList.replace("hidden", "show")
            avancar.classList.add("hidden")

            break
        default:
            alert("erro")
    }
}

function adicionar() {
    /* Adicionar envolvido */
    const nome = document.querySelector("#Envolvido_Nome")
    const funcao = document.querySelector("#Envolvido_Funcao")
    const empresa = document.querySelector("#Envolvido_Empresa")
    const listaEnvolvidos = document.querySelector(".lista-envolvidos")

    listaEnvolvidos.innerHTML += `<li><strong>${nome.value}</strong><strong>${funcao.value}</strong><strong>${empresa.value}</strong></li>`

}


