#  Social Life 

**SocialLife** este o rețea socială modernă construită în ASP.NET Core, care permite utilizatorilor să comunice prin postări, thread-uri și grupuri, oferind un control avansat asupra intimității și interacțiunilor.

---

## Funcționalități Principale

### Management Profil și Confidențialitate
* **Profil Personalizabil**: Utilizatorii își pot edita bio-ul, poza de profil și detaliile personale (nume, prenume, data nașterii).
* **Sistem Public/Privat**: Utilizatorii își pot seta profilul ca privat. Conturile private sunt marcate cu un simbol specific, iar postările lor pot fi văzute doar de urmăritori.
* **Follow/Unfollow**: Sistem complet de urmărire, inclusiv gestionarea cererilor de follow pentru conturi private și liste de urmăritori/urmăriri.

> 

### Postări și Thread-uri
* **Postări Multimedia**: Încărcare de imagini cu descrieri, suport pentru arhivare și sistem de like-uri/comentarii.
* **Threads**: Secțiune pentru mesaje rapide, cu posibilitatea de a integra videoclipuri de pe YouTube.
* **Interacțiune fără Refresh**: Like-urile și secțiunile de comentarii utilizează Fetch API pentru o experiență fluidă.
* **Validări**: Toate intrările de text (bio, thread-uri, comentarii) sunt validate pentru lungime (ex: 5-100 caractere).

### Grupuri și Socializare
* **Grupuri Publice și Private**: Utilizatorii pot crea, căuta și adera la grupuri. Grupurile private necesită aprobarea unei cereri de aderare.
* **Feed Personalizat**: Pagina "For You" oferă un flux de conținut pentru descoperirea de noi utilizatori și postări.
* **Căutare**: Funcție de căutare globală pentru utilizatori și grupuri.

### Notificări și Administrare
* **Sistem de Notificări**: Alerte pentru like-uri, comentarii noi, urmăritori noi sau cereri de follow.
* **Rol de Administrator**: Administratorii platformei pot modera orice conținut (ștergere postări/thread-uri/grupuri) și pot vizualiza orice profil, indiferent de setările de confidențialitate.

---

## Tehnologii Utilizate

* **Backend**: ASP.NET Core MVC (C#)
* **Baza de Date**: SQL Server
* **Frontend**: JavaScript, CSS, HTML
* **Stocare**: SessionStorage pentru persistența meniurilor deschise la navigare.

---
