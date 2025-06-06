namespace Annee_Bisextile
{
    public static class AnneeUtils
    {
        public static bool EstBissextile(int annee)
        {
            if (annee % 400 == 0){
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}

