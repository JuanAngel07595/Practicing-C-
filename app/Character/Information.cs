

public class Information 
{ 
    public string[] Name = new string[5]; // crea un vector de 5 elementos tipo string

    public string[] Description = new string[5]; // crea un vector de 5 elementos tipo string

    public string[] Speciality = new string[5]; // crea un vector de 5 elementos tipo string



    public virtual void Ojoconeso()
    {

        Console.WriteLine("Ojo puesmijo");
    }
    public string GetName(int num)
    {
        return Name[num];
    }
    public string GetDescription(int num)
    {
        return Description[num];
    }
    public string GetSpeciality(int num)
    {
        return Speciality[num];
    }

     public void SetName(string name, int num)
    {
        
        this.Name[num] = name;
    }
     public void SetDescription(string Description, int num)
    {
        
        this.Description[num] = Description;
    }

   public void Setspeciality(string speciality, int num)
    {
        
        this.Speciality[num] = speciality;
    }


    public Information(String name, String description, String speciality,int num)
    {
        this.Name[num] = name;
        this.Description[num] = description;
        this.Speciality[num] = speciality;
    }

    public Information()
    {
    }
}