# VVVVVV

## Tipus de joc

El joc és del gènere plataforma amb puzzles.
Conegut per ser un joc amb molta velocitat on has d'evitar morir mentre aconsegueixes monedes i passes els nivells.

# El meu joc

Per a la meva versió he escollit un tileset d'aspecte de caverna i el meu jugador resembla a un petit explorador.

## Personatge:

- **Mecàniques:**
  Per moure's dreta o esquerra es pot fer servir tant les tecles A i D com les fletxes.
  Per canviar de gravetat es fa servir la tecla espai.
  Has d'evitar xocar-te amb els pinxos, la fletxa o el pekka.

- **Animacions:**
  El personatge compta amb 3 animacions:

  1. Idle: quan no està en moviment
  2. Run: quan el jugador comença a còrrer
  3. Death: quan el jugador ha col·lisionat amb algún element i ha mort

- **Sons:**
  Quan es mor, s'escolta un so per tal de donar a entendre al jugador que ha xocat. Per complemetar aquest so, el jugador ja no es pot moure ni saltar.

## Fletxa:

- **Mecàniques:**
  Quan la fletxa col·lisiona amb un empty que es troba fora d'escena, aquesta torna a la posició inicial, evitant així la creació de nous elements.

- **Animacions i sons:**
  La fletxa és un simple sprite sense cap tipus d'animació però compta amb un so per tal de complementar una mica aquest element de l'escena.

## Enemic:

- **Mecàniques:**
  L'enemic es mou de dreta a esquerra i quan col·lisiona amb la paret canvia de direcció

- **Animacions:**
  Aquest personatge té només una animació de còrrer

- **Sons:**
  Després de la col·lisió, l'enemic reprodueix un so particular

## Escenes:

- **Start**: Escena d'inici per començar a jugar
- **Pause**: Escena que apareix al prèmer escape
- **Game Over**: Escena que apareix al morir
- **End Game**: Escena que apareix al guanyar
