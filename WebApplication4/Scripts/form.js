const summary = document.querySelector(".summary")
const create = document.querySelector(".create")
const dest = document.querySelector(".dest")
const voltar = document.querySelector(".voltar")
const avancar = document.querySelector(".avancar")
console.log("testando")

/* Fluxo de formulários */
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

document.addEventListener("click", (e) => {
    e = e.target
    e.preventDefault
})

/* Definição do resumo */


