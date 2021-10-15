class Retangulo {

  //propriedades
  float posX, posY, size, cor;
  boolean check;

  //construtor
  Retangulo() {

    size = 0;
    posX = 250;
    posY = 250;
    cor = 0;
  }

  void desenha() {

    fill(cor);
    rect(posX, posY, size, size);
  }

  void mover() {

    if (check == false) {
      cor = cor + 1;
    } else if (check == true) {
      size = size + 100;
    }
    
    if (size <= 500) {
      check = true;
    } else {
      check = false;
    }
    
  }
}
