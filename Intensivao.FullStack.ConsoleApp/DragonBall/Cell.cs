public class Cell 
{
    public string Malvado {get; set;}

    public string Rabeta {get; set;}

    public Capsula Capsula {get; set;}
    
  //  //M�todo (m�todos s�o a��es que pode envolver uma condi��o ou n�o) do Cell
  //  public bool Sugar()
  //  {
        
  //      if(oponente = humano) {

            
  //      }
  //  }


  //Engolir(){

  //}

    //Construtor � usado quando se cria objeto.

    /*Trunks precisa ser par�metro pois � a partir dele que ser� poss�vel
    acessar a c�psula (que est� public). Para isso isso � necess�rio acessar
    a Classe "Trunks" com o par�metro "trunks".*/
  public void Roubar(Trunks trunks)
  {
    Capsula = trunks.Capsula;  
  }

}

  

 
