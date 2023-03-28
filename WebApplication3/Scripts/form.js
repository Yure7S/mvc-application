const summary = document.querySelector(".summary")
const create = document.querySelector(".create")
const dest = document.querySelector(".dest")
const voltar = document.querySelector(".voltar")
const avancar = document.querySelector(".avancar")
console.log("testando")

let count = 1
function slide(i){
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

//slide()

//document.addEventListener("click", (event) => {
//    let el = event.target
//    let cont = 0

//    if (el.classList.contains("avancar")){
//        create.style.display = "block"
//        dest.style.display = "none"

//    }

//})

//avancar.addeventlistener("click", () => {
//    create.style.display = "block"
//    dest.style.display = "none"
//    cont = 1
//    init = false
//})

//voltar.addeventlistener("click", () => {
//    create.style.display = "none"
//    dest.style.display = "block"
//    cont = 2
//})

