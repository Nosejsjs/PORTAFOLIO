{
    class Circulo
{

    private double radio, perimetro, volumen, area;


    //Constructor
    public Circulo(double elRadio)
    {
        radio = elRadio;
    }

    public void OP()
    {
        perimetro = 2 * radio * Math.PI;

    }

    public void Ot()
    {
        area = Math.PI * Math.Pow(radio, 2);

    }
    public void mo()
    {
        string texto $"El perimetro es: {OP()} \nEl áre es: {Ot()}\nEl volumen es: {OV()}";
        Console.WriteLine(texto);
    }

    public void OV()
    {
        volumen = 4 * Math.PI * Math.Pow(radio, 3);
        volumen = volumen / 3;

    }

    static void Main(string[] args)
    {
        Console.WriteLine("Ingrese el radio");
        radio = Convert.ToDouble(Console.ReadLine());

        Circulo Obj_Circulo = new Circulo(radio);

        Obj_Circulo.Ot();
        Obj_Circulo.Ot();
        Obj_Circulo.OV();

        Obj_Circulo.mo();
        Console.ReadKey();
    }
}
}