using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    public class Vizsga
    {
        string nyelv;
        List<int> evek = new List<int>();

        public Vizsga(string sor)
        {
            List<string> bontottSor = new List<string>();
            bontottSor = sor.Split(";").ToList();
            this.nyelv = bontottSor[0];
            bontottSor.RemoveAt(0);
            bontottSor.ForEach(x => this.evek.Add(int.Parse(x)));
        }



        public string Nyelv { get => nyelv; set => nyelv = value; }
        public List<int> Evek { get => evek; set => evek = value; }
    }
}
