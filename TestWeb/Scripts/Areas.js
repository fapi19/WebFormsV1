function showModalForm() {
    var modalForm = new bootstrap.Modal(document.getElementById('modalForm'));
    modalForm.toggle();
}     

function validarFormulario() {
    var nombre = document.getElementById("Body_TxtNombre").value;
    var ubicacion = document.getElementById("Body_TxtUbicacion").value;
    if (nombre == '' || ubicacion=='') {
        alert("Ingrese todos los campos");
        return false;
    }
    return true;
}