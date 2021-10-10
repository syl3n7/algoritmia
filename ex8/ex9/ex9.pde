color corRect = color(0);
color corRect2 = color(162, 6, 84);

void setup() {
  size(500, 500);
  noStroke();
  rectMode(CENTER);
}

void draw() {
  background(255);
  desenhaQuadrado(200);
}

void desenhaQuadrado(int tamanho) {
  if (mouseX >= 150 && mouseX <= 350 && mouseY >= 150 && mouseY <= 350) {
    fill(corRect2);
    rect(height/2, width/2, tamanho, tamanho);
  } else {
    fill(corRect);
    rect(height/2, width/2, tamanho, tamanho);
  }
}
