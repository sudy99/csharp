using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    enum Fakulta
    {
        FES,
        FF,
        FEI,
        FCHT
    }

    enum DruhTrideni
    {
        PODLE_CISLA,
        PODLE_JMENA,
        PODLE_FAKULTY
    }
    class Student
    {
        private string jmeno;
        public string Jmeno { get { return jmeno; } set { jmeno = value; } }
        private int cislo;
        public int Cislo { get { return cislo; } set { cislo = value; } }
        private Fakulta fakulta;
        public Fakulta Fakulta { get { return fakulta; } set { fakulta = value; } }

        public Student(string jmeno, int cislo, Fakulta fakulta)
        {
            this.jmeno = jmeno;
            this.cislo = cislo;
            this.fakulta = fakulta;
        }
        public static int CompareByJmeno(Student stud1, Student stud2)
        {
            return String.Compare(stud1.Jmeno, stud2.Jmeno);
        }

        public static int CompareByCislo(Student stud1, Student stud2)
        {
            return stud1.Cislo.CompareTo(stud2.Cislo);
        }

        public static int CompareByFaktulta(Student stud1, Student stud2)
        {
            return stud1.Fakulta.CompareTo(stud2.Fakulta);
        }
    }

    class Studenti
    {
        delegate int PorovnejStudenty(Student student1, Student student2);

        Student[] poleStudentu = new Student[3];
        public void NactiStudenty()
        {
            for (int i = 0; i < poleStudentu.Length; i++)
            {
                Console.WriteLine("Nacti jmeno studenta: ");
                string noveJmeno = Console.ReadLine();
                Console.WriteLine("Nacti cislo studenta: ");
                int noveCislo = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Nacti fakultu studenta 0-FES, 1-FF, 2-FEI, 3-FCHT");
                Fakulta novaFakulta = (Fakulta)Convert.ToInt32(Console.ReadLine());
                poleStudentu[i] = new Student(noveJmeno, noveCislo, novaFakulta);
            }
        }
        public void VypisStudenty()
        {
            for (int i = 0; i < poleStudentu.Length; i++)
            {
                Console.WriteLine("Jmeno: " + poleStudentu[i].Jmeno + " Cislo: " + poleStudentu[i].Cislo + " Fakulta: " + poleStudentu[i].Fakulta);
            }
        }
        public void ProvnejStudenty(DruhTrideni trideni)
        {
            PorovnejStudenty PorovnejStudenty = null;
            if (trideni == DruhTrideni.PODLE_CISLA)
            {
                PorovnejStudenty = Student.CompareByCislo;
            }
            else if (trideni == DruhTrideni.PODLE_JMENA)
            {
                PorovnejStudenty = Student.CompareByJmeno;
            }
            else if (trideni == DruhTrideni.PODLE_FAKULTY)
            {
                PorovnejStudenty = Student.CompareByFaktulta;
            }

            for (int a = 0; a < poleStudentu.Length; a++)
            {
                for (int i = 0; i < poleStudentu.Length - 1; i++)
                {
                    if (0 < PorovnejStudenty(poleStudentu[i], poleStudentu[i + 1]))
                    {
                        Student pom = poleStudentu[i];
                        poleStudentu[i] = poleStudentu[i + 1];
                        poleStudentu[i + 1] = pom;
                    }
                }
            }
        }
    }

    class TabulkaStudentu
    {
        public Student NajdiStudenta()
        {
            return null;
        }
        public bool VlozStudenta()
        {
            return false;
        }
        public bool OdeberStudenta()
        {
            return false;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Studenti mojiStudenti = new Studenti();
            while (true)
            {
                Console.WriteLine("1) nacti studenty");
                Console.WriteLine("2) Vypis studenty");
                Console.WriteLine("3) serad podle cisla");
                Console.WriteLine("4) serad podle jmena");
                Console.WriteLine("5) serad podle fakulty");
                Console.WriteLine("0) konec programu");

                int pom = Convert.ToInt32(Console.ReadLine());
                if (pom == 1)
                {
                    mojiStudenti.NactiStudenty();
                }
                else if (pom == 2)
                {
                    mojiStudenti.VypisStudenty();
                }
                else if (pom == 3)
                {
                    mojiStudenti.ProvnejStudenty(DruhTrideni.PODLE_CISLA);
                }
                else if (pom == 4)
                {
                    mojiStudenti.ProvnejStudenty(DruhTrideni.PODLE_JMENA);
                }
                else if (pom == 5)
                {
                    mojiStudenti.ProvnejStudenty(DruhTrideni.PODLE_FAKULTY);
                }
                else if (pom == 0)
                {
                    break;
                }
            }

            Console.ReadKey();


        }
    }
}