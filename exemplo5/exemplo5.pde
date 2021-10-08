float pX = 0;
color cB = color(200, 0, 0);
float v = random(1,3);

void setup(){

  size(500, 500);
  noStroke();
  
}

void draw(){

  background(255,255,255);
  desenho(100);
  v = v + v;
  
}

void desenho(int t){
 
  fill(cB);
  ellipse(pX, height/2, t, t);
  pX = v ;
  
}
