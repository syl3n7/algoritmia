int v = 2;
int pY = 0;

void setup(){

  size(500, 500);
  rectMode(CENTER);
  noStroke();
  
}

void draw(){

  background(255,255,255);
  desenho(200);
  
}

void desenho(int t){
 
  fill(100);
  rect(height/2, pY, t, t);
  pY = pY + v;
  
}
