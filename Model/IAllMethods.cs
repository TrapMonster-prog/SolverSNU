namespace SolverSNE.Model
{
    interface IAllMethods
    {
        string MethodName { get; }
        double[] Solve(double[,] matrixA, double[] vectorB);
    }
}
