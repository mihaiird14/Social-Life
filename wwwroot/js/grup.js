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