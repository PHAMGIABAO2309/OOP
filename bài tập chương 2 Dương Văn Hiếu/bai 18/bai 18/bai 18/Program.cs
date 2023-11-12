using System;
// Lớp Polynomial mô tả một đa thức
public class Polynomial
{
    public float[] coefficients;

    public Polynomial(float[] coefficients)
    {
        this.coefficients = coefficients;
    }

    // Tính giá trị của đa thức tại x
    public float Evaluate(float x)
    {
        float result = 0;
        for (int i = 0; i < coefficients.Length; i++)
        {
            result += coefficients[i] * Math.Pow(x, i);
        }
        return result;
    }
}

// Lớp PolynomialDerivative mô tả đạo hàm của một đa thức
public class PolynomialDerivative : Polynomial
{
    public PolynomialDerivative(Polynomial polynomial)
    {
        this.coefficients = new float[polynomial.coefficients.Length - 1];
        for (int i = 1; i < polynomial.coefficients.Length; i++)
        {
            this.coefficients[i - 1] = i * polynomial.coefficients[i];
        }
    }
}

// Chương trình chính
public class Program
{
    public static void Main(string[] args)
    {
        // Tạo đa thức
        float[] coefficients = { 2, 3, 4, 5 };
        Polynomial polynomial = new Polynomial(coefficients);

        // Tính đạo hàm của đa thức
        PolynomialDerivative derivative = new PolynomialDerivative(polynomial);

        // Xuất ra kết quả
        Console.WriteLine("Đạo hàm của đa thức là:");
        for (int i = 0; i < derivative.coefficients.Length; i++)
        {
            Console.Write(derivative.coefficients[i] + " ");
        }
        Console.WriteLine();
    }
}
