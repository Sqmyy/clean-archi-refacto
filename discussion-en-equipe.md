# Discussion en equipe

## Avant de coder

### But de l'app

L'application a 2 buts:
- afficher de maniere presentable les donnees contenues dans notre fichier
- faire un resumé des donnees contenues dans le fichier

### Bien

- Les variables sont dans l'ensemble bien nommées, on comprend leur roles en lisant leur noms
- GoldenMaster fonctionnel
- Repertoire de test separé du repertoire du code

### Pas bien

- Tout est dans le main, lisibilité du code immmonde
- Des valeurs hard-codées
- Variable i faisant office de compteur, nom peu explicit, pareil pour number 1,2,3,4,5
- Programmation imperative, traitement de notre probleme ligne par ligne
- Datetime inutile
- Le nombre de client est toujours = 0

### Comment on split tout ca

- Renaming des variable au nom peu explicit
- classe Output pour l'affichage
- classe Printer pour la commande print
- classe Reporter pour la commande report
- classe pour le helper au cas ou l'utilisateur ne precise ni `report` ni `print`

## Remarques pour le prof

On est tous deux arrivés en 4eme année a l'ESGI et on a jamais eu de cours sur les Tests, on a essayé d'en ecrire quelques uns mais c'etait n'importe quoi et ca fonctionnait pas.
On s'est donc referer a l'output original en le comparant avec notre resultat pour avancer a chaque fois.
