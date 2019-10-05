﻿namespace Cracking.Chapter1
{
    /// <summary>
    /// Write a method to replace all spaces in a string with '%20'.
    /// </summary>
    interface IProblem5
    {
        T[] Replace<T>(T[] ts, T source, T[] target);

        string Replace(string s) =>
            new string(
                Replace(s.ToCharArray(), ' ', new[] { '%', '2', '0' })
                );
    }
}
