float a = random(100, 400);
float b = random(100, 400);
float c = random(100, 400);
float d = random(100, 400);
float e = random(100, 400);
float f = random(100, 400);
float g = random(100, 400);
float h = random(100, 400);
float red = random(0, 255);
float green = random(0, 255);
float blue = random(0, 255);

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
  
  strokeWeight(5);
  line (a, b, c, d);
  strokeWeight(15);
  line (c, d, e, f);
  strokeWeight(25);
  line (e, f, g, h);

}
