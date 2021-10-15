class Ball {

  //propriedades
  float posX, posY, size, speed;
  boolean limiter;

  //construtor
  Ball() {

    size = 20;
    posX = size/2;
    posY = height/2;
    speed = 5;
  }

  void desenha() {

    fill(0);
    ellipse(posX, posY, size, size);
  }

  void mover() {
    
    size = mouseY;

    if (limiter == true) {

      posX += speed;
      
    } else if (limiter == false) {

      posX -= speed;
    }
    
    if(posX >= width - size/2){
      
      limiter = false;
      
    }else if (posX <= size/2) {
     
      limiter = true;
      
    }
    
  }
}
