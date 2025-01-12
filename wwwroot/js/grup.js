function afisFormGrup() {
    document.getElementById('formAddGrup').style.display = "flex";
}
function xAddGrup() {
    document.getElementById('formAddGrup').style.display = "none";
}
function StergePoza() {
    const imagePreview = document.getElementById('pozaGr');
    imagePreview.src = '/imagini/grupDefault.png';
}
function afisMembrii() {
    document.getElementById("listaMembriiGrup").style.display = "flex";
    document.getElementById("alaturateGrup").style.display = "none";
    GrFormPostClose()
    document.getElementById("AddGrPost").style.display = "none";
    document.getElementById("ListaPostari").style.display = "none";
    sessionStorage.setItem("LGM", "da");
}
function xListaMembrii() {
    document.getElementById("listaMembriiGrup").style.display = "none";
    document.getElementById("alaturateGrup").style.display = "block";
    document.getElementById("AddGrPost").style.display = "block";
    document.getElementById("ListaPostari").style.display = "flex";
    sessionStorage.setItem("LGM", "nu");
}
function afisFormGrPost() {
    document.getElementById("FormAddGrPost").style.display = "flex";
    xListaMembrii();
}
function GrFormPostClose() {
    document.getElementById("FormAddGrPost").style.display = "none";
}
document.addEventListener("DOMContentLoaded", function () {
    const activeSection = sessionStorage.getItem('LGM');
    if (activeSection === 'da') {
        afisMembrii();
    }
    else {
        xListaMembrii();
    }
});
function openMenuPostGr(id) {
    if (document.getElementById("dropdownMenuPostGr-" + id).style.display === "none") {
        document.getElementById("dropdownMenuPostGr-" + id).style.display = "block";
    }
    else {
        document.getElementById("dropdownMenuPostGr-" + id).style.display = "none";
    }
}
function DeletePostGr(id) {

    document.querySelector(".deletePostGr-" + id).style.display = "flex";

    document.querySelector(".postareGr-" + id).style.display = "none";
   
}
function xDeletePostGr(id) {
    document.querySelector(".deletePostGr-" + id).style.display = "none";

    document.querySelector(".postareGr-" + id).style.display = "flex";
}
function EditPostGr(id) {
    document.querySelector(".editPostGr-" + id).style.display = "flex";

    document.querySelector(".postareGr-" + id).style.display = "none";
}