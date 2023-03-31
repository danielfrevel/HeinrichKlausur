CREATE TABLE Person (
ID int PRIMARY KEY,
  vorname varchar(255),
  nachname varchar(255)
 
);
CREATE TABLE Messung (
ID int PRIMARY KEY,
Person_id int, FOREIGN KEY (Person_id) REFERENCES Person(ID),
  Blutdruck int,
  Temperatur int,
  Datum Date
);

CREATE TABLE Warnung (
ID int PRIMARY KEY,
Messung_id int, 
 FOREIGN KEY (Messung_id) REFERENCES Messung(ID),
 Prio int,
  Gueltigkeit Date, 
  Warnungsart int
);

INSERT INTO Person (ID, vorname, nachname) VALUES (1, 'Max', 'Mustermann');
INSERT INTO Person (ID, vorname, nachname) VALUES (2, 'Erika', 'Musterfrau');
INSERT INTO Person (ID, vorname, nachname) VALUES (3, 'Hans', 'Schmidt');

INSERT INTO Messung (ID, Person_id, Blutdruck, Temperatur, Datum) VALUES (1, 1, 120, 36, '2023-03-29');
INSERT INTO Messung (ID, Person_id, Blutdruck, Temperatur, Datum) VALUES (2, 2, 130, 37, '2023-03-29');
INSERT INTO Messung (ID, Person_id, Blutdruck, Temperatur, Datum) VALUES (3, 3, 140, 38, '2023-03-29');


INSERT INTO Warnung (ID, Messung_id, Prio, Gueltigkeit, Warnungsart)
VALUES 
  (1, 1, 1, '2022-03-29', 1),
  (2, 2, 2, '2022-03-30', 1),
  (3, 3, 3, '2022-03-30', 2)
-------------------------------
--------- QUERYs ------
-------------------------------
SELECT 
  YEAR(m.Datum) AS Jahr,
  MONTH(m.Datum) AS Monat,
  AVG(m.Blutdruck) AS DurchschnittlicherBlutdruck
FROM Messung m
GROUP BY YEAR(m.Datum), MONTH(m.Datum);



SELECT 
  w.Warnungsart, 
  COUNT(*) AS AnzahlDerWarnungen
FROM Warnung w 
WHERE w.Gueltigkeit BETWEEN DATE_SUB(NOW(), INTERVAL 1 WEEK) AND NOW()
GROUP BY w.Warnungsart;

