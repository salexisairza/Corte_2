import javax.swing.JOptionPane;

public class NumerosTerminadoss

{
    public static void main(String[] args) {
 

        String text=JOptionPane.showInputDialog("Inserta un tamaño");
        int Num[]=new int[Integer.parseInt(text)];
 
        int Udigito;

        do{
            text=JOptionPane.showInputDialog("Introduzca un numero entre 0 y 10");
            Udigito=Integer.parseInt(text);
        }while(!(Udigito>=0 && Udigito<=10));
 

        int numeroAleatorio (Num 1 , 300);
 

        int NumerosTerminadosen [] =numsTerminadosEn(Num, ultimoDigito);
 

        arrayTerminados (NumerosTerminadosen);
 
    }
     public static void numeroAleatorio (int enumeracion [], int a, int b)
    
    {
        for(int i=0;i<enumeracion.length;i++){

            enumeracion[i]=((int)Math.floor(Math.random()*(a-b)+b));
        }
    }
     public static void arrayTerminados (int enumeracion[])
    
    {
        for(int i=0;i<enumeracion.length;i++){

            if(enumeracion[i]!=0){
                System.out.println("El numero "+enumeracion[i]+" termina en");
            }
        }
    }
 
    public static int[] numsTerminadosEn (int num [], int Unumero){
 
        int numsTerminadosEn[]=new int[num.length];
 
        int numeroFinal=0;
 
        for (int i=0;i<numsTerminadosEn.length;i++){
 

            numeroFinal=num[i]-(num[i]/10*10);

 
            if (numeroFinal==Unumero){
                numsTerminadosEn[i]=num[i];
            }
        }
 
        return numsTerminadosEn;
    }
 
}