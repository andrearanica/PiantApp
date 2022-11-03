# 🪴 PiantApp
<!--Hai mai voluto--> 
PiantApp è un'applicazione che consente agli utenti di condividere e parlare di piante. Ogni utente può condividere informazioni sulle piante che ha piantato, vedere le piante dei propri amici e moltre altre funzioni

## Architettura
Il sistema si basa su
* Server (uno): accettare le richieste dei client e risponde con le informazioni richieste
* Client (da uno a n): richiedere informazioni al server

## Analisi casi d'uso

### Utenti
| ID Utente | Nome utente        | Descrizione                                                                          |
| --------- | ------------------ | ---------------------------------------------------------------------------          |
| U1        | Utente non loggato | Utente che non ha effettuato il login a cui viene richiesto di autenticarsi          |
| U2        | Utente loggato     | Utente che ha effettuato l'accesso e che quindi può richiedere tutte le funzionalità |
| U3        | Admin              | Utenti con privilegi superiori, per controllare i contenuti                          |

### Funzionalità
| ID Funzionalità | Nome sintetico | Utenti interessati | Descrizione                                                                       |
| --------------- | -------------- | ------------------ | --------------------------------------------------------------------------------- |
| F1              | Login          | U1                 | L'utente deve inserire username e password per procedere                          |
| F2              | Cerca utenti   | U2, U3             | L'utente può cercare altri utenti per vedere i loro contenuti tramite il nickname | 

## Roadmap
- [ ] F1: Login
  - [X] F1.1: Login con username e password prefissati
  - [ ] F1.2: Login con username e password scelti dall'utente
- [ ] F2: Cerca utenti

## Credits
### Images
<a target="_blank" href="https://icons8.com/icon/7Ffvtg1xmgaV/test-account">Test Account</a> icon by <a target="_blank" href="https://icons8.com">Icons8</a><br />
<a target="_blank" href="https://www.flaticon.com/free-icon/shuttle_2285485?term=start%20button&page=1&position=1&page=1&position=1&related_id=2285485&origin=tag">Shuttle</a>
