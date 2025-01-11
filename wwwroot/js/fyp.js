function afisPagina1fyp() {
    document.getElementById('PostariPageFYP').style.display = 'flex';
    document.getElementById('ThreadPageFYP').style.display = 'none';
}
function afisPagina3fyp() {
    document.getElementById('PostariPageFYP').style.display = 'none';
    document.getElementById('ThreadPageFYP').style.display = 'flex';
}
function CommentBox(event, id) {
    if (event != null) {
        event.preventDefault();
    }
    document.querySelectorAll('[id^="CommentBox-"]').forEach(element => {
        element.style.display = 'none';
    });

    const Box = document.getElementById("CommentBox-" + id);
    Box.style.display = 'flex';
    Box.scrollIntoView({
        behavior: "smooth",
        block: "center",
        inline: "nearest"
    });
    const th = document.getElementsByClassName("thread-" + id);
    const text = th[0].querySelector("#ThreadContinut");
    const BoxText = Box.querySelector("#ComBoxContinut");
    const paragraf = BoxText.querySelector("#continut");
    const nume = th[0].querySelector(".profile-name");
    paragraf.innerHTML = text.innerHTML;
    const poza = th[0].querySelector(".profile-picture");
    const BoxPoza = BoxText.querySelector("#comImg");
    BoxPoza.setAttribute("src", poza.getAttribute("src"));
    BoxText.querySelector("#username").innerHTML = nume.innerHTML;
    BoxText.querySelector("#ComOra").innerHTML = th[0].querySelector("#ora").innerHTML;
}
function arataPostareDetaliata(id) {
    document.querySelectorAll('[id^="PostareDetaliata-"]').forEach(element => {
        element.style.display = 'none';
    });

    document.getElementById("PostareDetaliata-" + id).style.display = "flex";
    document.getElementById("PostareDetaliata-" + id).scrollIntoView({
        behavior: "smooth",
        block: "center"
    });
}