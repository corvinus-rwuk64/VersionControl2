using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Entities;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        List<Person> Population = new List<Person>();
        List<BirthProbability> BirthProbabilities = new List<BirthProbability>();
        List<DeathProbability> DeathProbabilities = new List<DeathProbability>();

        Random rng = new Random(1234);

        List<int> numOfMales = new List<int>();
        List<int> numOfFemales = new List<int>();

        public Form1()
        {
            InitializeComponent();

        }

        public List<Person> GetPopulation(string csvpath)
        {
            List<Person> population = new List<Person>();

            using(StreamReader sr = new StreamReader(csvpath, Encoding.Default))
            {
                while (!sr.EndOfStream)
                {
                    var line = sr.ReadLine().Split(';');
                    population.Add(new Person()
                    {
                        BirthYear = int.Parse(line[0]),
                        Gender = (Gender)Enum.Parse(typeof(Gender), line[1]),
                        NumOfChildren = int.Parse(line[2])
                    });
                }
            }

            return population;
        }

        public List<BirthProbability> GetBirthProbabilities(string csvpath)
        {
            List<BirthProbability> birthProbabilities = new List<BirthProbability>();

            using (StreamReader sr = new StreamReader(csvpath, Encoding.Default))
            {
                while (!sr.EndOfStream)
                {
                    var line = sr.ReadLine().Split(';');
                    birthProbabilities.Add(new BirthProbability()
                    {
                        Age = int.Parse(line[0]),
                        NumOfChildren = int.Parse(line[1]),
                        Probability = double.Parse(line[2])
                    });
                }
            }

            return birthProbabilities;
        }

        public List<DeathProbability> GetDeathProbabilities(string csvpath)
        {
            List<DeathProbability> deathProbabilities = new List<DeathProbability>();

            using (StreamReader sr = new StreamReader(csvpath, Encoding.Default))
            {
                while (!sr.EndOfStream)
                {
                    var line = sr.ReadLine().Split(';');
                    deathProbabilities.Add(new DeathProbability()
                    {
                        Gender = (Gender)Enum.Parse(typeof(Gender), line[1]),
                        Age = int.Parse(line[0]),
                        Probability = double.Parse(line[2])
                    });
                }
            }

            return deathProbabilities;
        }

        public void SimStep(int year, Person p)
        {
            if (!p.IsAlive) return;

            byte age = (byte)(year - p.BirthYear);

            double pDeath = (from x in DeathProbabilities
                             where x.Gender == p.Gender && x.Age == age
                             select x.Probability).FirstOrDefault();

            if (rng.NextDouble() <= pDeath)
                p.IsAlive = false;

            if (p.IsAlive && p.Gender == Gender.Female)
            {
                double pBirth = (from x in BirthProbabilities
                                 where x.Age == age
                                 select x.Probability).FirstOrDefault();

                if (rng.NextDouble() <= pBirth)
                {
                    Person újSzülött = new Person();
                    újSzülött.BirthYear = year;
                    újSzülött.NumOfChildren = 0;
                    újSzülött.Gender = (Gender)(rng.Next(1, 3));
                    Population.Add(újSzülött);
                }
            }
        }

        private void Simulation()
        {
            numOfFemales.Clear();
            numOfMales.Clear();
            richTextBox1.Clear();

            if (yearPicker.Value <= 2005)
            {
                MessageBox.Show("Minimum érték: 2005");
                return;
            }

            for (int year = 2005; year <= yearPicker.Value; year++)
            {
                for (int i = 0; i < Population.Count; i++)
                {
                    SimStep(year, Population[i]);
                }

                numOfMales.Add((from x in Population
                                where x.Gender == Gender.Male && x.IsAlive
                                select x).Count());
                numOfFemales.Add((from x in Population
                                  where x.Gender == Gender.Female && x.IsAlive
                                  select x).Count());
            }
        }

        private void DisplayResults()
        {
            int currentIndex = 0;
            for(int year = 2005; year <= yearPicker.Value; year++)
            {
                currentIndex = year - 2005;
                richTextBox1.AppendText(string.Format("Szimulációs év:{0} \n\tFiúk:{1} \n\tLányok:{2}\n\n", year, numOfMales[currentIndex], numOfFemales[currentIndex]));
            }
            
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            Population = GetPopulation(csvpathBox.Text);
            BirthProbabilities = GetBirthProbabilities(@"C:\Users\plank\AppData\Local\Temp\születés.csv");
            DeathProbabilities = GetDeathProbabilities(@"C:\Users\plank\AppData\Local\Temp\halál.csv");

            Simulation();

            DisplayResults();
        }

        private void browseButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            ofd.ShowDialog();
            csvpathBox.Text = ofd.FileName;
        }
    }
}
