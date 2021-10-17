//variaveis de cor e posição inicial
color bg = color(18);
color sph = color(210);
int posX = 250;
int posY = 250;
int moveDistance = 35; // a distancia com q a esfera se vai mexer

//tamanho do canvas e no stroke + spec. framerate
void setup() {
size(500, 500);
frameRate(30);
noStroke();
}

void draw() {
background(bg);
drawSphere();
}

void drawSphere() {
//numero aleatorio para as posições (1 a 5 porque por algum motivo o processing nao assume o ultimo numero)
int randomNum = int( random(1, 5));
fill(sph);
ellipse(posX, posY, 100, 100);
//usar o numero aleatorio para determinar a proxima direcao da esfera
if (randomNum == 1) {
  posX = posX + moveDistance;
} else if (randomNum == 2) {
  posY = posY + moveDistance;
} else if (randomNum == 3) {
  posX = posX - moveDistance;
} else if (randomNum == 4) {
  posY = posY - moveDistance;
}
//statement block para não deixar a esfera sair do canvas
if (posX > 450) {
  posX = 450;
} else if (posX < 50) {
  posX = 50;
}
if (posY > 450) {
  posY = 450;
} else if (posY < 50) {
  posY = 50;
}
//so mesmo para testar o random value
println(randomNum);
}
