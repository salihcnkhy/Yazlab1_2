using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace yazlab1 {
    public class MainServer {
       
        private static int acceptDelay = 500;
        private static int comfirmationDelay = 200;
        public int maxCapacity = 10000;
        private static int currentCapacity = 0;
        public int requestSize = 100;
        public int responseSize = 50;
        public List<SubServer> subServers;
        public bool start;
        public int totalRequest;
        public int totalResponse;

        private static SemaphoreSlim _mainSem = new SemaphoreSlim(1);

        public Form1 form;


        public MainServer(Form1 form) {
            this.form = form;
            start = false;
            totalRequest = 0;
            totalResponse = 0;
            subServers = new List<SubServer>();


            subServers.Add(new SubServer(this, 1));
            subServers.Add(new SubServer(this, 2));
            serverControl();
          
            serverStateWatcher(form);

        }

        private void serverStateWatcher(Form1 form) {
            Thread t2 = new Thread(new ThreadStart(() => {
                while (true) {
                    form.stateWatcher();
                    calcTotalReq();
                    Thread.Sleep(300);
                }
            }));

            t2.Start();
        }


        public void serverControl() {
            Thread req = new Thread(new ThreadStart(getRequest));
            Thread res = new Thread(new ThreadStart(doneRequest));
            
            req.Start();
            res.Start();
        }


        private void getRequest() {

            while (true) {
                Random random = new Random();
                int requestCount = random.Next(requestSize);


                makeCall(() => {
                    if (currentCapacity + requestCount > maxCapacity) {
                        currentCapacity = maxCapacity;

                    }
                    else {
                        currentCapacity += requestCount;
                    }

                  
                    return null;
                });

             
                Thread.Sleep(acceptDelay);
               

            }



        }

        public void makeCall(Func<Task> function) {
            _mainSem.Wait();
            function.Invoke();
            _mainSem.Release();
        }

        private void doneRequest() {

            while (true) {
                Random random = new Random();

                int doneCount = random.Next(responseSize);

                makeCall(() => {
                    if (doneCount > currentCapacity) {
                        currentCapacity = 0;
                    }
                    else {
                        currentCapacity -= doneCount;
                    }
                    totalResponse += doneCount;

                    return null;
                });

               

                Thread.Sleep(comfirmationDelay);
            }

        }
        private void calcTotalReq() {

            totalRequest = 0;
            
            for(int i = 0; i < subServers.Count; i++) {

                totalRequest += subServers[i].CurrentCapacity;

            }
            totalRequest += this.CurrentCapacity;

            
        }




        public int CurrentCapacity {
            get {
                return currentCapacity;
            }
            set {

                currentCapacity = value;
            }
        }



    }
}
