using Aula_7___Urna_Eletrônica__Katia_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TreeView;
using System.Windows.Forms;

namespace Aula_7___Urna_Eletrônica__Katia_
{
    internal class Candidato
    {
    }
}
//em form1.cs

//private void insereCandidato()
//{
//    alguem = new Candidato();
//    alguem.Numero = 12;
//    alguem.Nome = "Antonio Silva";
//    alguem.Turma = "1º ADS";
//    alguem.Foto = "antonio.jpg;
//lista[0] = alguem;

//    alguem = new Candidato();
//    alguem.Numero = 32;
//    alguem.Nome = "Diogo Jota";
//    alguem.Turma = "1º ADS";
//    alguem.Foto = "diogo.jpg;
//lista[1] = alguem;


//    fazer urna!!

//    classes: canditado

//    Lista = new Candidato[4];


//para cada botão tem um valor (sendo o mesmo numero)**

//btnConfirma_Click(object sender, EventArgs e)
//{
//    SoundPlayer som = new SoundPlayer(@"local onde esta salvo o som");
//    som.Play();
//    int valido = 0;
//    for (int i = 0; i < 4; i++)
//    {
//        if (int.Parse(numero) == lista[i].Numero)
//        {
//            lista[i].Voto++;
//            valido = 1;
//        }
//    }
//    if (numero == "Branco")
//    {
//        branco++;
//        valido = 1;
//    }
//    {
//else
//        {
//            if (int.Parse(numero) == lista[1].Numero)
//            {
//                lista[i].Voto++;
//                valido = 1;
//            }
//            {
//                if (valido == 0)
//                {
//                    nulo++;
//                }
//            }
//            eleitores++;
//            corrige();
//            if (eleitores == 9)
//            {
//                sring texto = "Nulo" + nulo"\nBranco=" + branco; ** concatena nulo e branco
//                for (int i = 0; i < 4; i++;)
//{
//                    texto += "\n" + lista[i].Nome + "=" + lista[i].Voto; **concatena nome e voto do candidato
//                }
//                MessageBox.Show(texto);
//            }



//            private void btnBranco_Click(object sender, EventArgs e)
//            {
//                numero = "Branco";
//                lblMensagem.Visible = true;
//                btnConfirma.Enable = true;
//                lblCandidato.text = "VOTO EM BRANCO";
//            }


//            private void corrige()
//            {
//                txtNum1.Text = null;
//                txtNum2.Text = null;
//                lblCandidato.Text = null;
//                lblTurma.Text = null;
//                lblMensagem.Visible = false;
//                btnConfirma.Enable = false;
//                numero = "";
//                pxFoto.Image = null;
//            }

//            private void btnCorrige_Click(object sender, EventArgs e)
//            {
//                tecla();
//                corrige();
//            }
