﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace projet_cryptage
{
    public partial class Form1 : Form
    {
        static char[] alfa1;
        static string phraseclair;
        static int num;
        static string phrasechiffre;
        static char[] monfichierclair;

        
        char[] alfareversible;

        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void butCHEMIN_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            textCHEMIN.Text = openFileDialog1.FileName;
        }

        private void textCHEMIN_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // on recupere le contenu de chemin specifié par l'utilisateur
            if (textCHEMIN.Text!="c/")
            {
                string path = textCHEMIN.Text;
                Stream sin = File.OpenRead(path);
                byte[] toNode = new byte[sin.Length];
                sin.Read(toNode, 0, (int)sin.Length);
                sin.Close();
                monfichierclair = new char[toNode.Length];
                for (int i = 0; i < monfichierclair.Length; i++)
                {
                    monfichierclair[i] = (char)toNode[i];

                }
            }
            //

            // on crée un tableau des 26 lettres alphabetiques sur lequel nous allons nous basé
            //pour realiseé le criptage selon la methode souhaité
            alfa1 = new char[26];
            int n = 0;
            for (char i = 'A'; i <= 'Z'; i++)
			{
			 alfa1[n] = i;
             n = n + 1;
			}          

            // si l'utilisateur a plutôt coché le chiffre de cesar alors on accede
            if (butcesar.Checked==true)
            {
                num = (int)numericUpDown1.Value;  //on recupere le decalage qui servira selon chiffre_cesar

                // cette partie ci est juste une demo de la transformation de l'alfabet selon chiffre_cesar
                //qui sera affiché sur le controle tableLayoutPanel1 
                int c = 25;
               

                int acces = 0; // acces=0 variable qui sera envoye à la classe chiffre_cesar pour que cette classe connaisse les conditions à appliquer si on travaille avec le button chiffrer
                
                //ici; on recherche si l'utilisateur a choisi d'entrer lui meme le message ou de un fichier texte 
                if (monfichierclair==null)
                {
                    phraseclair = texteclair.Text;
                }
                if (texteclair.Text=="")
                {
                    phraseclair = "";
                    for (int i = 0; i < monfichierclair.Length; i++)
                    {
                        phraseclair = phraseclair + monfichierclair[i];
                    }
                }
                //
                // on utilise la classe Chiffre_cesar pour transformer directement le texte original en la methode du Chiffre_cesar
                Chiffre_cesar cesar = new Chiffre_cesar(alfa1, num, ref phraseclair, acces, ref phrasechiffre);
                //
                textechiffre.Text = phrasechiffre;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (butcesar.Checked == true)
            {
                phrasechiffre = textechiffre.Text;
                int acces = 1; // acces=1 variable qui sera envoye à la classe chiffre_cesar pour que cette classe connaisse les conditions à appliquer si on travaille avec le button dechiffrer
                Chiffre_cesar cesar = new Chiffre_cesar(alfa1, num, ref phraseclair, acces, ref phrasechiffre);
                texteclair.Text = phraseclair;
            }
        }

        private void butcesar_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            texteclair.Text = "";
            textechiffre.Text = "";
            textCHEMIN.Text = "c/";
        }

        private void butreversible_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textechiffre_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
