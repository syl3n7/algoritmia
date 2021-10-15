Retangulo r ;

void setup() {
  size(500, 500);
  frameRate(5);
  rectMode(CENTER);
  r = new Retangulo();
}

void draw() {
  background(255);
  r.desenha();
  r.mover();
}
