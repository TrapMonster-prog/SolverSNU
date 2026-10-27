using SolverSNE.Model.Ruchkin;

namespace SolverSNE.Model
{
    internal class SolverFactory
    {
        public static IReadOnlyList<IAllMethods> All { get; } = new List<IAllMethods>
        {
             new SecantMethod(),
        };
    }
}
