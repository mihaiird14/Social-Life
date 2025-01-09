function arataPostareDetaliataArhiva(id) {
    window.scrollTo({ top: 0, behavior: 'smooth' });
    document.getElementById("PostareDetaliata-" + id).style.display = "flex";
    document.getElementById("pozaDT-" + id).src = document.getElementById("img-" + id).src;
    document.getElementById("descrierePostare-" + id).style.width = document.getElementById("pozaDT-" + id).scrollWidth + "px";
    if (document.getElementById("pozaDT-" + id).scrollWidth < 250) {
        document.getElementById("descrierePostare-" + id).style.width = 250 + "px";
    }
    document.getElementById("descReal-" + id).innerHTML = document.getElementById("descAscuns-" + id).innerHTML;
    document.getElementById("PostareDetaliata-" + id).style.marginTop = 1+ "vh";
}
function openConfirmareStergerePostareArhiva(id) {
    xPostareDeschisa(id);
    document.getElementById("ConfirmareSArhiva-" + id).style.display = "flex";
    window.scrollTo({ top: 0, behavior: 'smooth' });
}
function inchideConfirmaStergerePostareArhiva(id) {
    document.getElementById("ConfirmareSArhiva-" + id).style.display = "none";
}