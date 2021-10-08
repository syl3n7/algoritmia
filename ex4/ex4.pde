void setup(){

  size(500, 500);
  rectMode(CENTER);
  noStroke();
  
}

void draw(){

  background(255,255,255);
  desenho();
  
}

void desenho() {
  
  fill(100);
  rect(width/2, width/2, mouseX, mouseY);
  fill(200);
  rect(width/2, width/2, mouseX/2, mouseY/2);
  
}
