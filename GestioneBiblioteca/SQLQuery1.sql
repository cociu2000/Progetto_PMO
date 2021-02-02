SELECT Genere.nomeGenere
FROM Utenti,Genere
WHERE Utenti.email='rossi.mario@email.it' AND Utenti.IdGenere=Genere.idGenere