/*****************************************************************************************************************
 * You may amend and distribute as you like, but don't remove this header!
 * 
 * See https://github.com/TheLe0/LawBook for details.
 *
 * MIT License
 * 
 * Copyright (c) 2022 Leonardo Bertele Tosin
 * 
 * Permission is hereby granted, free of charge, to any person obtaining a copy of this software
 * and associated documentation files (the "Software"), to deal in the Software without restriction,
 * including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, 
 * and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so,
 * subject to the following conditions:
 * 
 * The above copyright notice and this permission notice shall be included in all copies or substantial 
 * portions of the Software.
 * 
 * THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT 
 * LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. 
 * IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY,
 * WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE
 * OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
 * 
 ****************************************************************************************************************/

namespace LawBook
{
    /// <summary>
    /// Class <c>Judge</c> is used as the executor for the validations.
    /// </summary>
    public static class Judge
    {
        /// <summary>
        /// Executes the <c>Validate</c> method on a <c>ILawable</c> class.
        /// </summary>
        /// <param name="lawableObject">The object to be validated.</param>
        /// /// <param name="silenceException">The flag if an exception must be thrown.</param>
        /// <returns>System.Boolean.</returns>
        public static bool Sentence(ILawable lawableObject,bool silenceException)
        {
            return (silenceException) ? ExecuteSilence(lawableObject) : Execute(lawableObject);
        }

        /// <summary>
        /// Execute the validation without thrown an exception.
        /// </summary>
        /// <param name="lawableObject">The object to be validated.</param>
        /// <returns>System.Boolean.</returns>
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

        /// <summary>
        /// Execute the validation throwing an exception 
        ///  if the validations fails.
        /// </summary>
        /// <param name="lawableObject">The object to be validated.</param>
        /// <exception cref="GuiltyException">lawableObject</exception>
        /// <returns>System.Boolean.</returns>
        private static bool Execute(ILawable lawableObject)
        {

            lawableObject.Validate();

            return true;
        }
    }
}
