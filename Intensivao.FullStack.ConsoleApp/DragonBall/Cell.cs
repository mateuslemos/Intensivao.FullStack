public class Cell 
{
    public string Malvado {get; set;}

    public string Rabeta {get; set;}

    public Capsula Capsula {get; set;}
    
  //  //Método (métodos são ações que pode envolver uma condição ou não) do Cell
  //  public bool Sugar()
  //  {
        
  //      if(oponente = humano) {

            
  //      }
  //  }


  //Engolir(){

  //}

    //Construtor é usado quando se cria objeto.

    /*Trunks precisa ser parâmetro pois é a partir dele que será possível
    acessar a cápsula (que está public). Para isso isso é necessário acessar
    a Classe "Trunks" com o parâmetro "trunks".*/
  public void Roubar(Trunks trunks)
  {
    Capsula = trunks.Capsula;  
  }

}

  

 
