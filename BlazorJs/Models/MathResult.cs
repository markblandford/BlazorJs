public class MathResult {
    public MathResult(string calc)
    {
        Calculation = calc;
    }
    public string Calculation { get; set; }
    public decimal JsResult { get; set; }
    public double CSharpResult { get; set; }
}