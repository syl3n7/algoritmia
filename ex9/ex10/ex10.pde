//variaveis de cor e posição inicial
color bg = color(255);
color sph = color(0);
int posX = 250;
int posY = 250;

//tamanho do canvas e no stroke
void setup() {
  size(500, 500);
  frameRate(5);
  noStroke();
}

void draw() {
  background(bg);
  drawSphere();
}

void drawSphere() {
  //numero aleatorio para as posições
  int posrX = int( random(50, 450));
  int posrY = int( random(50, 450));
  fill(sph);
  ellipse(posX, posY, 100, 100);
  //usar o "resto" do numero aleatorio para determinar se é par e executar codigo consoante
  if (posrX % 2 == 1) {
    posX = posrX;
    posY = 250;
  } else if (posrX % 2 == 0) {
    posY = posrY;
    posX = 250;
  }
}
