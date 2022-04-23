using System.Text.RegularExpressions;

namespace LawBook
{
    public class Law
    {
        public static void MustNotBeEquals(object object1, object object2, string message)
        {
            if (object1.Equals(object2))
            {
                throw new GuiltyException(message);
            }
        }

        public static void MustBeEquals(object object1, object object2, string message)
        {
            if (!object1.Equals(object2))
            {
                throw new GuiltyException(message);
            }
        }

        public static void MustBeEquals(string regexExp, string value, string message)
        {
            var regex = new Regex(regexExp);

            if (!regex.IsMatch(value))
            {
                throw new GuiltyException(message);
            }
        }

        public static void MustBeLowerLength(string value, int max, string message)
        {
            var length = value.Trim().Length;
            if (length > max)
            {
                throw new GuiltyException(message);
            }
        }

        public static void MustBeInBetweensLength(string value, int min, int max, string message)
        {
            var length = value.Trim().Length;
            if (length < min || length > max)
            {
                throw new GuiltyException(message);
            }
        }

        public static void MustBeNotEmpty(string value, string message)
        {
            if (value == null || value.Trim().Length == 0 || value == string.Empty)
            {
                throw new GuiltyException(message);
            }
        }

        public static void MustBeNotNull(object? object1, string message)
        {
            if (object1 == null)
            {
                throw new GuiltyException(message);
            }
        }

        public static void MustNotBeInBetweens(double value, double min, double max, string message)
        {
            if (value < min || value > max)
            {
                throw new GuiltyException(message);
            }
        }

        public static void MustNotBeInBetweens(float value, float min, float max, string message)
        {
            if (value < min || value > max)
            {
                throw new GuiltyException(message);
            }
        }

        public static void MustNotBeInBetweens(int value, int min, int max, string message)
        {
            if (value < min || value > max)
            {
                throw new GuiltyException(message);
            }
        }

        public static void MustNotBeInBetweens(long value, long min, long max, string message)
        {
            if (value < min || value > max)
            {
                throw new GuiltyException(message);
            }
        }

        public static void MustNotBeInBetweens(decimal value, decimal min, decimal max, string message)
        {
            if (value < min || value > max)
            {
                throw new GuiltyException(message);
            }
        }

        public static void MustBeHigher(long value, long min, string message)
        {
            if (value < min)
            {
                throw new GuiltyException(message);
            }
        }

        public static void MustBeHigher(double value, double min, string message)
        {
            if (value < min)
            {
                throw new GuiltyException(message);
            }
        }

        public static void MustBeHigher(decimal value, decimal min, string message)
        {
            if (value < min)
            {
                throw new GuiltyException(message);
            }
        }

        public static void MustBeHigher(int value, int min, string message)
        {
            if (value < min)
            {
                throw new GuiltyException(message);
            }
        }

        public static void MustBeTrue(bool value, string message)
        {
            if (!value)
            {
                throw new GuiltyException(message);
            }
        }

        public static void MustBeFalse(bool value, string message)
        {
            if (value)
            {
                throw new GuiltyException(message);
            }
        }

        public static void MustBeContained(string value, string[] options, string message)
        {
            if (!options.Contains(value))
            {
                throw new GuiltyException(message);
            }
        }

        public static void MustNotBeContained(string value, string[] options, string message)
        {
            if (options.Contains(value))
            {
                throw new GuiltyException(message);
            }
        }

        public static void MustBeContained(int value, int[] options, string message)
        {
            if (!options.Contains(value))
            {
                throw new GuiltyException(message);
            }
        }

        public static void MustNotBeContained(int value, int[] options, string message)
        {
            if (!options.Contains(value))
            {
                throw new GuiltyException(message);
            }
        }
    }
}
