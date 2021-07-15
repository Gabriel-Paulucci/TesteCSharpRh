const form = $("#form")
const nome = $("#nome")
const matricula = $("#matricula")

function salvar() {
    event.preventDefault();

    if (form.valid()) {

        const json = {
            nome: nome.val(),
            matricula: matricula.val()
        }

        console.log(json)

        $.post("/pessoas", json)
    }
}