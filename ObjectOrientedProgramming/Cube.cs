// See https://aka.ms/new-console-template for more information

class Cube : Shape, InterFaceShape
{
    public double getArea()
    {
        return Hieght * Width;
    }
    public double getLeinghts()
    {
        return 2 * (Hieght + Width);
    }
}
