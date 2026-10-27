namespace SolverSNE.Model
{
    interface IAllMethods<T>
    {
        string MethodName { get; }
        double[] Solve(double[,] matrixA, double[] vectorB);
    }
}
