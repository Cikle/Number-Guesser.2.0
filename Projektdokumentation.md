# Number-guesser

# Projekt-Dokumentation


Cyril Lutziger

| Datum | Version | Zusammenfassung                                              |
| ----- | ------- | ------------------------------------------------------------ |
| 18.08 | 0.0.2   | Projekt wurde vorgestellt, entschieden es mit net. Frameworks zu erstellen. Projekt gestartet   |
| 25.08 | 0.0.2   | Mit dem projekt weitergemacht                                      |
| 1.09 | 0.0.2   | Es in OOP umwandeln / Klassen erstellen, bin aber in hindernisse geraten                                      |
| 8.09 | 0.0.2   | Klassen und alles geflickt. Ein paar fehler behoben                                      |
| 15.09 | 0.0.2   | Projektdokumentation abgeschlossen                                      |

## 1 Informieren

### 1.1 Ihr Projekt

Mein Projekt geht darum, dass es ein Spiel ist welche eine Zahl von 1-100 generiert und der User diese herausfinden mussmit verschiedenen Tips.

### 1.2 User Stories

| US-№ | Verbindlichkeit | Typ  | Beschreibung                       |
| ---- | --------------- | ---- | ---------------------------------- |
| 1  |      muss       |  F  | Als ein User möchte ich das ich eine Zahl eingeben kann welcher dannach gesagt wird ob die Lösungszahl grösser oder kleiner ist. |
| 2  |      muss       |  F  |   Als ein User möchte ich das dass Programm richtig läuft damit ich keine Buchstaben oder Sonderzeichen eingeben kann. |
| 3  |      muss       |  F  | Als User möchte ich wissen wenn ich die richtige eingabe getroffen habe, dass ich gewonnen habe, damit das Spiel auch ein Ende hat. |
| 4  |      kann       |  Q  |   Es kann ein bequemes design haben damit ich ein gutes Spielerlebniss habe. Es kann auch einen Gewinner-screen haben damit man so wie belohnt wird wenn die richtige Lösung geraten zu haben. |
| 5  |      kann       |   Q  |  Als ein User möchte ich die Auswahl haben ein neues Spiel zu starten. |
| 6  |      muss       |   F  |  Die anzahl von versuchen am schluss des spieles anzeigen. |
| 7  |      kann       |   Q  |  Musik und Soundeffekte beinhalten. |
| 8  |      kann       |   Q  |  Das spiel restarten während man am spielen ist. |
| 9  |      kann       |   Q  |  Das spiel wärend man spielt exiten, jedoch aber wieder weiterspielen. |



### 1.3 Testfälle

| TC-№ | Ausgangslage | Eingabe | Erwartete Ausgabe |
| ---- | ------------ | ------- | ----------------- |
| 1.1  | Das Programm ist gestartet und zeigt einen start screen |  10      |  Start-Screen mit play button     |
| 1.2  | Das Programm ist gestartet und hat sich eine Zahl zwischen 1 und 100 generiert |  24      |  kleiner oder grösser     |
| 1.3  | Das Programm ist gestartet und sagt mir ob meine Eingabe z.B. die 24 grösser oder kleiner ist als die Zahl des Computers  |  20      |  kleiner oder grösser     |
| 2.1  | Das Programm ist gestartet und ich kann das spiel neustarten  |  24      |  restart, neue generation von einer nummer     |
| 2.2  | Das Programm ist gestartet und ich kann das spiel exiten aber auch nochmals weiterspielen  |  30      |  Zurück zum starterscreen, weiterspielen     |
| 2.3  | Eine warnung mit welche besagt das man keine Sonderzeichen eingeben kann sowie Buchstaben.| eine von den 26 buchstaben oder Sonderzeichen |   Warnungsfeld mit "Ihre Eingabe ist ungültig oder wurde nicht erkannt, bitte geben Sie diese erneut ein."|
| 3.1  | Ein Sie haben gewonnen Screen | 24 |   "Du hast die nummer erraten"|
| 3.2  | Ein Sie haben "4 versuche gebraucht" | 24 |   "Sie haben 4 versuche gebraucht"|
| 4.1  | Ein spielen button | Nochmals Spielen | spiel screen |
| 4.2  | Ein Exit to main screen button | Zum main screen gehen | Main screen |
| 4.3  | Musik einbauen | nichts | Musik |
| 4.4  | Applaus sound einbauen | nichts | *klatsch* |


