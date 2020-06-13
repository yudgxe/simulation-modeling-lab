using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace imit18
{
    class lab18
    {
        const float La = 0.7f, Mu = 0.8f;

        int BusyWindowsCount = 0, ClientsInQue = 0, windowsCount = 0, NumbOfMin, numbOfExp, clientsInBank = 0, ClientsTotal = 0, agentsCount;

        float min = int.MaxValue;

        List<Agent> agents = new List<Agent>();
        List<float> taus = new List<float>();
        List<float> PosibilityTheo = new List<float>();

        Random rnd = new Random();

        Dictionary<int, int> Freq = new Dictionary<int, int>();

        public lab18(int windowsCount, int agentsCount, int numbOfExp)
        {
            this.windowsCount = windowsCount;
            this.agentsCount = agentsCount;
            this.numbOfExp = numbOfExp;
        }

        public void Start()
        {
            for (int i = 0; i < agentsCount; i++)
            {
                agents.Add(new Agent(La));
                taus.Add(agents[i].GetNextEvent());

                if (taus[i] < min)
                {
                    min = taus[i];
                    NumbOfMin = i;
                }
            }

            for (int i = 0; i < numbOfExp; i++)
            {
                CalcCounter(min);
                FreqAdder(clientsInBank);

                min = int.MaxValue;
                taus[NumbOfMin] = agents[NumbOfMin].GetNextEvent();
                for (int j = 0; j < agentsCount; j++)
                {
                    if (taus[j] < min)
                    {
                        min = taus[j];
                        NumbOfMin = j;
                    }
                }
                PosibilityTheo.Add(CalculateStats(clientsInBank, agentsCount, La, Mu));

                Console.WriteLine("System State");
                Console.WriteLine("BusyWindows: " + BusyWindowsCount);
                Console.WriteLine("Agents in Queue: " + ClientsInQue);
                Console.WriteLine("Theoretical System State: " + PosibilityTheo[i]);
                Console.WriteLine("----------------------------------");

            }

            foreach (var item in Freq)
            {
                Console.WriteLine("Emperical System State: " + (float)item.Value / (float)numbOfExp);
            }
        }

        void FreqAdder(int Key,int Value = 1)
        {
            if (Freq.ContainsKey(Key))
                Freq[Key]++;
            else
                Freq.Add(Key, Value);
        }

        void CalcCounter(float min)
        {
            float Delta = ExpRv(Mu * BusyWindowsCount);

            if (min < Delta)
            {
                if (BusyWindowsCount < windowsCount)
                {
                    BusyWindowsCount++;
                }
                else
                {
                    ClientsInQue++;
                }
                clientsInBank++;
                ClientsTotal++;
            }
            else
            {
                if (ClientsInQue == 0)
                {
                    BusyWindowsCount--;
                }
                else
                {
                    ClientsInQue--;
                }
                clientsInBank--;
            }


        }

        float ExpRv(float x) => (float)(-Math.Log(rnd.NextDouble()) / x);

        float CalculateStats(int clientsInBank, int agentsNum, float lambda, float mu)
        {
            float distribution;
            float Rho;
            float RhoToK;
            float sum = 1;
            float factorN;

            Rho = lambda / mu;
            RhoToK = (float)Math.Pow(Rho, clientsInBank); 
            factorN = CalculateFactorial(agentsNum); 

            if (clientsInBank < agentsNum)
            {
                distribution = RhoToK / CalculateFactorial(clientsInBank); 
            }
            else
            {
                distribution = RhoToK / (factorN * (float)Math.Pow(agentsNum, clientsInBank - agentsNum)); 
            }

            int j = 1;
            float localRho = Rho;

            for (int i = 1; i <= agentsNum; i++) 
            {
                j *= i;
                sum += localRho / j; 
                localRho *= Rho; 
            }

            sum += localRho / (factorN * (agentsNum - Rho)); 
            sum = 1 / sum; 
            distribution *= sum; 

            return distribution; 
        }

        /*float StatTheo()
        {
            float PT;
            if (ClientsInBank < windowsCount)
            {
                float sum = 0;
                for (int i = 0; i < windowsCount; i++)
                {
                    sum += ((float)Math.Pow(La / Mu, ClientsInBank) / Factor(ClientsInBank));
                }
                sum += ((float)Math.Pow(La / Mu, windowsCount + 1) / (Factor(windowsCount) * (windowsCount - (La / Mu))));
                sum = (float)Math.Pow(sum, -1);
                PT = ((float)Math.Pow(La / Mu, ClientsInBank) / Factor(ClientsInBank)) * sum;
            }
            else
            {
                float sum = 0;
                for (int i = 0; i < windowsCount; i++)
                {
                    sum += ((float)Math.Pow(La / Mu, ClientsInBank) / Factor(ClientsInBank));
                }
                sum = (float)Math.Pow(sum, -1);
                PT = ((float)Math.Pow(La / Mu, ClientsInBank) / (Factor(windowsCount) * (float)Math.Pow(windowsCount, ClientsInBank - windowsCount))) * sum;
            }
            return PT;
        }
        */

        float CalculateFactorial(int x)
        {
            int Mul = 1;
            if (x == 0)
            {
                return 1;
            }
            else
            {
                while (x > 0)
                {
                    Mul *= x;
                    x--;
                }
                return Mul;
            }
        }
    }
}
