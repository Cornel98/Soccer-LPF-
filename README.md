# Soccer LPF ⚽

Această aplicație web a fost dezvoltată folosind **ASP.NET Core 7.0** și se concentrează pe gestionarea echipelor și jucătorilor dintr-o competiție de fotbal. Proiectul pune accent pe organizare, utilizând modele **DTO (Data Transfer Objects)** pentru manipularea datelor și asigură o conexiune sigură la baza de date SQL Server.

## Funcționalități principale 🚀

1. **Gestionarea echipelor și jucătorilor**:
   - Adăugarea, actualizarea și vizualizarea echipelor și a jucătorilor.
   - Detalii importante precum numele echipei, emblema, salariile jucătorilor și data de înființare a echipei.

2. **Conexiune la baza de date SQL Server**:
   - Utilizarea **Entity Framework Core** pentru conectarea la baza de date și manipularea datelor.
   - **Docker**: Baza de date SQL Server a fost containerizată folosind Docker pentru a asigura un mediu izolat și scalabil de dezvoltare și testare.
   - **Azure Data Studio**: După containerizarea bazei de date, am folosit Azure Data Studio pentru gestionarea și administrarea eficientă a datelor.

3. **Rute configurabile pentru controlere**:
   - API-uri RESTful pentru gestionarea echipelor și jucătorilor.

4. **Integrarea fișierelor statice**:
   - Suport pentru imagini ale echipelor și jucătorilor, care sunt încărcate și gestionate prin aplicație.

5. **Interfață utilizator (Frontend)**:
   - Aplicația utilizează **Bootstrap** pentru un design responsive și modern.
   - **JavaScript** pentru interactivitate și validarea formularelor.

## Tehnologii utilizate 🛠️

- **Backend**:
  - **ASP.NET Core 7.0**: Framework pentru dezvoltarea aplicațiilor web moderne.
  - **Entity Framework Core**: ORM (Object-Relational Mapper) pentru manipularea bazei de date.
  - **C#**: Limbajul de programare utilizat pentru dezvoltarea aplicației.

- **Baza de date**:
  - **SQL Server**: Sistemul de gestionare a bazelor de date utilizat pentru stocarea datelor despre echipe și jucători.
  - **Docker**: Utilizat pentru containerizarea SQL Server, asigurând un mediu de dezvoltare izolat și portabil.
  - **Azure Data Studio**: Folosit pentru administrarea bazei de date și vizualizarea datelor într-un mod eficient.

- **Frontend**:
  - **Bootstrap**: Framework CSS pentru un design modern și responsive.
  - **JavaScript**: Limbaj de programare pentru interactivitatea aplicației.

## Instrucțiuni de rulare locală 🔧

1. **Clonează acest repository**:
   Deschide un terminal și clonează repository-ul folosind comanda:
   ```bash
   git clone https://github.com/Cornel98/Soccer-LPF-Aplicatie-ASP.NET-.git
Configurează conexiunea la baza de date: Deschide fișierul appsettings.json și actualizează secțiunea de conexiune la baza de date cu detaliile serverului și ale bazei de date SQL Server. 

**Exemplu**:

json
"ConnectionStrings": {
  "DefaultConnection": "Server=localhost;Database=TeamAppDB;Trusted_Connection=True;"
}

Aplică migrațiile bazei de date (dacă este cazul): Asigură-te că ai aplicat migrațiile pentru a crea schema bazei de date:

bash

```dotnet ef database update```

Rulează aplicația: Poți rula aplicația fie folosind Visual Studio, fie folosind linia de comandă (CLI) .NET:

bash

```dotnet run```

**Aplicația va porni pe http://localhost:7254, iar interfața ar trebui să fie accesibilă în browser.**

**Roadmap și îmbunătățiri viitoare** 📈

**Autentificare și gestionarea utilizatorilor:** Adăugarea unui sistem de autentificare pentru administratori și utilizatori, cu roluri diferite.

**Dashboard de performanță:** Crearea unui dashboard pentru vizualizarea statisticilor echipelor și jucătorilor.

**Interfață Frontend:** Integrarea unui frontend interactiv folosind React sau Angular, completând funcționalitățile backend-ului.

**Contribuțiile sunt foarte apreciate!**
🙌
Dacă dorești să contribui la acest proiect, te rog să urmezi pașii de mai jos:

**Fă un fork al repository-ului.**

Creează o ramură nouă (git checkout -b feature-noua-functie).
Fă modificările dorite.
Adaugă, comitează și împinge modificările (git push origin feature-noua-functie).
Crează un pull request pentru a contribui cu modificările tale.

**Feedback și Întrebări** 💬
Dacă ai sugestii de îmbunătățiri sau întrebări despre proiect, nu ezita să deschizi un Issue sau să creezi un Pull Request!

## Contact 📧
LinkedIn: [Cornel Ciocan](https://www.linkedin.com/in/cornel-ciocan-0b9917311/)

 Mulțumesc pentru interesul acordat proiectului meu!🎉