### 1.4 Diagramme
![Number-guesser](https://github.com/Cikle/Number-Guesser.2.0/assets/110893288/318a2de7-df0d-4e2d-b8d2-dbb1e497e9f8)




## 2 Planen

| AP-№ | Frist | Zuständig | Beschreibung | geplante Zeit |
| ---- | ----- | --------- | ------------ | ------------- |
| 1.A  | 18.08 | Cyril Lutziger      |      Das Programm kann eine zufällige Zahl zwischen 1 und 100 generieren und diese auch als Lösunsgzahl erkennen.       |     90min       |
| 2.A  | 18.08 | Cyril Lutziger      |      Das Programm hat einen Start-screen, Spiel-screen und gewinnerscreen.       |     90min       |
| 3.A  | 25.08 | Cyril Lutziger      |    Das Programm sagt dem User ob die Eingegebene Zahl kleiner oder grösser ist      |    45min      |
| 4.A  | 25.08 | Cyril Lutziger      |     Das designen vom Umfeld des spieles und die verschiedene Seiten     |     45min      |
| 5.A  |  1.09 | Cyril Lutziger      |    Problembehebungen des codes       |    90min      |
| 6.A  |  1.09 | Cyril Lutziger      |      Das Program fragt den Spieler um eine Eingabe    |    20min      |
| 7.A  |  8.09 | Cyril Lutziger      |    Das Programm gibt dem User ein Warnungsfeld falls etwas anderes als eine Zahl eingegeben wurde.       |     45min       |
| 8.A  |  8.09 | Cyril Lutziger      |    Problembehebungen des codes       |    45min      |
| 9.A  |  8.09 | Cyril Lutziger      |    Möchten Sie nochmals Spielen und Exit? Button      |    25min      |
| 10.A |  8.09 | Cyril Lutziger      |    Sound und Musik    |    40min      |

Total: 


## 3 Entscheiden

Ich nehme an das der User ein einfaches aber noch gut assehendes design will, sodass es sich angenehm anfühlt.

Ich nehme an das der User Zahlen eingibt die entwedder grösser oder kleiner sind und erwarte dass, das Programm diese anzeigt.

Ich nehme an das der User einen Gewinnerscreen haben will, somit er sich belohnt fühlt wenn er es geschafft hat + einen Applaus sound.

Ich denke das der User auch nochmal spielen will und lasse sie entscheiden ob sie nochmals spielen wollen oder zurück zum main screen gehen wollen.

Ich denke das der User auch wissen will wieviel versuche er gebraucht hatte, und dies im Gewinnerscreen angezeigt wird.

Ich denke das der User auch wissen will welche nummern er/sie schon eingegeben hatte.

## 4 Realisieren

| AP-№ | Datum | Zuständig | geplante Zeit | tatsächliche Zeit |
| ---- | ----- | --------- | ------------- | ----------------- |
| 1.A  | 18.08 | Cyril Lutziger  | 90min   |    135min         |
| 2.A  | 18.08 | Cyril Lutziger  | 90min   |    60min          |
| 3.A  | 25.08 | Cyril Lutziger  | 45min   |    30min          |
| 4.A  | 25.08 | Cyril Lutziger  | 45min   |    40min          |
| 5.A  |  1.09 | Cyril Lutziger  | 20min   |    45min          |
| 6.A  |  1.09 | Cyril Lutziger  | 45min   |    50min          |
| 7.A  |  8.09 | Cyril Lutziger  | 45min   |    80min          |
| 8.A  |  8.09 | Cyril Lutziger  | 45min   |    50min          |
| 9.A  |  8.09 | Cyril Lutziger  | 25min   |    20min          |
| 10.A |  8.09 | Cyril Lutziger  | 40min   |    20min          |

## 5 Kontrollieren

### 5.1 Testprotokoll

| TC-№ | Datum | Resultat | Tester |
| ----- | -------- | ------ | ------- |
|   1.1     |  30.08    |  Das System gibt aus ob die Zahl grösser oder kleiner ist          | Cyril Lutziger      |
|   2.1     |  30.08   |   Das Programm kann sagen ob ddie Zahl grösser oder kleiner ist        | Cyril Lutziger      |
|   3.1    |  6.09     |   Das Programm gibt einen gewinnerscreen raus und fragt ob man erneut spielen will.       | Cyril Lutziger      |



### 5.2 Exploratives Testen

| BR-№ | Ausgangslage | Eingabe | Erwartete Ausgabe | Tatsächliche Ausgabe |
| ---- | ------------ | ------- | ----------------- | -------------------- |
| 1   |  |    Aplikation gestartet        |   3,5, -4 oder buchstaben      |  Programm stürzt ab oder eine fehler anzeige                 |      Das Programm bittet um eine erneute Eingabe.                |

## 6 Auswerten
