//variaveis de cor e posição inicial
color bg = color(18);
color sph = color(210);
int EposX = 250;
int EposY = 250;
int RposX = 250;
int RposY = 250;
//float d = dist(EposX, EposY, RposX, RposY); //calcular a distancia entre os dois pontos, como apenas calcula 1x, movi isto para o draw()
int moveDistance = 35; // a distancia com q a esfera se vai mexer

//tamanho do canvas e no stroke + spec. framerate
void setup() {
size(500, 500);
frameRate(10);
noStroke();
}

void draw() {
background(bg);
d = dist(EposX, EposY, RposX, RposY);
if (d <= 50) {
fill(40,40,244);//azul
}else{
fill(200,100,45);//laranja
}
drawSphere();
drawRect();
}


void drawSphere() {
//numero aleatorio para as posições (1 a 5 porque por algum motivo o processing nao assume o ultimo numero)
int randomNum = int( random(1, 5));
ellipse(EposX, EposY, 100, 100);
//usar o numero aleatorio para determinar a proxima direcao da esfera
if (randomNum == 1) {
  EposX = EposX + moveDistance;
} else if (randomNum == 2) {
  EposY = EposY + moveDistance;
} else if (randomNum == 3) {
  EposX = EposX - moveDistance;
} else if (randomNum == 4) {
  EposY = EposY - moveDistance;
}
//statement block para não deixar a esfera sair do canvas
if (EposX > 450) {
  EposX = 450;
} else if (EposX < 50) {
  EposX = 50;
}
if (EposY > 450) {
  EposY = 450;
} else if (EposY < 50) {
  EposY = 50;
}

}

void drawRect() {
//numero aleatorio para as posições (1 a 5 porque por algum motivo o processing nao assume o ultimo numero)
int randomNum = int( random(1, 5));
rect(RposX, RposY, 100, 100);
//usar o numero aleatorio para determinar a proxima direcao da esfera
if (randomNum == 1) {
  RposX = RposX + moveDistance;
} else if (randomNum == 2) {
  RposY = RposY + moveDistance;
} else if (randomNum == 3) {
  RposX = RposX - moveDistance;
} else if (randomNum == 4) {
  RposY = RposY - moveDistance;
}
//statement block para não deixar a esfera sair do canvas
if (RposX > 450) {
  RposX = 450;
} else if (RposX < 50) {
  RposX = 50;
}
if (RposY > 450) {
  RposY = 450;
} else if (RposY < 50) {
  RposY = 50;
}

}
