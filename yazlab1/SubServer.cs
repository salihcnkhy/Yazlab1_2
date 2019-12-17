using System;
using System.Threading;
using System.Threading.Tasks;

namespace yazlab1
{
    public class SubServer
    {
        public int serverNum;
        private int acceptDelay = 500;
        private int maxCapacity = 5000;
        private int comfirmationDelay = 300;
        private int currentCapacity = 0;
        private MainServer ms;
        public int requestSize = 100;
        public int responseSize = 50;
        private static SemaphoreSlim _mainSem = new SemaphoreSlim(1);


        public SubServer(MainServer ms, int serverNum)
        {
            this.ms = ms;
            this.serverNum = serverNum;
            serverControl();

        }



        private void serverControl()
        {


            Thread req = new Thread(new ThreadStart(getRequest));
            Thread res = new Thread(new ThreadStart(doneRequest));

            req.Start();
            res.Start();


        }

        private void getRequest()
        {

            while (true)
            {
                Random random = new Random();
                int requestCount = random.Next(requestSize);

                _mainSem.Wait();


                ms.makeCall(() =>
                {

                    if (ms.CurrentCapacity < requestCount)
                    {
                        currentCapacity += ms.CurrentCapacity;
                        ms.CurrentCapacity = 0;

                    }
                    else
                    {

                        currentCapacity += requestCount;
                        ms.CurrentCapacity -= requestCount;
                    }

                    var per = Convert.ToDouble(((double)(currentCapacity+0.0001) / maxCapacity));

                    if (per > 0.7) {

                        SubServer ss = new SubServer(ms, ms.subServers.Count);
                        ss.currentCapacity = currentCapacity / 2;
                        if(CurrentCapacity %2 == 0) {
                            currentCapacity /= 2;
                        }
                        else {
                            currentCapacity /= 2 + 1;
                        }
                        ss.requestSize = requestSize;
                        ss.responseSize = responseSize;

                        ms.subServers.Add(ss);


                    }

                    
                    return null;
                });
                

                _mainSem.Release();


                Thread.Sleep(acceptDelay);
            }

        }

        private void addSS() {



        }

        private void doneRequest()
        {

            while (true)
            {
                Random random = new Random();

                int doneCount = random.Next(responseSize);

                _mainSem.Wait();

                if (doneCount > currentCapacity)
                {
                    currentCapacity = 0;
                }
                else
                {
                    currentCapacity -= doneCount;
                }
                ms.totalResponse += doneCount;

               
                if (currentCapacity == 0)
                {
                    if(ms.subServers.Count > 2)
                    {
                      //  ms.form.resetCircle(ms.subServers.IndexOf(this));
                        ms.subServers.Remove(this);


                    }


                }


                _mainSem.Release();


                Thread.Sleep(comfirmationDelay);

            }

        }


        public double AcceptDelay
        {
            get
            {
                return acceptDelay;
            }
        }


        public double ComfirmationDelay
        {
            get
            {
                return comfirmationDelay;
            }
        }


        public int MaxCapacity
        {
            get
            {
                return maxCapacity;
            }
        }


        public int CurrentCapacity
        {
            get
            {
                return currentCapacity;
            }
            set
            {

                currentCapacity = value;
            }
        }





    }
}
