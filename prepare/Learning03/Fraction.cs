public class Fraction
{

    // Private Attributes, we want getters and setters for these
    private int _top;
    private int _bottom;

    // Constructors
    // We use constructors to create a new object in several ways

    // no parameters, initial values 1
    public Fraction()
    {
        Top = 1;
        Bottom = 1;
    }
    // one parameter for top,bottom initializes to 1,for whole numbners
    public Fraction(int wholeNumber)
    {
        Top = wholeNumber; // this value should end up same as output
        Bottom = 1;
    }
    // two parameters for top and bottom
    public Fraction(int top, int bottom)
    {
        // These can be any number
        Top = top;
        Bottom = bottom;
    }

    public int Top { get { return _top; } set { _top = value; } }
    public int Bottom { get { return _bottom; } set { _bottom = value; } }

    // // Getter for _top
    // public int getTop() 
    // {
    //     return _top;
    // }

    // // Setter for _top
    // public void setTop(int top) 
    // {
    //     _top = top;
    // }

    // // Getter for _bottom
    // public int getBottom() 
    // {
    //     return _bottom;
    // }

    // // Setter for _bottom
    // public void setBottom(int bottom) 
    // {
    //     _bottom = bottom;
    // }

}