color bg, cbola;

void setup(){

  size(500, 500);
  bg = color(255);
  cbola = color(0);
  
}

void draw(){

  background(bg);
  desenhaBola();
  
}

void desenhaBola() {
   
  fill(cbola);
  ellipse(height/2, width/2, mouseX, mouseY);
  
}
