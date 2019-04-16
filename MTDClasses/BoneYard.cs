using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MTDClasses
{
    public class BoneYard
    {
        private List<Domino> dList;
        public int dominos => dList.Count;

        public BoneYard(int maxDots)
        {
            dList = new List<Domino>();
            for (int side1 = 0; side1 <= maxDots; side1++)
            {
                for (int side2 = side1; side2 <= maxDots; side2++)
                {
                    dList.Add(new Domino(side1, side2));
                }
            }
        }

        public void Shuffle()
        {
            Random rand = new Random();

            for (int i = 0; i < dList.Count; i++)
            {
                int randIndex = rand.Next(0, dList.Count);
                Domino firstDomino = dList[i];
                Domino secondDomino = dList[randIndex];

                dList[i] = secondDomino;
                dList[randIndex] = firstDomino;
            }
        }

        public bool IsEmpty()
        {
            if (dominos == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public int DominosRemaining
        {
            get { return dList.Count; }
        }

        public Domino Draw()
        {
            Domino firstDomino = dList[0];
            dList.Remove(firstDomino);
            return firstDomino;
        }

        public Domino this[int i]
        {
            get { return dList[i]; }
        }

        public override string ToString()
        {
            string output = "";

            foreach (Domino d in dList)
            {
                output += d.ToString() + "\n";

            }
            return "";
        }

    }
}
