# 🌵 PiantApp
<!--Hai mai voluto--> 
PiantApp è un'applicazione che consente agli utenti di condividere conoscenze e parlare di piante. Ogni utente può condividere informazioni sulle piante che ha piantato, vedere le piante dei propri amici e moltre altre funzioni

## ✨ Funzionamento
Per utilizzare il programma esegui il server e fai partire il servizio premendo il pulsante apposito. Successivamente esegui i client ed effettua il login.
Nella parte centrale possiamo notare la sezione dei post, in cui possiamo scorrere i post pubblicati con il pulsante apposito. Possiamo anche dare un mi piace al post.
Nella barra a sinistra sono presenti alcune funzionalità: nuovo post, che serve per pubblicare un nuovo post, cerca utente, che consente di trovare un utente in base al suo nickname, e l'immagine di profilo, che apre un menu con le informazioni sull'account (in questa sezione si possono modificare le informazioni). Nella barra laterale è presente inoltre il contatore dei mi piace che gli altri account hanno dato all'utente.

## ⚙️ Architettura
### ⌨️ Architettura client-server
 - Server (uno): accetta le richieste dei client e risponde con le informazioni richieste
 - Client (da uno a n): richiede informazioni al server e le visualizza
### 🗃️ Basi di dati
 - /json/users.json contiene gli utenti registrati
 - /json/posts.json contiene i post

## 🔎 Analisi casi d'uso 

### Utenti
| ID Utente | Nome utente        | Descrizione                                                                          |
| --------- | ------------------ | ------------------------------------------------------------------------------------ |
| U1        | Utente non loggato | Utente che non ha effettuato il login a cui viene richiesto di autenticarsi          |
| U2        | Utente loggato     | Utente che ha effettuato l'accesso e che quindi può richiedere tutte le funzionalità |

### Funzionalità
| ID Funzionalità | Nome sintetico        | Utenti interessati | Descrizione                                                                        |
| --------------- | --------------------- | ------------------ | ---------------------------------------------------------------------------------- |
| F1              | Login e registrazione | U1                 | L'utente deve inserire username e password per procedere                           |
| F2              | Visualizzare post     | U2                 | Nella home dell'utente, deve essere presente un post                               |
| F3              | Pubblicare contenuti  | U2                 | L'utente può pubblicare un post                                                    |
| F4              | Cercare utenti        | U2                 | L'utente può cercare altri utenti per vedere i loro contenuti tramite il nickname  |
| F5              | Interagire con i post | U2                 | Mi piace                                                                           |

## 💻 Protocollo
| ID Funzionalità | Nome sintetico        | Comando                                                 | Risposta                                                                   |
| --------------- | --------------------- | -----------------------------------------------------   | -------------------------------------------------------------------------- |
| F1              | Login                 | ``` login nickname password$```                         | ``` surname name nickname email password image likes liked$ ``` o ``` ```  |
| F1              | Registazione          | ``` register surname name nickname email password$ ```  | ``` successfull$ ``` o ```" "```                                           |
| F1              | Aggiungere pianta     | ``` addplant nickname plant$ ```                        | ``` successfull$ ``` o ```" " ```                                          |
| F1              | Rimuovere pianta      | ``` removeplant nickname plant$ ```                     | ``` successfull$ ``` o ```" " ```                                          |
| F1              | Aggiorna informazioni | ``` update nickname name surname email$ ```             | ``` successfull$ ``` o ```" " ```                                          |
| F2              | Visualizzare post     | ``` post$ ```                                           | ``` title author date description$ ```                                     |
| F3              | Pubblicare contenuti  | ``` add title author data description$ ```              | ``` successfull$ ``` o ``` invalid$ ```                                    |
| F4              | Cerca utente          | ``` user nickname$ ```                                  | ``` surname name nickname email password image likes liked$ ```            |
| F5              | Like                  | ``` like title$ ```                                     | ``` successfull$ ```                                                       |

## Utilizzo UI
Una volta aperto il form ci ritroveremo davanti a questa schermata:

## 🚀 Roadmap
- [X] F1: Login e registrazione
  - [X] F1.1: Login con username e password prefissati
  - [X] F1.2: Login con username e password scelti dall'utente
  - [X] F1.3: Registrazione
  - [X] F1.4: Controlla email valida e password con numeri e caratteri speciali
  - [X] F1.5: Controlla input vuoti nel login
  - [X] F1.6: Controlla che il nickname e la mail siano liberi
  - [X] F1.7: Utilizzare un metodo hash per cifrare le password
  - [X] F1.8: L'utente puo' scegliere un'immagine preimpostata
  - [X] F1.9: Modificare le piante del proprio account (aggiungi e rimuovi)
  - [X] F1.10: Modificare i dati
- [ ] F2: Visualizzare post
  - [X] F2.1: Vedere un post di prova
  - [X] F2.2: Leggere tutti i post da database
  - [X] F2.3: Vedere un post random
  - [X] F2.4: Visualizzare il post con una UI decente
  - [ ] F2.5: Cambiare il post restituito in base agli interessi (input)
  - [ ] F2.6: Visualizzare i post recenti (solo frontend)
- [X] F3: Pubblicare contenuti
  - [X] F3.1: Scrivere un post sul database (aggiornando l'elenco di post effettuati da ogni persona)
  - [X] F3.2: Controllare i dati inseriti
- [X] F4: Cerca utenti
  - [X] F4.1: Vedere tutti gli utenti presenti nel database
  - [X] F4.2: Cercare un utente in base al nickname
  - [X] F4.3: Visualizzare tutte le informazioni sull'utente in una form (like, piante...)
- [ ] F5: Interagire con i post
  - [X] F5.1: Like ai post
  - [ ] F5.2: Commenti ai post
- [X] UI:
  - [X] Cambia il design delle finestre secondarie
  - [X] Aggiungi dettagli piante
- [ ] Aggiunte varie
  - [ ] Visualizzare se un utente è online
  - [X] Controlla le risposte delle richieste
  - [X] Immagini di profilo predefinite
  - [X] Data automatica quando compilo un nuovo post
  - [X] Aggiungi img profili
- [X] Bug
  - [X] Compaiono popup a caso, magari toglili <3
  - [X] Quando faccio login e esco senza loggare, scompare il signup
  - [X] Responsive server
  - [X] Quando finisce registrazione, chiude form
  - [X] Quando il client chiede il post si chiude la form
  - [X] Restituire lo stesso post di fila
  - [X] Quando pubblico un post nella descrizione compare un $
  - [X] Se nel post pubblicato ci sono spazi da problemi
  - [X] Titolo univoco

## ❤️ Credits
### Immagini
| Nome            | Autore                | Link                                                                  |
| --------------- | --------------------- | --------------------------------------------------------------------- |
| Test account    | Icons8                | https://icons8.com/icon/7Ffvtg1xmgaV/test-account                     |
| Shuttle         | Freepik               | https://www.flaticon.com/free-icon/shuttle_2285485term=start%20button&page=1&position=1&page=1&position=1&related_id=2285485&origin=tag   | 
| Plant icons	| Freepik		      | https://www.flaticon.com/free-icons/plant                                       |
| Lens            | Javis V. Pérez        | https://icon-icons.com/it/icona/ricerca-lente-di-ingrandimento/145939 |
| Plus            | Becris                | https://icon-icons.com/icon/plus-add-more-detail/82972                |  
| Next icons      | Smashicons - Flaticon | https://www.flaticon.com/free-icons/next
| Cipresso		| brgfx                 | https://www.freepik.com/free-vector/isolated-tree-white-background_29280578.htm#query=cartoon%20tree&position=20&from_view=keyword |
| Cuore verde	| rawpixel.com          | https://it.freepik.com/vettori-gratuito/illustrazione-dell-icona-medica_2606899.htm#query=green%20heart&position=21&from_view=search&track=sph |
| Plants falling  | rawpixel.com      | https://www.freepik.com/free-vector/illustration-hanging-plant-isolated-white-background_2616106.htm#query=watercolor%20plants&position=11&from_view=keyword |
| Coccinella      | jcomp             | https://www.freepik.com/free-vector/set-lady-bug-cute-bee-with-flower-cartoon-animal-element-drawing-water-color-graphic-designer-flat-design-vector-illustration_25273063.htm#query=cute%20leaves%20paint&position=5&from_view=search&track=sph |
| Plants          | pch.vector        | https://www.freepik.com/free-vector/potted-plants-set_8271077.htm#query=cute%20plants&position=0&from_view=keyword  |
