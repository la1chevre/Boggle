﻿using System;


namespace BoogleGame
{
    internal class De
    {
        public char face;
        public char[] faces;

        public De()
        {
            char[] lettres = new char[25] { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };
            this.faces = new char[6];
            for (int i = 0; i < 6; i++)
            {
                Random random = new Random();
                this.faces[i] = lettres[random.Next(0, 25)];
            }
        }

        /// <summary>
        /// Définis une face visible aléatoirement parmis les 6 faces du dé
        /// </summary>
        /// <returns></returns>
        public void lance()
        {
            Random random = new Random();
            this.face = this.faces[random.Next(0, 6)];
        }

        /// <summary>
        ///  retourne une chaîne de caractères qui décrit un dé 
        /// </summary>

        /// <returns>"FaceA FaceB FaceC FaceD FaceE FaceF"</returns>

        public string toString()
        {
            string res = "";
            for (int i = 0; i < faces.Length; i++)
            {
                res += " " + faces[i];
            }
            return res;
        }



    }
}
