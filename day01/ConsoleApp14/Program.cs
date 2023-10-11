class Circle
{
    double pi = 3.14;

    public double Pi
    {
        get { return pi; }
        set { pi = value; }
    }
}

Circle o = new Circle();
o.Pi = 3.14159;
double piValue = o.Pi;