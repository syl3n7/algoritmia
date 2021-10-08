//int v = 2;
int pY = 250;
color cd = color(200, 0, 0);
color ce = color(0, 100, 0);

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
 
  if(mouseX <= 250){
  fill(cd);
  rect(height/2, pY, t, t);
  //pY = pY + v;
  } else {
    
    fill(ce);
    rect(height/2, pY, t, t);
    
  }
  
}
