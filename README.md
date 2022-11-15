# 🌵 PiantApp
<!--Hai mai voluto--> 
PiantApp è un'applicazione che consente agli utenti di condividere conoscenze e parlare di piante. Ogni utente può condividere informazioni sulle piante che ha piantato, vedere le piante dei propri amici e moltre altre funzioni

## ✨ Funzionamento
Per utilizzare il programma esegui il server e fai partire il servizio premendo il pulsante apposito. Successivamente esegui i client ed effettua il login.
Una volta aperto il client ed effettuato l'accesso verrà mostrato nella home un post; puoi mettere mi piace, commentare, visitare il profilo dell'utente che ha postato oppure passare al prossimo post. In questo modo, verrà mostrato un post per volta.
Tramite i tasti laterali si può passare alle sezioni:
  - Home
  - Cerca utente
  - Ultimi "mi piace"
  - Logout

## ⚙️ Architettura
### ⌨️ Architettura client-server
 - Server (uno): accettare le richieste dei client e risponde con le informazioni richieste
 - Client (da uno a n): richiedere informazioni al server
### 🗃️ Basi di dati
 - /json/users.json contiene gli utenti registrati
 - /json/posts.json contiene i post

## 🔎 Analisi casi d'uso 

### Utenti
| ID Utente | Nome utente        | Descrizione                                                                          |
| --------- | ------------------ | ------------------------------------------------------------------------------------ |
| U1        | Utente non loggato | Utente che non ha effettuato il login a cui viene richiesto di autenticarsi          |
| U2        | Utente loggato     | Utente che ha effettuato l'accesso e che quindi può richiedere tutte le funzionalità |
| U3        | Admin              | Utenti con privilegi superiori, per controllare/eliminare i contenuti                |

### Funzionalità
| ID Funzionalità | Nome sintetico        | Utenti interessati | Descrizione                                                                        |
| --------------- | --------------------- | ------------------ | ---------------------------------------------------------------------------------- |
| F1              | Login e registrazione | U1                 | L'utente deve inserire username e password per procedere                           |
| F2              | Visualizzare post     | U2, U3             | Nella home dell'utente, deve essere presente un post                               |
| F3              | Pubblicare contenuti  | U2                 | L'utente può essere in grado di pubblicare un post                                 |
| F4              | Cerca utenti          | U2, U3             | L'utente può cercare altri utenti per vedere i loro contenuti tramite il nickname  |
| F5              | Interagire con i post | U2, U3             | Mi piace, condividere, commentare...                                               |

## 💻 Protocollo
| ID Funzionalità | Nome sintetico        | Comando1                        | Comando2                                               |
| --------------- | --------------------- | ------------------------------- | ------------------------------------------------------ |
| F1              | Login                 | ``` login nickname password$``` | ``` register surname name nickname email password$ ``` |
| F2              | Visualizzare post     | ``` post$ ```                   |                                                        |

## 🚀 Roadmap
- [ ] F1: Login e registrazione
  - [X] F1.1: Login con username e password prefissati
  - [X] F1.2: Login con username e password scelti dall'utente
  - [X] F1.3: Registrazione
  - [X] F1.4: Controlla email valida e password con numeri e caratteri speciali
  - [X] F1.5: Controlla input vuoti nel login
  - [ ] F1.6: Controlla che il nickname e la mail sia libero
  - [ ] F1.7: Utilizzare un metodo hash per cifrare le password
- [ ] F2: Visualizzare post
  - [X] F2.1: Vedere un post di prova
  - [X] F2.2: Leggere tutti i post da database
  - [X] F2.3: Vedere un post random
  - [ ] F2.4: Visualizzare il post con una UI decente
  - [ ] F2.5: Le richieste possono essere effettuate solo da utenti loggati
  - [ ] F2.6: Cambiare il post restituito in base agli interessi
  - [ ] F2.7: Visualizzare i post recenti (solo frontend)
- [ ] F3: Pubblicare contenuti
  - [ ] F3.1: Scrivere un post sul database (aggiornando l'elenco di post effettuati da ogni persona)
  - [ ] F3.2: Aggiungere un'immagine dal web
  - [ ] F3.3: Le richieste possono essere effettuate solo dal utenti loggati
- [ ] F4: Cerca utenti
  - [ ] F4.1: Vedere tutti gli utenti presenti nel database
  - [ ] F4.2: Cercare un utente in base al nickname
  - [ ] F4.3: Visualizzare tutte le informazioni sull'utente in una form (like, commenti...)
- [ ] F5: Interagire con i post
  - [ ] F5.1: Like ai post
  - [ ] F5.2: Commenti ai post
- [ ] Aggiunte varie
  - [ ] Visualizzare se un utente è online
- [ ] Bug
  - [X] Compaiono popup a caso, magari toglili <3
  - [X] Quando faccio login e esco senza loggare, scompare il signup
  - [X] Responsive server
  - [X] Quando finisce registrazione, chiude form
  - [X] Quando il client chiede il post si chiude la form
  - [ ] Restituire lo stesso post di fila

## ❤️ Credits
### Immagini
| Nome            | Autore          | Link                                              |
| --------------- | --------------- | ------------------------------------------------- |
| Test account    | Icons8          | https://icons8.com/icon/7Ffvtg1xmgaV/test-account |
| Shuttle         | Freepik         | https://www.flaticon.com/free-icon/shuttle_2285485term=start%20button&page=1&position=1&page=1&position=1&related_id=2285485&origin=tag | 
| Plant icons	| Freepik		| https://www.flaticon.com/free-icons/plant
