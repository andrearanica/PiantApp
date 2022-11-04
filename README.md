# 🪴 PiantApp
<!--Hai mai voluto--> 
PiantApp è un'applicazione che consente agli utenti di condividere e parlare di piante. Ogni utente può condividere informazioni sulle piante che ha piantato, vedere le piante dei propri amici e moltre altre funzioni

## ⚙️ Architettura
L'architettura è client-server
* Server (uno): accettare le richieste dei client e risponde con le informazioni richieste
* Client (da uno a n): richiedere informazioni al server

## 🔎 Analisi casi d'uso 

### Utenti
| ID Utente | Nome utente        | Descrizione                                                                          |
| --------- | ------------------ | ---------------------------------------------------------------------------          |
| U1        | Utente non loggato | Utente che non ha effettuato il login a cui viene richiesto di autenticarsi          |
| U2        | Utente loggato     | Utente che ha effettuato l'accesso e che quindi può richiedere tutte le funzionalità |
| U3        | Admin              | Utenti con privilegi superiori, per controllare i contenuti                          |

### Funzionalità
| ID Funzionalità | Nome sintetico        | Utenti interessati | Descrizione                                                                       |
| --------------- | --------------------- | ------------------ | --------------------------------------------------------------------------------- |
| F1              | Login                 | U1                 | L'utente deve inserire username e password per procedere                          |
| F2              | Cerca utenti          | U2, U3             | L'utente può cercare altri utenti per vedere i loro contenuti tramite il nickname |
| F3              | Pubblicare contenuti  | U2                 | Coming soon...                                                                    |
| F4              | Interagire con i post | U2, U3             | Mi piace, condividere, commentare...                                              |

## 🚀 Roadmap
- [ ] F1: Login
  - [X] F1.1: Login con username e password prefissati
  - [ ] F1.2: Login con username e password scelti dall'utente
- [ ] F2: Cerca utenti
- [ ] F3: Pubblicare contenuti
- [ ] F4: Interagire con i post

## ❤️ Credits
### Immagini
| Nome            | Autore          | Link                                              |
| --------------- | --------------- | ------------------------------------------------- |
| Test account    | Icons8          | https://icons8.com/icon/7Ffvtg1xmgaV/test-account |
| Shuttle         | Freepik         | https://www.flaticon.com/free-icon/shuttle_2285485term=start%20button&page=1&position=1&page=1&position=1&related_id=2285485&origin=tag | 
