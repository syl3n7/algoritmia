class Retangulo {

  //propriedades
  float posX, posY, size;
  color cor;
  boolean check ;
  int controlo = 0;

  //construtor
  Retangulo() {

    size = 0;
    posX = 250;
    posY = 250;
    cor = color(160,60,50);
  }

  void desenha() {

    fill(cor);
    rect(posX, posY, size, size);

  }

  void mover() {

    if (check == true) {

    } else if (check == false) {
      size += 1;
    }
    
    if (size >= 500) {
      check = true;
      controlo++;
      size = 0;
    } else {
      check = false;
    }
    
    if(controlo % 2 == 0)
    {
      cor = color(160,60,50);
    } else cor = color(100,50,70);
  }
}
