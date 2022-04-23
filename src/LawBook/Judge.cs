
namespace LawBook
{
    public static class Judge
    {
        public static bool Sentence(ILawable lawableObject,bool silenceException)
        {
            return (silenceException) ? ExecuteSilence(lawableObject) : Execute(lawableObject);
        }

        private static bool ExecuteSilence(ILawable lawableObject)
        {
            try
            {
                lawableObject.Validate();
            }
            catch (GuiltyException)
            {
                return false;
            }

            return true;
        }

        private static bool Execute(ILawable lawableObject)
        {

            lawableObject.Validate();

            return true;
        }
    }
}
