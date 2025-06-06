namespace Annee_Bisextile
{
    public static class AnneeUtils
    {
        public static bool EstBissextile(int annee)
        {
            if (annee % 400 == 0){
                return true;
            }
            else if (annee % 100 == 0 && annee % 400 != 0)
            {
                return false;
            }
            else
            {
                return false;
            }
        }
    }
}

