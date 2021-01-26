//Second type of class, this one is used to create an object


public class Animal {

    public String speciesName;
    public boolean isDomesticated;

    public Animal (String speciesName, boolean isDomesticated){

        this.speciesName = speciesName;
        this.isDomesticated = isDomesticated;
    }

    public Animal (String speciesName){


    }

    //Method in Java, buts its known as an operation
    public void MakeSound (){

       System.out.println ("generic Animal Sound");


    }







}
