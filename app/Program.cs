
class Program : Information, Interface
{




    //override solo cuando voy a sobre escribir un metodo de clase
    /*  public override void Ojoconeso()
        {
            Console.WriteLine("Epale mijo");
        }
    */

    //asi cuando es metodo abstracto de interfaz
    public void Ojoconesos()
    {
        Console.WriteLine("Epale mijo");
    }

    public static void Main(string[] args)
    {






        Console.WriteLine("Hello, World!, Say 'Hey'");


        for (int i = 0; i <=4; i++)
        {


            String nombre = Console.ReadLine();

            String apellido = Console.ReadLine();

            String especialidad = Console.ReadLine();


            Information information = new Information(nombre, apellido, especialidad, i);

            if (i == 4)
            {

                foreach (var element in information.Name) {
                
            }
        }
    
    

        }


}

            

        }





    /*    information.SetName("Lucario");
                                program.SetName("Ojón");

     
*/
