class HinhTamGiac
{
    public double A;
    public double B;
    public double C;

    public double ChuVi()
    {
        return A + B + C;
    }

    public double DienTich()
    {
        double p = ChuVi() / 2;
        return Math.Sqrt(p * (p - A) * (p - B) * (p - C));
    }
}
