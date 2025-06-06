using Xunit;

namespace Annee_Bisextile
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(400)]
        public void AnneeDivissiblePar400EstBisextile(short a)
        {
            var result = AnneeUtils.EstBissextile(a);
        }
    }
}