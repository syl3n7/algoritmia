float a = random(175, 375);
float b = random(175, 375);
float c = random(175, 375);
float d = random(175, 375);
float e = random(175, 375);
float f = random(175, 375);
float g = random(175, 375);
float h = random(175, 375);
float red = random(0, 255);
float green = random(0, 255);
float blue = random(0, 255);
float w1 = random(10,15);
float w2 = random(5,9);
float w3 = random(1,4);

void setup(){

  size(500, 500);
  noStroke();
  
}

void draw(){
  
  background(0, 0, 0);
  stroke(red, green, blue);
  desenhar();
  
}

void desenhar(){
  
  strokeWeight(w1);
  line (a, b, c, d);
  strokeWeight(w2);
  line (c, d, e, f);
  strokeWeight(w3);
  line (e, f, g, h);

}
