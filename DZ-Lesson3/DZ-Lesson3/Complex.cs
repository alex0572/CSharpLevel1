using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

struct Complex
{
    public double im;
    public double re;
    //  Пример суммы двух комплексных чисел
    public Complex Plus(Complex x)
    {
        Complex y;
        y.im = im + x.im;
        y.re = re + x.re;
        return y;
    }
    // Пример вычитания двух комплексных чисел
    public Complex Minus(Complex x)
    {
        Complex y;
        y.im = im - x.im;
        y.re = re - x.re;
        return y;
    }

    //  Пример произведения двух комплексных чисел
    public Complex Multi(Complex x)
    {
        Complex y;
        y.im = re * x.im + im * x.re;
        y.re = re * x.re - im * x.im;
        return y;
    }
    public string ToString()
    {
        return re + "+" + im + "i";
    }
}
