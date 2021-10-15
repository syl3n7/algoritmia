Retangulo r ;

void setup() {
  size(500, 500);
  frameRate(60);
  rectMode(CENTER);
  noStroke();
  r = new Retangulo();
}

void draw() {

  r.desenha();
  r.mover();
}
